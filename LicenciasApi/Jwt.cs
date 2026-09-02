using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using Microsoft.IdentityModel.Tokens;

namespace LicenciasApi;

public static class Jwt
{
    private const string RutaClavePrivada = "clave-privada.pem";
    private const string RutaClavePublica = "clave-publica.txt";
    private static readonly TimeSpan DuracionToken = TimeSpan.FromDays(10);
    public static void AsegurarClaves()
        {
            if (!File.Exists(RutaClavePrivada))
            {
                using RSA rsaNueva = RSA.Create(2048);
                File.WriteAllText(RutaClavePrivada, rsaNueva.ExportRSAPrivateKeyPem());

                RSAParameters clavePublica = rsaNueva.ExportParameters(includePrivateParameters: false);
                File.WriteAllLines(RutaClavePublica, new[]
                {
                    Convert.ToBase64String(clavePublica.Modulus!),
                    Convert.ToBase64String(clavePublica.Exponent!)
                });
            }
        }

    public static string GenerarToken(string email, string estado, DateTime vencimiento)
    {
        DateTime expiracion = DateTime.UtcNow.Add(DuracionToken);

        if (vencimiento < expiracion)
            expiracion = vencimiento;

        using var rsa = RSA.Create();
        rsa.ImportFromPem(File.ReadAllText(RutaClavePrivada));

        var credenciales = new SigningCredentials(new RsaSecurityKey(rsa), SecurityAlgorithms.RsaSha256)
        {
            CryptoProviderFactory = new CryptoProviderFactory { CacheSignatureProviders = false }
        };

        var claims = new[]
        {
            new Claim("email", email),
            new Claim("estado", estado)
        };

        var token = new JwtSecurityToken(claims: claims, expires: expiracion, signingCredentials: credenciales);

        return new JwtSecurityTokenHandler().WriteToken(token);
    }

    public static string ObtenerEmailDeToken(string token)
    {
        using var rsa = RSA.Create();
        rsa.ImportFromPem(File.ReadAllText(RutaClavePrivada));

        var clave = new RsaSecurityKey(rsa)
        {
            CryptoProviderFactory = new CryptoProviderFactory { CacheSignatureProviders = false }
        };

        var parametros = new TokenValidationParameters
        {
            ValidateIssuer = false,
            ValidateAudience = false,
            ValidateLifetime = false,
            IssuerSigningKey = clave
        };

        var handler = new JwtSecurityTokenHandler();
        handler.MapInboundClaims = false;

        var principal = handler.ValidateToken(token, parametros, out _);
        return principal.FindFirst("email")?.Value;
    }
}