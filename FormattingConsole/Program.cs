using System;
using static System.Console;
namespace FormattingConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // ALL FROM OR INTO THE CONSOLE IS STRING

            #region Parameter Format || Positional Arguments
            int numberofTejuinos = 12;
            decimal priceperTejuino = 27.80M;

            WriteLine(
            format : "{0} tejuinos costs {1:C}",
            arg0: numberofTejuinos,
            arg1: priceperTejuino * numberofTejuinos);

            WriteLine("{0} tejuinos costs {1:C}",
            arg0: numberofTejuinos,
            arg1: priceperTejuino * numberofTejuinos);
            #endregion
            
            #region Formatting a string
                string formatted = string.Format(
                format: "{0} tejuinos costs {1:C}",
                arg0: numberofTejuinos,
                arg1: priceperTejuino * numberofTejuinos
            );
            WriteLine(formatted);    
            #endregion

            #region interpolated Format
                WriteLine($"{numberofTejuinos} tejuinitos costs {priceperTejuino * numberofTejuinos:C}");
            #endregion

            #region Indentation
                string tejuinos = "Tejuinos";
                int tejuinosCount = 3540;
                string tortaAhogada = "Lonche";
                int tortasCount = 6_000_000;
            #endregion

            // {index [, alignment] [:formatString]}
            WriteLine( // Headers
                format: "{0, -8} {1, 12:N0}",
                arg0: "Product",
                arg1: "Stock"
            );

            WriteLine(
                format: "{0, -8} {1, 12:N0}",
                arg0: tejuinos,
                arg1: tejuinosCount
            );

            WriteLine(
                format: "{0, -8} {1, 12:N0}",
                arg0: tortaAhogada,
                arg1: tortasCount
            );

            WriteLine($"{tejuinos, -8} {tortaAhogada, 12}");
            WriteLine($"{tejuinos, -8} {tejuinosCount, 12:N0}");
        }
    }
}
