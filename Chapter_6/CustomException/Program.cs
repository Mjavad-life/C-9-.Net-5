using System;
using CustomException;

Console.WriteLine("**** bazi ba custom exception");

Car mucar = new Car("roro", 90);


try
{
    mucar.Accelerate(10);
}
catch (CarIsDeadException exp)
{
    Console.WriteLine("Iradat shoro shod");

    Console.WriteLine(exp.Message);
    Console.WriteLine(exp.ErrorTimeStamp);
    Console.WriteLine(exp.CauseOfError);
  
    Console.WriteLine("Iradat tamam shod");
}

