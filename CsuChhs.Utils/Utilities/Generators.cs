﻿namespace CsuChhs.Utils.Utilities
{
    public static class Generators
    {
        /// <summary>
        /// Generates a random string of alpha chars
        /// up to the specified length.
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        public static string RandomString(int length = 10)
        {
            return _GenerateRandomString(length);
        }

        /// <summary>
        /// Generates a URL Safe Token that can be included in
        /// a URL string.
        /// </summary>
        /// <returns></returns>
        public static string NewUrlSafeToken()
        {
            return CleanToken(_GenerateToken());
        }

        private static string _GenerateToken()
        {
            return Convert.ToBase64String(Guid.NewGuid().ToByteArray());
        }

        private static string CleanToken(string token)
        {
            return token.Replace("+", "-")
                .Replace("/", "_")
                .Replace("=", "");
        }

        private static string _GenerateRandomString(int length)
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
