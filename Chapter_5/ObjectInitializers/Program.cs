using System;

namespace ObjectInitializers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            //بود pointreadonly مشکل در تو در تو بودن کلاس
            // با خط زیر از قابلیت ساختن همراه مقدار اولیه فایده برد
            PointReadOnlyAfterCreation point = new PointReadOnlyAfterCreation(PointColorEnum.Gold) { X = 10, Y = 35 };
            point.DisplayStats();
        }
    }
}
