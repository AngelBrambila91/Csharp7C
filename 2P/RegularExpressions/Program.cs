using System;
using System.Text.RegularExpressions;
using static System.Console;
namespace RegularExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Enter your age : ");
            string input = ReadLine();

            var ageChecker = new Regex(@"^\d+$");
            if(ageChecker.IsMatch(input))
            {
                WriteLine("Thank you!");
            }
            else
            {
                WriteLine($"Not a valid age : {input}");
            }

            string films = "\"Monsters, Inc.\", \"I, Tonya\", \"Lock, Stock and Two Smoking Barrels\"";
            string [] filmsDumb = films.Split(',');

            var csv = new Regex(
                "(?:^|,)(?=[^\"])|(\"?)\"?((?(1)[^\"]*|[^,\"]*))\"?(?=,|$)"
            );
            MatchCollection filmsSmart = csv.Matches(films);
            foreach (Match item in filmsSmart)
            {
                WriteLine(item.Groups[2].Value);
            }
        }
    }
}
