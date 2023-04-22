using System;
using System.Security.Cryptography;
using System.Text;

namespace Extensions.Cryptography
{
    public static class StringCryptographyExtensions
    {
        public static string ToSha256(this string value)
        {
            byte[] inputBytes = Encoding.UTF8.GetBytes(value);

            using (var sha256 = SHA256.Create())
            {
                byte[] hashBytes = sha256.ComputeHash(inputBytes);
                string hashString = BitConverter.ToString(hashBytes).Replace("-", "");

                return hashString;
            }
        }

        public static string ToMD5(this string value)
        {
            byte[] inputBytes = Encoding.UTF8.GetBytes(value);

            using (var md5 = MD5.Create())
            {
                byte[] hashBytes = md5.ComputeHash(inputBytes);
                string hashString = BitConverter.ToString(hashBytes).Replace("-", "");

                return hashString;
            }
        }
    }

    
}
