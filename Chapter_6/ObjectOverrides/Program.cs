using System;
using ObjectOverrides;


Console.WriteLine("***** Fun with System.Object *****\n");

Person Mansor = new Person("shabahs", "shadoneh", 21, "11-11-111");
Person Shapor = new Person("shabahs", "shadoneh", 21, "11-11-111");
// to show mansor.tostring i put it in cw else
// it doesnt show properties
Console.WriteLine(Mansor.ToString());
Console.WriteLine(Shapor.ToString());

Console.WriteLine("Mansor Equal Shapor : {0}" , Mansor.Equals(Shapor));
Console.WriteLine("hash codes equal ? {0}", Mansor.GetHashCode()== Shapor.GetHashCode());

Shapor.Age = 22;

Console.WriteLine(Mansor.ToString());
Console.WriteLine(Shapor.ToString());

Console.WriteLine("Mansor Equal Shapor : {0}", Mansor.Equals(Shapor));
Console.WriteLine("hash codes equal ? {0}", Mansor.GetHashCode() == Shapor.GetHashCode());


/// /// ////////////////////////////////////

Person p1 = new Person();

// Use inherited members of System.Object.
Console.WriteLine("ToString: {0}", p1.ToString());
Console.WriteLine("Hash code: {0}", p1.GetHashCode());
Console.WriteLine("Type: {0}", p1.GetType());

// Make some other references to p1.
Person p2 = p1;
object o = p2;

// Are the references pointing to the same object in memory?
if (o.Equals(p1) && p2.Equals(o))
{
    Console.WriteLine("Same instance!");
}


