using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericPoint
{
    public struct Point<T>
    {

       private T _XPos;
       private T _YPos;
       
        public Point(T XVal,T YVal)
         {
            _XPos = XVal;
            _YPos = YVal;
         }

        // Generic properties.
        public T X
        {
            get => _XPos;
            set => _XPos = value;
        }

        public T Y
        {
            get => _YPos;
            set => _YPos = value;
        }

        public override string ToString() => $"[{_XPos}, {_YPos}]";

        // Reset fields to the default value of the type parameter.
        // The "default" keyword is overloaded in C#.
        // When used with generics, it represents the default
        // value of a type parameter.
        public void ResetPoint()
        {
           // _XPos = default(T);
           // _YPos = default(T);

            // using default literal expression
            _XPos = default;
            _YPos = default;
        }

        
    }
}
