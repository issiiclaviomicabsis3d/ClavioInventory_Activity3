using System;
using System.Security.Cryptography;

namespace claviomica_InventoryMS
{
    internal static class PasswordHelper
    {
        private const int SaltSize = 16;
        private const int HashSize = 32;
        private const int IterationCount = 100_000;
        private const string Format = "PBKDF2-SHA256";

        public static string HashPassword(string password)
        {
            ArgumentException.ThrowIfNullOrWhiteSpace(password);

            byte[] salt = RandomNumberGenerator.GetBytes(SaltSize);
            byte[] hash = Rfc2898DeriveBytes.Pbkdf2(
                password,
                salt,
                IterationCount,
                HashAlgorithmName.SHA256,
                HashSize);

            return string.Join(
                '$',
                Format,
                IterationCount,
                Convert.ToBase64String(salt),
                Convert.ToBase64String(hash));
        }

        public static bool VerifyPassword(string password, string passwordHash)
        {
            if (string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(passwordHash))
            {
                return false;
            }

            string[] parts = passwordHash.Split('$');
            if (parts.Length != 4 ||
                !parts[0].Equals(Format, StringComparison.Ordinal) ||
                !int.TryParse(parts[1], out int iterations) ||
                iterations <= 0)
            {
                return false;
            }

            try
            {
                byte[] salt = Convert.FromBase64String(parts[2]);
                byte[] expectedHash = Convert.FromBase64String(parts[3]);
                byte[] actualHash = Rfc2898DeriveBytes.Pbkdf2(
                    password,
                    salt,
                    iterations,
                    HashAlgorithmName.SHA256,
                    expectedHash.Length);

                return CryptographicOperations.FixedTimeEquals(actualHash, expectedHash);
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}
