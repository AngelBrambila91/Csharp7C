using System;
using static System.Console;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            #region While
                int x = 1;
                while ( x <= 10)
                {
                    WriteLine(x);
                    x++;
                }
            #endregion

            #region do While
            string password = string.Empty;
                do
                {
                    Write("Enter your password : ");
                    password = ReadLine();
                }while(password != "Pa$$w0rd");
                WriteLine("Login succesful");
            #endregion

            #region for
                for (int i = 0; i < 12; i++)
                {
                    WriteLine(i);
                }
            #endregion

            #region foreach
                string [] names = {"Lesiet", "FlyingPig", "El traidor AKA el que siempre me culpa AKA el que me banea mis jg's"};
                foreach (var item in names/*Current*/)
                {
                    WriteLine($"{item} has {item.Length} characters.");
                }/*Move Next*/
            #endregion
        }
    }
}
