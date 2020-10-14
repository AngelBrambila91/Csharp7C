using System;
using System.Numerics;
using static System.Console;
namespace WorkingWithNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Working With Big Numbers
            var largest = ulong.MaxValue;
            WriteLine($"{largest,40:N0}");
            var atomsInTheUniverse = BigInteger.Parse("123456789012345678901234567890");
            WriteLine($"{atomsInTheUniverse,40:N0}");
            #endregion

            #region Working with Text
                string city = "London";
                WriteLine($"{city} is {city.Length} characters long.");
                WriteLine($"First char is {city[0]} and last one is {city[4]}");
                string cities = "Paris, Berlin, Japan, Madrid, New York";
                string [] citiesArray = cities.Split(',');
                foreach (string item in citiesArray)
                {
                    WriteLine(item);
                }

                string fullName = "Alan Murillo";
                int indexOfTheSpace = fullName.IndexOf(' ');
                string firstName = fullName.Substring(startIndex: 0, length:indexOfTheSpace);
                string lastName = fullName.Substring(startIndex: indexOfTheSpace + 1);

                WriteLine($"{lastName}, {firstName}");

            #endregion

            #region Checking a string for content\
                string company = "PiteroSoft";
                bool startsWithP = company.StartsWith("P");
                bool containsS = company.Contains("teroS");
                WriteLine($"Starts with P? {startsWithP}, containsS ? {containsS}");
            #endregion
        }
    }
}
