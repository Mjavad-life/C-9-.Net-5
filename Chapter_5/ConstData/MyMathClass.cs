using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// کار با کانستنت ها
namespace ConstData
{
    class MyMathClass
    {
        public const double PI = 3.14;

        public readonly double PO_ReadOnly_Fafgat;

        public static readonly double PO_Static_readOnly = 3.11;

        public static readonly double PO_Statci_readOnly_bedon_meghdar;

        public MyMathClass()
        {
            PO_ReadOnly_Fafgat = 3.12;           
        }

        static MyMathClass()
        {
            PO_Statci_readOnly_bedon_meghdar = 3.15;
        }

        public void Met()
        {
            // کانستنت داخل متد قابل دسترسیه بدون آوردن
            // اسم کلاس

            Console.WriteLine(PI.ToString());
            const string str = "hol holo";
            Console.WriteLine(str);
        }
    }
}
