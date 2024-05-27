using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadedOps
{
    public struct Point
    {

       private int _XPos;
       private int _YPos;
       
        public Point(int XVal, int YVal)
         {
            _XPos = XVal;
            _YPos = YVal;
         }

        // Generic properties.
        public int X
        {
            get => _XPos;
            set => _XPos = value;
        }

        public int Y
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

        // Overloaded operator +.
        public static Point operator +(Point p1, Point p2)
        => new Point(p1.X + p2.X, p1.Y + p2.Y);
        
        // Overloaded operator -.
        public static Point operator -(Point p1, Point p2)
        => new Point(p1.X - p2.X, p1.Y - p2.Y);


    }
}
