using System;

namespace ConstData
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fun with Const");
            Console.WriteLine("Value of PI is {0}", MyMathClass.PI);

            //MyMathClass.PI = 3.65;

            //MyMathClass my = new MyMathClass();
            //my.Met();

            Console.WriteLine("po static read only {0}" , MyMathClass.PO_Static_readOnly.ToString());

            Console.WriteLine("PO static read only to sazandeh {0}" , MyMathClass.PO_Statci_readOnly_bedon_meghdar.ToString());

            MyMathClass me = new MyMathClass();

            Console.WriteLine(" PO read only faghat {0}",me.PO_ReadOnly_Fafgat.ToString());
        }
    }
}
