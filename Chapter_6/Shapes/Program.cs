using System;
using Shapes;

Console.WriteLine("**********poly bazi********");

Shape[] shapes = {new Hexagon() , new Circle() , new Hexagon(" lida")
        ,new Circle("mina"), new Hexagon(" moshi")};

// loop in shape[]

foreach (var shape in shapes)
{
    shape.Draw();
}

