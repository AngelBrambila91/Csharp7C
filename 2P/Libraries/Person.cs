using System;
using System.Collections.Generic;
namespace Libraries
{
    public partial class Person : IComparable<Person>
    {
        /*
        Fields
            Constant
            Read-Only
            Event
        */

        public string Name;
        public DateTime DateOfBirth;
        // internal
        // internal protected
        // private protected
        public PlacesToVisit placesToVisit;
        public List<Person> Children = new List<Person>();
        public const string Species = "Homo Sapiens";
        public readonly string HomePlanet = "Earth";
        public readonly DateTime Instantiated;
        /*
        Methods
            Constructor
            Property
            Indexer
            Operator
        */
        public Person()
        {
            Name = "Unknown";
            Instantiated = DateTime.Now;
        }

        public Person(string initialName , string homePlanet)
        {
            Name = initialName;
            HomePlanet = homePlanet;
            Instantiated = DateTime.Now;
        }

        public (string Name , int Number) GetNameFruit()
        {
            return (Name : "Apples", Number : 5);
        }

        public void PassingParameters (int x , ref int y , out int z)
        {
            // out parameters cannot have a default
            // AND must be initialized inside the method
            z = 10;
            x++;
            y++;
            z++;
        }
        //Override
        public int CompareTo(Person other)
        {
            return Name.CompareTo(other.Name);
        }
    }
}