using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordInheritance
{  
    // حذف شده positinal record types اینجا 
    // سه تا پراپرتی داره نه 4 تا positionalminivan
        public record PositionalCar(string Make , string Model , string Color);
        public record PositionalMiniVan(string Make, string Model, string Color)
            : PositionalCar(Make, Model, Color);

        
        
}
