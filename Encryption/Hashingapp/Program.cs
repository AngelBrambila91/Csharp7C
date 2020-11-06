using System;
using static System.Console;
using CryptoLib;

namespace Hashingapp
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Registering Teisel UwU with Pa$$w0rd");
            var teisel = Protector.Register("Teisel", "Pa$$w0rd");
            WriteLine($"Name {teisel.Name}");
            WriteLine($"Salt : {teisel.Salt}");
            WriteLine($"Password (Salted and hashed) :  {teisel.SaltedHashedPassword}");

            Write ("Enter a new user to register : ");
            string username = ReadLine();
            Write ($"Enter password for {username}");
            string password = ReadLine();
            var user = Protector.Register(username, password);
            WriteLine($"Name {user.Name}");
            WriteLine($"Salt : {user.Salt}");
            WriteLine($"Password (Salted and hashed) :  {user.SaltedHashedPassword}");

            WriteLine();

            bool correctPassword = false;
            while (!correctPassword)
            {
                Write("Enter a username to log in");
                string loginUsername = ReadLine();
                Write("Enter a password to log in");
                string loginPassword = ReadLine();

                correctPassword = Protector.CheckPassword(loginUsername, loginPassword);

                    if(correctPassword)
                    {
                        WriteLine($"Welcome back! {loginUsername} has been logged in");
                    }
                    else
                    {
                        WriteLine("Invalid username or password");
                    }
            }

        }
    }
}
