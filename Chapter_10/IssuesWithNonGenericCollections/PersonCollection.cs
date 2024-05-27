using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssuesWithNonGenericCollections
{
    class PersonCollection : IEnumerable
    {
        // no constroctor

        private ArrayList arPeople = new ArrayList();
        
        // Cast for caller.
        // getperson returns a person type object
        public Person GetPerson(int pos) => (Person)arPeople[pos];
        
        // Insert only Person objects.
        public void AddPerson(Person p)
        {
            arPeople.Add(p);
        }
        
        public void ClearPeople()
        {
            arPeople.Clear();
        }

        public int Count => arPeople.Count;
        
        // Foreach enumeration support.
         IEnumerator IEnumerable.GetEnumerator() => arPeople.GetEnumerator();

        
    }
}
