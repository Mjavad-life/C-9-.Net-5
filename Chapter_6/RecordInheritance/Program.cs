using System;

namespace RecordInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            PositionalCar pc = new PositionalCar("honda", "corvet", "blue");
            PositionalMiniVan pm = new PositionalMiniVan("honde", "corvet", "blue");
            
            Console.WriteLine($"pvan is pcar:{pm is PositionalCar}");
            

        }
    }
}
