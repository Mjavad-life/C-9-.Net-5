using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEachWithExtensionMethods
{
    public class Car 
    {       

        // Car properties.
        public int CurrentSpeed { get; set; } = 0;
        public string PetName { get; set; } = "";
                
        // Constructors.
        public Car() { }

        public Car(string name, int speed)
        {
            CurrentSpeed = speed;
            PetName = name;
        }        
    }
}

        
    
  

