using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithObservableCollections
{

    // person is imported from another project
    // and now is a member this namespace
    class Person
    {
        // properties
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // constructors
        public Person() { }

        public Person(string firstName, string lastName, int age)
        {
            Age = age;
            FirstName = firstName;
            LastName = lastName;
        }

        // methods
        public override string ToString()
        {
            return $"Name: {FirstName} {LastName}, Age: {Age}";
        }
    }
}
