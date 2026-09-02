using System;
using System.Security.Cryptography;
using System.Text;

namespace service
{
    public static class Seguridad
    {
        private const int TamanioSalt = 16;
        private const int TamanioHash = 32;
        private const int Iteraciones = 100_000;

        public static string HashPassword(string password)
        {
            byte[] salt = new byte[TamanioSalt];

            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }

            byte[] hash;

            using (Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(password, salt, Iteraciones, HashAlgorithmName.SHA256))
            {
                hash = pbkdf2.GetBytes(TamanioHash);
            }

            return string.Format("pbkdf2${0}${1}${2}",
                Iteraciones,
                Convert.ToBase64String(salt),
                Convert.ToBase64String(hash));
        }

        public static bool VerificarPassword(string password, string almacenado)
        {
            if (string.IsNullOrEmpty(almacenado))
                return false;

            if (EsHashLegado(almacenado))
                return VerificarSha256Legado(password, almacenado);

            string[] partes = almacenado.Split('$');
            if (partes.Length != 4 || partes[0] != "pbkdf2")
                return false;

            int iteraciones;
            byte[] salt;
            byte[] hashEsperado;

            try
            {
                iteraciones = int.Parse(partes[1]);
                salt = Convert.FromBase64String(partes[2]);
                hashEsperado = Convert.FromBase64String(partes[3]);
            }
            catch (Exception)
            {
                return false;
            }

            if (iteraciones <= 0 || salt.Length == 0 || hashEsperado.Length == 0)
                return false;

            byte[] hashCalculado;

            using (Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(password, salt, iteraciones, HashAlgorithmName.SHA256))
            {
                hashCalculado = pbkdf2.GetBytes(hashEsperado.Length);
            }

            return ComparacionConstante(hashCalculado, hashEsperado);
        }

        public static bool EsHashLegado(string almacenado)
        {
            if (almacenado.Length != 64)
                return false;

            foreach (char c in almacenado)
            {
                if (!Uri.IsHexDigit(c))
                    return false;
            }

            return true;
        }

        private static bool VerificarSha256Legado(string password, string almacenado)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder stringBuilder = new StringBuilder(64);

                for (int i = 0; i < bytes.Length; i++)
                {
                    stringBuilder.Append(bytes[i].ToString("x2"));
                }

                return ComparacionConstante(stringBuilder.ToString(), almacenado);
            }
        }

        private static bool ComparacionConstante(byte[] a, byte[] b)
        {
            if (a.Length != b.Length)
                return false;

            int diferencia = 0;

            for (int i = 0; i < a.Length; i++)
            {
                diferencia |= a[i] ^ b[i];
            }

            return diferencia == 0;
        }

        private static bool ComparacionConstante(string a, string b)
        {
            if (a.Length != b.Length)
                return false;

            int diferencia = 0;

            for (int i = 0; i < a.Length; i++)
            {
                diferencia |= a[i] ^ b[i];
            }

            return diferencia == 0;
        }
    }
}
