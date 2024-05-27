using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneablePoint
{
    public class Point : ICloneable
    {
        public int X { get; set; }
        public int Y { get; set; }

        public PointDescription desc = new PointDescription();

        public Point(int xPos, int yPos, string petName)
        {
            X = xPos; Y = yPos;
            desc.PetName = petName;
        }

        public Point(int xPos, int yPos) { X = xPos; Y = yPos; }
        
        public Point() { }

        // Override Object.ToString().
        public override string ToString() => $"X = {X}; Y = {Y}; Name = {desc.PetName};\nID = {desc.PointID}\n";

        // Return a copy of the current object.
        //public object Clone() => new Point(this.X, this.Y);

        //public object Clone() => this.MemberwiseClone();

        public object Clone()
        {
            // First get a shallow copy.
            Point newPoint = (Point)this.MemberwiseClone();

            // Then fill in the gaps.
            PointDescription currentDesc = new PointDescription();
            
            currentDesc.PetName = this.desc.PetName;

            // i added below line to test
            currentDesc.PointID = this.desc.PointID;
            
            // new ponit is a Point type
            newPoint.desc = currentDesc;
            
            return newPoint;
        }
    }
}
