using System;
using Libraries;
using static System.Console;
namespace PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount.InterestRate = 0.012M;
            #region Elena Instance
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
            WriteLine($"{elena.Name} is a {Person.Species} and was born on {elena.HomePlanet}");
            #endregion
            
            #region Oscar Instance
            var oscar = new Person
            {
                Name = "Oscar Macias",
                DateOfBirth = new DateTime(2000, 10, 2)
            };

            oscar.Children.Add(new Person { Name = "OscarJr" });
            WriteLine($"{oscar.Name} was born on {oscar.DateOfBirth:dddd, MMMM d yyyy}");
            #endregion
            
            #region Using BankAccount
                var adrianAccount = new BankAccount();
            adrianAccount.AccountName = "El traidor";
            adrianAccount.Balance = 2500;

            WriteLine($"{adrianAccount.AccountName} earned {adrianAccount.Balance * BankAccount.InterestRate:C}");
            #endregion
            
            #region Using Constructor
                var blankPerson = new Person();
                WriteLine($"{blankPerson.Name} of {blankPerson.HomePlanet} was created at {blankPerson.Instantiated:hh:mm:ss} on {blankPerson.Instantiated:dddd}");

                var ricardo = new Person("Ricardo", "Mars");
                WriteLine($"{ricardo.Name} of {ricardo.HomePlanet} was created at {blankPerson.Instantiated:hh:mm:ss} on {ricardo.Instantiated:dddd}");

                var defaultGuy = new DefaultThings();
                WriteLine($"{defaultGuy.Name} , {defaultGuy.People}, {defaultGuy.Population}, {defaultGuy.When}");
            #endregion
        }
    }
}
