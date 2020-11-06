using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Xml.Linq;
using static System.Convert;

namespace CryptoLib
{
    public class User
    {
        public string Name { get; set; }
        public string Salt { get; set; }
        public string SaltedHashedPassword { get; set; }
    }
    public static class Protector
    {
        #region Theory
            
        /*
        Encryption and Decryption : Two-way process to convert data
        Hash : One-way process
        Signature : Technique to ensure data coemes fromes someone you trust.
        Authentication : Technique to identify someone by credentials.
        Authorization : Ensure to someones has permission to do something.
        Types of encryption : Symmetric and Asymmetric
        */
        #endregion

        #region Encrypt   
        // salt must be at least 8 bytes
        private static readonly byte[] salt = Encoding.Unicode.GetBytes("ElPepe");
        private static readonly int iterations = 2000;

        public static string Encypt (string plainText, string password)
        {
            byte [] encryptedBytes;
            byte [] plainBytes = Encoding.Unicode.GetBytes(plainText);
            var aes = Aes.Create();
            var assistant = new Rfc2898DeriveBytes(password, salt, iterations);
            aes.Key = assistant.GetBytes(32); // set a 256 bit key
            aes.IV = assistant.GetBytes(16); // set a 128 bit IV

            using (var ms = new MemoryStream())
            {
                using (var cs = new CryptoStream (ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    cs.Write(plainBytes, 0, plainBytes.Length);
                }
                encryptedBytes = ms.ToArray();
            }

            return Convert.ToBase64String(encryptedBytes);
        }
        #endregion

        #region Decrypt
        public static string Decrypt ( string cryptoText, string password)
        {
            byte [] plainBytes;
            byte [] cryptoBytes = Convert.FromBase64String(cryptoText);
            var aes = Aes.Create();
            var assistant = new Rfc2898DeriveBytes(password,salt, iterations);
            aes.Key = assistant.GetBytes(32); // set a 256 bit key
            aes.IV = assistant.GetBytes(16); // set a 128 bit IV

             using (var ms = new MemoryStream())
            {
                using (var cs = new CryptoStream (ms, aes.CreateDecryptor(), CryptoStreamMode.Write))
                {
                    cs.Write(cryptoBytes, 0,cryptoBytes.Length);
                }
                plainBytes = ms.ToArray();
            }
            return Encoding.Unicode.GetString(plainBytes);
        }
        #endregion

        private static Dictionary<string, User> Users = new Dictionary<string, User>();

        public static User Register(string username, string password)
        {
            // generate random salt
            var rng = RandomNumberGenerator.Create();
            var saltBytes = new byte [16];
            rng.GetBytes(saltBytes);
            var saltText = Convert.ToBase64String(saltBytes);

            // generate salted password
            var saltedhashedPassword = SaltAndHashPassword(password, saltText);

            var user = new User 
            {
                Name = username,
                Salt = saltText,
                SaltedHashedPassword = saltedhashedPassword
            };
            Users.Add(user.Name, user);
            return user;
        }

        public static bool CheckPassword(string username, string password)
        {
            if(!Users.ContainsKey(username))
            {
                return false;
            }
            var user = Users[username];
            // re-generate the same salted and same hashed password
            var saltedhashedPassword = SaltAndHashPassword(password, user.Salt);
            return (saltedhashedPassword == user.SaltedHashedPassword);
        }

        private static string SaltAndHashPassword(string password, string saltText)
        {
            var sha = SHA256.Create();
            var saltedPassword = password + salt;
            return Convert.ToBase64String(sha.ComputeHash(Encoding.Unicode.GetBytes(saltedPassword)));
        }
    }
}
