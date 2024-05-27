using System;
using ComparableCar;

Console.WriteLine("***** Fun with Object Sorting *****\n");

// Make an array of Car objects.
Car[] myAutos = new Car[6];

myAutos[0] = new Car("Rusty", 80, 1);
myAutos[1] = new Car("Mary", 40, 234);
myAutos[2] = new Car("Viper", 40, 34);
myAutos[3] = new Car("Mel", 40, 4);

// if to Car id are same the order is
// based on first character of pet name
// so chucky comes before ducky

myAutos[4] = new Car("Chucky", 40, 5);
myAutos[5] = new Car("Ducky", 40, 5);

// Display current array.
Console.WriteLine("Here is the unordered set of cars:");
foreach (Car c in myAutos)
{
    Console.WriteLine("{0} {1}", c.CarID, c.PetName);
}
// Now, sort them using IComparable!
// Car class must implement icomparable interface
// to send myautos to sort array.sort method
// cause its a custom type
Array.Sort(myAutos);

Console.WriteLine();
// Display sorted array.
Console.WriteLine("Here is the ordered set of cars:");
foreach (Car c in myAutos)
{
    Console.WriteLine("{0} {1}", c.CarID, c.PetName);
}

Console.WriteLine();
Console.WriteLine("Now sort by pet name :");
// using icompare interface 
// pet name comparer is a helper class to assist 
// car class in sorting instances by pet name
Array.Sort(myAutos, new PetNameComparer());
Array.Sort(myAutos);


foreach (Car c in myAutos)
{
    Console.WriteLine("{0} {1}", c.CarID, c.PetName);
}

Console.ReadLine();
//Console.ReadLine();