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
            Timeout = TimeSpan.FromSeconds(8)
        };
        private static readonly string CarpetaDatos =
    Path.Combine(
        Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
        "KioscoAguita");
        private static readonly string RutaToken = Path.Combine(CarpetaDatos, "licencia.token");

        public async Task<string> ActivarAsync(string email, string password)
        {
            HttpResponseMessage respuesta = await cliente.PostAsJsonAsync(
                $"{UrlBase}/activar",
                new { email, password });

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