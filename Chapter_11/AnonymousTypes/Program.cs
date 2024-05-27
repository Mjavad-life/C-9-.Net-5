using System;


EqualityTest();


static void ReflectOverAnonymousType(object obj)
{
    Console.WriteLine("obj is an instance of: {0}" ,
    obj.GetType().Name);
    
    Console.WriteLine("Base class of {0} is {1}",
    obj.GetType().Name, obj.GetType().BaseType);
    
    Console.WriteLine("obj.ToString() == {0}", obj.ToString());
    
    Console.WriteLine("obj.GetHashCode() == {0}",
    obj.GetHashCode());
    
    Console.WriteLine();
}

static void EqualityTest()
{
    // Make 2 anonymous classes with identical name/value pairs.
    var firstCar = new
    {
        Color = "Bright Pink",
        Make = "Saab",
        CurrentSpeed = 55
    };
    
    var secondCar = new
    {
        Color = "Bright Pink",
        Make = "Saab",
        CurrentSpeed = 55
    };
    
    // Are they considered equal when using Equals()?
    if (firstCar.Equals(secondCar))
    {
        Console.WriteLine("firstCar.Equals(secondCar) => Same anonymous object!");
    }
    else
    {
        Console.WriteLine("firstCar.Equals(secondCar) => Not the same anonymous object!");
    }
    
    // Are they considered equal when using ==?
    if (firstCar == secondCar)
    {
        Console.WriteLine("firstCar == secondCar => Same anonymous object!");
    }
    else
    {
        Console.WriteLine("firstCar == secondCar => Not the same anonymous object!");
    }
    
    // Are these objects the same underlying type?
    if (firstCar.GetType().Name == secondCar.GetType().Name)
    {
        Console.WriteLine("firstCar.GetType().Name == secondCar.GetType().Name => We are both the same type!");
    }
    else
    {
        Console.WriteLine("firstCar.GetType().Name == secondCar.GetType().Name => We are different types!");
    }
    
    // Show all the details.
    Console.WriteLine();
    ReflectOverAnonymousType(firstCar);
    ReflectOverAnonymousType(secondCar);
}