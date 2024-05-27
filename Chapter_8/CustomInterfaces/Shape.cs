using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterfaces
{
   abstract class Shape
    {
        protected Shape(string name ="NoName")
        {
            PetName = name;
        }

        public string PetName { get; set; }

        // method

        //a single virtual method
        // make it to abstract with no implementation
        public abstract void Draw();
        
            
        
    }
}
