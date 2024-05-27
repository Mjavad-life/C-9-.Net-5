using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectInitializers
{
    //class ReadOnlyPointAfterCreation
    //{
        class PointReadOnlyAfterCreation
        {
            // تغییر دادم set رو به init 
            public int X { get; set; }
            public int Y { get; set; }

            // یه پراپرتی از نوع اینوم گذاشت اینجا
            public PointColorEnum Color { get; set; }

            // تابعی که برای نشان دادن وضعیته
            public void DisplayStats()
            {
                Console.WriteLine("InitOnlySetter: [{0}, {1}]", X, Y);
                Console.WriteLine("Color is :{0}",Color);
            }

            // سازنده اول
            public PointReadOnlyAfterCreation(int xVal, int yVal)
            {
                X = xVal;
                Y = yVal;
                Color = PointColorEnum.Gold;
            }

            // سازنده دوم فقط واسه رنگ
            public PointReadOnlyAfterCreation(PointColorEnum ptColor)
            {
                Color = ptColor;
            }

            // سازنده سوم
            public PointReadOnlyAfterCreation() : this(PointColorEnum.BloodRed) { }
            
            //public PointReadOnlyAfterCreation() { }
        }
    }
//}
