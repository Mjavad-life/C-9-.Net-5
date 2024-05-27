﻿using System;


Console.WriteLine("***** A First Look at Structures *****\n");

    // Create an initial Point.
    Point myPoint;
    myPoint.X = 349;
    myPoint.Y = 76;
    myPoint.Display();

    // Adjust the X and Y values.
    myPoint.Increment();
    myPoint.Display();
    Console.ReadLine();

struct NormalPoint
{
    //This does not compile
    public  string PropPointer { get; set; }
}

struct Point
    {
        // Fields of the structure.
        public int X;
        public int Y;

    // A custom constructor.
    public Point(int xPos, int yPos)
    {
        X = xPos;
        Y = yPos;
    }
    // Add 1 to the (X, Y) position.
    public void Increment()
        {
            X++; Y++;
        }
        // Subtract 1 from the (X, Y) position.
        public void Decrement()
        {
            X--; Y--;
        }
        // Display the current position.
        public void Display()
        {
            Console.WriteLine("X = {0}, Y = {1}", X, Y);
        }
    }

    

