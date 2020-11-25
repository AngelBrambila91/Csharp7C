using System;
using static System.Console;
namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Arrays
            string [] names;
            names = new string[4];
            names [0] = "El que  siempre me culpa";
            names [1] = "Anita";
            names [2] = "Aran.Dano";
            names [3] = "Santiago";

            for (int i = 0; i < names.Length; i++)
            {
                WriteLine(names[i]);
            }    
            #endregion
            

            #region Working with Nulls
            int thiCannotBeNull = 4;
            //thiCannotBeNull = null;

            int? thisCouldBeNull = null;
            WriteLine(thisCouldBeNull);
            WriteLine(thisCouldBeNull.GetValueOrDefault());

            thisCouldBeNull = 11;
            WriteLine(thisCouldBeNull);
            WriteLine(thisCouldBeNull.GetValueOrDefault());
            #endregion
        }
    }
}
