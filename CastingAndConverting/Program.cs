using System;
using static System.Console;
using static System.Convert;

namespace CastingAndConverting
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Casting
            int a = 10;
            double b = a; // Implicit casting
            WriteLine (b);

            double c = 11.3;
            //int d = c;// error cannot convert to int
            int d = (int)c; // Losing data
            WriteLine(d);

            long e = 10;
            int f = (int)e;
            WriteLine($"e is {e:N0} and f is {f:N0}");

            e = long.MaxValue;
            f = (int)e; // Overflow
            WriteLine($"e is {e:N0} and f is {f:N0}");

            e = 5_000_000_000;
            f = (int)e; // Conversion from 64 bit -> 32 Bits
            WriteLine($"e is {e:N0} and f is {f:N0}");
            #endregion

            #region Convert
                double g = 34.23;
                int h = ToInt32(g);
                WriteLine($"g is {g:N0} and h is {h:N0}");

                double[] doubles = new []
                {
                    9.49, 9.5, 9.51, 10.49, 10.5, 10.51 ,11.5, 12.5
                };

                foreach (var item in doubles)
                {
                    WriteLine($"To int ({item}) is {ToInt32(item)}");
                    WriteLine($"Math Round ({item}) is {Math.Round(item, MidpointRounding.AwayFromZero)}");
                }
            #endregion

            #region ToString
                int number = 12;
                WriteLine(number.ToString());

                DateTime now = DateTime.Now;
                WriteLine(now.ToString());
            #endregion

            #region Parse
                int age = int.Parse("29");
                DateTime birthday = DateTime.Parse("2 August 1991");
                //int fromUser = int.Parse("1A"); //Format Exception
            #endregion

            #region TryParse
                int count = 0;
                Write("How many pigs are there?");
                string input = ReadLine();
                if(int.TryParse(input, out count))
                {
                    WriteLine($"There are {count} pigs ... oink oink");
                }
                else
                {
                    WriteLine("I could not parse the input");
                }
            #endregion


        }
    }
}
