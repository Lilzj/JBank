using System;
using System.Collections.Generic;
using System.Text;

namespace JBank.Lib.Common
{
    public class Utilities
    {
        public static string GenerateNumber()
        {
            Random random = new Random();
            string r = "";
            int i;
            for (i = 1; i < 5; i++)
            {
                r += random.Next(0, 9).ToString();
            }
            return "0987" + r;
        }

        public static string SanitizeName(string name)
        {
            string cleanname = name;
            if (Char.IsDigit(name[0]))
            {
                cleanname = cleanname.Substring(1);
            }
            if (!Char.IsUpper(cleanname[0]))
            {
                cleanname = Char.ToUpper(cleanname[0]) + cleanname.Substring(1);
            }

            return cleanname;
        }
        public static bool ValidateEmail(string email)
        {

            System.Text.RegularExpressions.Regex emailRegex = new System.Text.RegularExpressions.Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            System.Text.RegularExpressions.Match emailMatch = emailRegex.Match(email);
            return emailMatch.Success;
        }
        public static List<byte[]> GenerateHash(string password)
        {
            byte[] passwordSalt, passwordHash;

            // convert password to hash value and generate salt
            using (var hash = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hash.Key;
                passwordHash = hash.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }

            var result = new List<byte[]>();
            result.Add(passwordHash);
            result.Add(passwordSalt);

            return result;
        }
        public static bool CompareHash(byte[] passwordSalt, byte[] passwordHash, string password)
        {
            using (var hash = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                var hashGenerated = hash.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < hashGenerated.Length; i++)
                {
                    if (hashGenerated[i] != passwordHash[i])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
