using System;
using Libraries;
using static System.Console;
namespace PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var elena = new Person();
            elena.Name = "Elena Ponce";
            elena.DateOfBirth = new DateTime(2001, 3, 15);
            WriteLine($"{elena.Name} was born on {elena.DateOfBirth:dddd, MMMM d yyyy}");
            elena.placesToVisit = PlacesToVisit.Budapest;
            elena.Children.Add(new Person { Name = "Dante" });
            elena.Children.Add(new Person { Name = "Zoe" });

            for (int children = 0; children < elena.Children.Count; children++)
            {
                WriteLine($"{elena.Children[children].Name}");
            }

            var oscar = new Person
            {
                Name = "Oscar Macias",
                DateOfBirth = new DateTime(2000, 10, 2)
            };

            oscar.Children.Add(new Person { Name = "OscarJr" });
            WriteLine($"{oscar.Name} was born on {oscar.DateOfBirth:dddd, MMMM d yyyy}");
        }
    }
}
