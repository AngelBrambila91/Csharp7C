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

            #region Using tuple Method
                (string , int) fruit = oscar.GetNameFruit();
                WriteLine($"{fruit.Item1}, {fruit.Item2} eats");

                var elenaFruit = elena.GetNameFruit();
                WriteLine($"{elenaFruit.Name}, {elenaFruit.Number} eats");

                WriteLine(elena.SayHello());
                WriteLine(oscar.Greeting());
            #endregion

            #region Ref and Out
                int a = 10;
                int b = 20;
                int c = 30;
                WriteLine($"Before : a = {a}, b = {b}, c = {c}");
                elena.PassingParameters(a, ref b, out c);
                WriteLine($"After : a = {a}, b = {b}, c = {c}");
            #endregion

            #region using Properties
                var adr = new Person
                {
                    Name = "El traidor",
                    DateOfBirth = new DateTime(2001, 11, 12)
                };
                WriteLine(adr.Greeting());
                WriteLine(adr.Age);
                adr.FavoriteIceCream = "Chocolate";
                WriteLine(adr.FavoriteIceCream);
                adr.FavoriteColor = "RED";
                WriteLine($"Adr favorite color is {adr.FavoriteColor}");
            #endregion

            #region Using index
                WriteLine($"Elena's first born is {elena.Children[0].Name}");
            #endregion

            #region Making ana angry (Using delegates)
                // Person ana = new Person();
                // ana.Shout = Ana_Shout;
                // ana.Shout += Elena_Shout;
                // ana.Shout += Adrian_Shout;

                // ana.Poke();
                // ana.Poke();
                // ana.Poke();
                // ana.Poke();
            #endregion

            #region Using ComparableInterface
                Person [] people =
                {
                new Person { Name = "Ana" },
                new Person { Name = "Tiesel" },
                new Person { Name = "Kaleb"},
                new Person { Name = "Ricardo" }
                };

                WriteLine("List of people: ");
                foreach (var person in people)
                {
                    WriteLine(person.Name);
                }

                WriteLine("Using IComparable sort to sort people");
                Array.Sort(people);
                foreach (var person in people)
                {
                    WriteLine(person.Name);
                }

                WriteLine("Using IComparer sort to sort people");
                Array.Sort(people, new PersonComprarer());
                foreach (var person in people)
                {
                    WriteLine(person.Name);
                }
            #endregion
        }

        private static void Ana_Shout(object sender, EventArgs e)
        {
            Person ana = (Person)sender;
            WriteLine($"{ana.Name} is this angry : {ana.AngerLevel}");
        }

        private static void Adrian_Shout(object sender, EventArgs e)
        {
            Person ana = (Person)sender;
            WriteLine($"{ana.Name} is this angry : {ana.AngerLevel}");
        }

        //Interfaces
        /*
        IComparable
        IComparer
        IDisposable
        IFormattable
        IFormatter
        IFormatProvider
        IEnumerator
        */

        private static void Elena_Shout(object sender, EventArgs e)
        {
            Person ana = (Person)sender;
            WriteLine($"{ana.Name} is this angry : {ana.AngerLevel}");
        }
    }
}
