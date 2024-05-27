using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithCustomGenericMethods
{
   static class SwapFunctions
    {
       public static void Swap<T>(ref T a , ref T b)
        {
            Console.WriteLine("type of T :{0}", typeof(T));
            T temp = a;
            a = b;
            b = temp;
        }
    }
}
