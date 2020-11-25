using System;
using static System.Console;
namespace HandlingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Managing Exceptions
                WriteLine("Yur age please");
                string input2 = ReadLine();
                int anotherAge = 0;

                try
                {
                anotherAge = int.Parse(input2);
                WriteLine($"Good to be {anotherAge} years old.");
                }
                catch (FormatException)
                {
                    WriteLine("I need you to type your age in number. I.E: 89");
                }
                catch (OverflowException)
                {
                    WriteLine("Yamete Kudazai");
                }
                catch (Exception ex)
                {
                    WriteLine($"{ex.GetType()} says {ex.Message}");
                }
            #endregion

            #region Checked

            try
            {
            checked
            {
                int x = int.MaxValue -1;
                WriteLine(x);
                x++;
                WriteLine($"After incrementing : {x:N0}");
                x++;
                WriteLine($"After incrementing : {x:N0}");
                x++;
                WriteLine($"After incrementing : {x:N0}");
            }
            }
            catch (OverflowException)
            {
                WriteLine("The code overflowed but i got your back BRUH o(*￣▽￣*)ブ");
            }
            #endregion
        }
    }
}
