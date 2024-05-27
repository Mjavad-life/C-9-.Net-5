using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOverrides
{
    class Person : Object
    {
        

        // 2 kind of constructors
        public Person(string fName, string lName, int personAge, string SSN)
        {
            FirstName = fName;
            LastName = lName;
            Age = personAge;
            Ssn = SSN;
        }

        public Person() { }

        // properties
        // ssn is read only
        public string Ssn { get; } = "";
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        // methods
        // over rides the instance methods of
        // system.object parent class
        public override string ToString() =>
            $"[FirstName: {FirstName}, Last Name:{LastName}, Age: {Age}]";

        public override bool Equals(object person)
        {
            // used Tostring() method for comparsion
            // instead of property by property
            if (person.ToString() == this.ToString())
            {
                return true;
            }

            return false;
        }

        // => sign means it returns a value
        public override int GetHashCode() =>
            ToString().GetHashCode();
        



    }
}
