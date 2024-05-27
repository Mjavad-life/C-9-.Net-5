using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClassExample
{
    class Motorcycle
    {
        public int driverIntensity;

        // New members to represent the name of the driver.
        //رو نشون بده this اینجا میخواد کاربرد 
        public string name;
        public void SetDriverName(string name) => name = name;

        public void PopAWheely()
        {
            Console.WriteLine("Yeeeeeee Haaaaaeewww!");
        }

        // Put back the default constructor, which will
        // set all data members to default values.
        public Motorcycle() { }

        // Our custom constructor.
        public Motorcycle(int intensity)
        {
            driverIntensity = intensity;
        }
        
    }
}
