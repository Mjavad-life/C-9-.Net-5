using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CustomEnumerator
{
    public class Garage : IEnumerable 
    {                
        // an array of cars as a private field
        private Car[] carArray = new Car[4];

        // Fill with some Car objects upon startup.
        public Garage()
        {                       
            carArray[0] = new Car("Rusty", 30);
            carArray[1] = new Car("Clunker", 55);
            carArray[2] = new Car("Zippy", 30);
            carArray[3] = new Car("Fred", 30);
        }

        public IEnumerator GetEnumerator()
        {
            return carArray.GetEnumerator();
        }

        // public IEnumerator GetEnumerator()
        // => carArray.GetEnumerator();
    }
}
