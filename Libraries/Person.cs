using System;
using System.Collections.Generic;
namespace Libraries
{
    public class Person
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
    }
}