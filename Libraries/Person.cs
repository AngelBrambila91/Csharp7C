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
        /*
        Methods
            Constructor
            Property
            Indexer
            Operator
        */
    }
}