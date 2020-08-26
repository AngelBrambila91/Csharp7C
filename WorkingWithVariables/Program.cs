using System;
using static System.Console;

namespace WorkingWithVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Literal Values and Char type
                // variable --- Literal  
             char letter = 'A';
             char digit = '1';
             char symbol = '%';
             //char something = GetFromFunction();
            #endregion

            #region Verbatim String
            string fullNameWithSeparator = "Adrian\tLlanos";
            /*
            \t
            \n
            \r
            \a
            \c
            \b
            */
            WriteLine(fullNameWithSeparator);
            string filePath = @"C:\television\tony\bravia.txt";
            WriteLine(filePath);    
            #endregion

        }
    }
}
