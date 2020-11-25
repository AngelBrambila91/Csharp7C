using System.Collections.Generic;

namespace Libraries
{
    public class PersonComprarer : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            // compare the name Lenghts
            int result = x.Name.Length.CompareTo(y.Name.Length);
            // If 0 ... they're equal
            if(result == 0)
            {
                return x.Name.CompareTo(y.Name);
            }
            else
            {
                return result;
            }
        }
    }
}