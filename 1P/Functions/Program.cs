using System;
using static System.Console;

namespace Functions
{
    class Program
    {
        #region EZ Functions    
        // regime , modifers, return type, name , (parameters)
        /// <summary>
        /// This functions is used to get the Multiplication Table of a number
        /// Also don't call it with an instance , it's static ￣へ￣
        /// </summary>
        /// <param name="number">Its a byte so don't push over 255</param>
        static void TimesTable (byte number)
        {
            for (int row = 1; row < 10; row++)
            {
                WriteLine($"{row} x {number} = {row * number}");
            }
            WriteLine();
        }

        static void RunTimesTable()
        {
            bool isNumber;
            do
            {
                Write ("Enter a number between 0 and 255: ");
                isNumber = byte.TryParse(ReadLine(), out byte number);

                if(isNumber)
                {
                    TimesTable(number);
                }
                else
                {
                    WriteLine("That's not a number m8");
                }
            } while (isNumber);
        }
        // DRY
        // Don't Repeat Yourself
        // KISS
        // 
        #endregion
        
        #region Return
        static decimal returnSomething()
        {
            return 90.2M;
        }
        #endregion
        
        #region Factorial
            static int Factorial(int number)
            {
                if (number < 1)
                {
                    return 0;
                }
                else if(number == 1)
                {
                    return 1;
                }
                else
                {
                return number * Factorial (number - 1);
                }
            }
        #endregion
        static void Main(string[] args)
        {
            RunTimesTable();
            WriteLine(Factorial(5));
            char a = '$';
            int b = a;
            WriteLine($"{b:X}");
        }
    }
}
