using System;
using static System.Console;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Numbers
            // unsigned int means positive whole number
            // including 0
            uint naturalNumber = 23;

            // integer means positive and negative
            // including 0
            int integerNumber = -100;

            // float is a single precision floating point
            float realNumber = 2.3F;    

            // double is a double precision floating point
            double anotherReal = 2.3;
            #endregion
            
            #region Binary an Hexadecimal
            int decimalNotation = 2_000_000;
            int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
            int hexadecimalNotation = 0x_001E_8480;
            WriteLine($"{decimalNotation == binaryNotation}");
            WriteLine($"{decimalNotation == hexadecimalNotation}");    
            #endregion

            #region NumberSizes
                // WriteLine($"int uses {sizeof(int)} bytes and can store from {int.MinValue:N0} to {int.MaxValue:N0}");
                // WriteLine($"double uses {sizeof(double)} bytes and can store from {double.MinValue:N0} to {double.MaxValue:N0}");
                // WriteLine($"decimal uses {sizeof(decimal)} bytes and can store from {decimal.MinValue:N0} to {decimal.MaxValue:N0}");
                // WriteLine($"float uses {sizeof(float)} bytes and can store from {float.MinValue:N0} to {float.MaxValue:N0}");
            #endregion

            #region double and decimal
                 double a = 0.1;
                 double b = 0.2;
                 decimal c = 0.1M;
                 decimal d = 0.2M;

                 if(a + b == 0.3)
                 {
                   WriteLine($"{a} +  {b} equals {a + b}");
                 }
                 else
                 {
                     WriteLine($"{a} +  {b} DOES NOT equals {a + b}");
                 }

                 if(c + d == 0.3M)
                 {
                   WriteLine($"{c} +  {d} equals {c + d}");
                 }
                 else
                 {
                     WriteLine($"{c} +  {d} DOES NOT equals {c + d}");
                 }
            #endregion

            #region Boleanos
                bool happy = true;
                bool sad = false;
            #endregion
        }
    }
}
