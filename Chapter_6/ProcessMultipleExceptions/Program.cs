using System;
using System.IO;
using ProcessMultipleExceptions;


Console.WriteLine("***** Handling Multiple Exceptions *****\n");
Car myCar = new Car("Rusty", 90);

try
{
    // Trip Arg out of range exception.
    myCar.Accelerate(-10);
}

// first catch
catch (CarIsDeadException e)
{
    Console.WriteLine(e.Message);
}

// second catch
catch (ArgumentOutOfRangeException e)
{
    Console.WriteLine(e.Message);
}

// add third most general catch
// at the end of catch chain

catch(Exception e)
{
    Console.WriteLine(e.Message);
}