using System;

using InterfaceHierarchy;

Console.WriteLine("******* simple interface hierarchi bazi*******");

BitmapImage myBitmap = new BitmapImage();
myBitmap.Draw();
myBitmap.DrawInBoundingBox(10, 10, 100, 150);
myBitmap.DrawUpsideDown();

if (myBitmap is IAdvancedDraw iAdvDraw)
{
    iAdvDraw.DrawUpsideDown();

    // timetodraw is defined in idrawable
    Console.WriteLine($"Time to draw: {iAdvDraw.TimeToDraw()}");
}
