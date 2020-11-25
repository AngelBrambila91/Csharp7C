using System;
using static System.Console;
using CryptoLib;

namespace CryptoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Enter a message to encrypt : ");
            string message = ReadLine();
            Write("Enter a password : ");
            string password = ReadLine();

            string cryptoText = Protector.Encypt(message, password);

            WriteLine($"Encrypted text : {cryptoText}");
            Write("Enter a password : ");
            string password2 = ReadLine();

            try
            {
                string clearText = Protector.Decrypt(cryptoText, password2);
                WriteLine($"Decrypted text {clearText}");
            }
            catch (Exception ex)
            {
                WriteLine("Something went wrong");
            }
        }
    }
}
