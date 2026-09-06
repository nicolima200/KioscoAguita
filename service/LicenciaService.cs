using Microsoft.IdentityModel.Tokens;
using System;
using System.Configuration;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Reflection;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace service
{
    public class LicenciaService
    {
        private static string UrlBase
        {
            get
            {
                return ConfigurationManager.AppSettings["LicenciaApiUrl"]
                    ?? "http://localhost:5161";
            }
        }
        private static readonly HttpClient cliente = new HttpClient()
        {
            Timeout = TimeSpan.FromSeconds(30)
        };

        static LicenciaService()
        {
            // Windows 7 may not select TLS 1.2 automatically for .NET Framework.
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        }

        private static readonly string CarpetaDatos =
    Path.Combine(
        Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
        "KioscoAguita");
        private static readonly string RutaToken = Path.Combine(CarpetaDatos, "licencia.token");

        public async Task<string> ActivarAsync(string email, string password)
        {
            HttpResponseMessage respuesta;
            try
            {
                respuesta = await cliente.PostAsJsonAsync(
                    $"{UrlBase}/activar",
                    new { email, password });
            }
            catch (TaskCanceledException)
            {
                throw new Exception("No se pudo conectar con el servidor de licencias. Verificá tu conexión a Internet e intentá nuevamente.");
            }
            catch (HttpRequestException)
            {
                throw new Exception("No se pudo conectar con el servidor de licencias. Verificá tu conexión a Internet e intentá nuevamente.");
            }

            if (respuesta.StatusCode == HttpStatusCode.Unauthorized)
                throw new Exception("Email o contraseña incorrectos.");

            if (respuesta.StatusCode == HttpStatusCode.PaymentRequired)
                throw new Exception("La licencia no está activa o venció.");

            respuesta.EnsureSuccessStatusCode();

            var resultado = await respuesta.Content.ReadFromJsonAsync<RespuestaActivar>();
            return resultado.Token;
        }

        private class RespuestaActivar
        {
            public string Token { get; set; }
        }

        private class RespuestaTicket
        {
            public string Ticket { get; set; }
        }

        private const string MensajeSinConexion = "No se pudo conectar con el servidor de licencias. Verificá tu conexión a Internet e intentá nuevamente.";

        public async Task<string> AutorizarRestablecimientoAsync(string codigo)
        {
            string token = LeerTokenGuardado();
            if (token == null)
                throw new Exception("No hay una licencia activa guardada en este equipo.");

            HttpRequestMessage pedido = new HttpRequestMessage(HttpMethod.Post, $"{UrlBase}/restablecimientos/autorizar");
            pedido.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
            pedido.Content = JsonContent.Create(new { codigo });

            HttpResponseMessage respuesta;
            try
            {
                respuesta = await cliente.SendAsync(pedido);
            }
            catch (TaskCanceledException)
            {
                throw new Exception(MensajeSinConexion);
            }
            catch (HttpRequestException)
            {
                throw new Exception(MensajeSinConexion);
            }

            if (respuesta.StatusCode == HttpStatusCode.Unauthorized)
                throw new Exception("La licencia no está activa o venció.");

            if (!respuesta.IsSuccessStatusCode)
                throw new Exception("No se pudo validar el código. Verificá que sea correcto y volvé a intentar.");

            RespuestaTicket resultado = await respuesta.Content.ReadFromJsonAsync<RespuestaTicket>();
            return resultado.Ticket;
        }

        public async Task ConfirmarRestablecimientoAsync(string ticket)
        {
            string token = LeerTokenGuardado();
            if (token == null)
                throw new Exception("No hay una licencia activa guardada en este equipo.");

            HttpRequestMessage pedido = new HttpRequestMessage(HttpMethod.Post, $"{UrlBase}/restablecimientos/confirmar");
            pedido.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
            pedido.Content = JsonContent.Create(new { ticket });

            HttpResponseMessage respuesta;
            try
            {
                respuesta = await cliente.SendAsync(pedido);
            }
            catch (TaskCanceledException)
            {
                throw new Exception(MensajeSinConexion);
            }
            catch (HttpRequestException)
            {
                throw new Exception(MensajeSinConexion);
            }

            // Un ticket ya consumido o inexistente no se reintenta ni se reporta como error:
            // el reset local ya se completó.
            if (respuesta.StatusCode == HttpStatusCode.NotFound)
                return;

            if (!respuesta.IsSuccessStatusCode)
                throw new Exception("No se pudo confirmar el restablecimiento. El código venció o ya fue usado.");
        }

        public LicenciaInfo ValidarToken(string token)
        {
            RSA rsa = CargarClavePublica();

            var parametros = new TokenValidationParameters
            {
                ValidateIssuer = false,
                ValidateAudience = false,
                ValidateLifetime = true,
                IssuerSigningKey = new RsaSecurityKey(rsa)
            };

            var handler = new JwtSecurityTokenHandler();
            handler.MapInboundClaims = false;

            ClaimsPrincipal principal = handler.ValidateToken(token, parametros, out SecurityToken validado);
            var jwt = (JwtSecurityToken)validado;

            return new LicenciaInfo
            {
                Email = principal.FindFirst("email")?.Value,
                Estado = principal.FindFirst("estado")?.Value,
                Vencimiento = jwt.ValidTo
            };
        }

        private static RSA CargarClavePublica()
        {
            var assembly = Assembly.GetExecutingAssembly();

            using (Stream stream = assembly.GetManifestResourceStream("service.clave-publica.txt"))
            using (StreamReader reader = new StreamReader(stream))
            {
                string[] lineas = reader.ReadToEnd().Split('\n');

                var parametros = new RSAParameters
                {
                    Modulus = Convert.FromBase64String(lineas[0].Trim()),
                    Exponent = Convert.FromBase64String(lineas[1].Trim())
                };

                RSA rsa = RSA.Create();
                rsa.ImportParameters(parametros);
                return rsa;
            }
        }

        public void GuardarToken(string token)
        {
            Directory.CreateDirectory(CarpetaDatos);   // no falla si ya existe
            File.WriteAllText(RutaToken, token);
        }
        public string LeerTokenGuardado()
        {
            if (!File.Exists(RutaToken))
                return null;
            return File.ReadAllText(RutaToken);
        }

        public enum EstadoLicencia
        {
            Renovada,   // la licencia es válida y se renovó el token
            SinConexion,    // no se pudo conectar al server para validar la licencia
            Invalida    // el server respondió que la licencia no es válida
        }

        public async Task<EstadoLicencia> RefrescarAsync()
        {
            string tokenGuardado = LeerTokenGuardado();
            if (tokenGuardado == null)
                return EstadoLicencia.Invalida;

            HttpRequestMessage pedido = new HttpRequestMessage(HttpMethod.Post, 
                $"{UrlBase}/estado");
            pedido.Headers.Authorization = new AuthenticationHeaderValue("Bearer", tokenGuardado);

            HttpResponseMessage respuesta;
            try
            {
                respuesta = await cliente.SendAsync(pedido);
            }
            catch (HttpRequestException)
            {
                return EstadoLicencia.SinConexion;
            }
            catch (TaskCanceledException)
            {
                return EstadoLicencia.SinConexion;
            }

            if(!respuesta.IsSuccessStatusCode)
                return EstadoLicencia.Invalida;

            RespuestaActivar resultado = await respuesta.Content.ReadFromJsonAsync<RespuestaActivar>();
            if (!string.IsNullOrWhiteSpace(resultado?.Token))
                GuardarToken(resultado.Token);
            return EstadoLicencia.Renovada;
        }
    }

    public class LicenciaInfo
    {
        public string Email { get; set; }
        public string Estado { get; set; }
        public DateTime Vencimiento { get; set; }
    }
}
