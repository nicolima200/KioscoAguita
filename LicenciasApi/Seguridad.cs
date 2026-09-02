using System.Security.Cryptography;

namespace LicenciasApi
{
    public static class Seguridad
    {
        private const int TamanioSalt = 16; 
        private const int TamanioHash = 32;
        private const int Iteraciones = 100_000;

        public static (string hash, string salt) HashearPassword(string password)
        {
            byte[] salt = RandomNumberGenerator.GetBytes(TamanioSalt);
            byte[] hash = Rfc2898DeriveBytes.Pbkdf2(
                password,
                salt,
                Iteraciones,
                HashAlgorithmName.SHA256,
                TamanioHash
            );

            return (Convert.ToBase64String(hash), Convert.ToBase64String(salt));
        }

        public static bool VerificarPassword(string password, string hashGuardado, string saltGuardado)
        {
            byte[] salt = Convert.FromBase64String(saltGuardado);
            byte[] hashCalculado = Rfc2898DeriveBytes.Pbkdf2(
                password,
                salt,
                Iteraciones,
                HashAlgorithmName.SHA256,
                TamanioHash
            );
            return CryptographicOperations.FixedTimeEquals(hashCalculado, Convert.FromBase64String(hashGuardado));
        }
    }
}
