using System;
using static System.Console;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Object
            object height = 1.88;
            object name = "Oscar";

            WriteLine($"{name} is {height} meters tall");
            string a = "Ana";
            int length1 = a.Length;
            //int length2 = height.Length;// object no hereda propiedades, solo es para guardar info
            int length2 = ((string)name).Length;
            WriteLine(length2);    
            #endregion
            
            #region dynamic
            dynamic anotherName = "AranDano";
            int length3 = anotherName.Length;// Throws an exception, Run- Time 
            WriteLine(length3);
            #endregion

            #region Var
                var population = 66_000_000;
                var LastName = 'B';
                WriteLine(population.GetType());
                WriteLine(LastName.GetType());
            #endregion
            
            #region DefaultValues
                WriteLine($"default(int) = {default(int)}");
                WriteLine($"default(bool) = {default(bool)}");
                WriteLine($"default(char) = {default(char)}");
                WriteLine($"default(DateTime) = {default(DateTime)}");
                WriteLine($"default(string) = {default(string)}");
            #endregion
        }
    }
}
