using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterfaces
{
    class Hexagon : Shape 
    {
        // constroctors
        public Hexagon() { }
        public Hexagon(string name) : base(name) { }

        // methods
        public override void Draw()
        {
            Console.WriteLine("drawing{0} the hexagon" , PetName); ;
        }
    }
}
