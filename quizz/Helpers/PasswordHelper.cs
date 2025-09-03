using System.Security.Cryptography;
using System.Collections.Generic;
using quizz.Models;

namespace quizz.Helpers
{



    public static class PasswordHelper
    {
        public static void CreateHash(string password, out byte[] salt, out byte[] hash)
        {
            using (var rng = RandomNumberGenerator.Create())
            {
                salt = new byte[16];
                rng.GetBytes(salt);
            }
            using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 100000, HashAlgorithmName.SHA256))
            {
                hash = pbkdf2.GetBytes(32);
            }
        }

        private static bool FixedTimeEquals(byte[] a, byte[] b)
        {
            if (a.Length != b.Length)
                return false;

            int diff = 0;
            for (int i = 0; i < a.Length; i++)
            {
                diff |= a[i] ^ b[i]; // XOR vergelijken
            }
            return diff == 0;
        }


        public static bool VerifyPassword(string password, byte[] salt, byte[] expectedHash)
        {
            using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 100000, HashAlgorithmName.SHA256))
            {
                var hash = pbkdf2.GetBytes(32);
                return FixedTimeEquals(hash, expectedHash); // ← gebruik je eigen methode
            }
        }

    }
}
