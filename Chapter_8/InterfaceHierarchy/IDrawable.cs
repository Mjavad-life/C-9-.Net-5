using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceHierarchy
{
    interface IDrawable
    {
        void Draw();

        // it has default implementation
        int TimeToDraw() => 5;
    }
}
