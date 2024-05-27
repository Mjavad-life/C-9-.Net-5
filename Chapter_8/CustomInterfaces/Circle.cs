using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterfaces
{
    class Circle : Shape
    {
        public Circle() { }
        public Circle(string name) : base(name) { }

        // methods
        public override void Draw()
        {
            try
            {
                Console.WriteLine("drwaing {0} the circle",PetName);
            }
            catch (Exception)
            {
                throw new NotImplementedException();
            }
            
        }
    }
}
