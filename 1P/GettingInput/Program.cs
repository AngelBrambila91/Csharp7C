using System;
using static System.Console;
namespace GettingInput
{
    class Program
    {
        static void Main(string[] args)
        {
            #region getting Input
            Write("Type your first name and press Enter: ");
            string firstName = ReadLine();

            Write("Type your age and press Enter: ");
            string age = ReadLine();

            WriteLine($"Hello {firstName}, looking good for {age}.");    
            #endregion
            

            #region getting key
                Write("Press any key combination: ");
                ConsoleKeyInfo key = ReadKey(); // i can change to var
                WriteLine(" Key : {0} , Char : {1}, Modifiers {2}",
                arg0: key.Key,
                arg1: key.KeyChar,
                arg2: key.Modifiers);
            #endregion

            #region gettingArguments
                // WriteLine($"There are {args.Length} arguments");
                // int arg1 = Convert.ToInt32(args[0]);
                // WriteLine($"First arg is : {arg1}");
            #endregion

            #region changing Color Console
            if(args.Length < 4)
            {
                WriteLine("You must specify two colors and dimensions, Example : dotnet run red yellow 80 40");
            }
            ForegroundColor = (ConsoleColor)Enum.Parse(
                enumType: typeof(ConsoleColor),
                value:args[0],
                ignoreCase: true
            );

            BackgroundColor = (ConsoleColor)Enum.Parse(
                enumType: typeof(ConsoleColor),
                value:args[1],
                ignoreCase: true
            );

            WindowWidth = int.Parse(args[2]);
            WindowHeight = int.Parse(args[3]);
            #endregion
        }
    }
}
