using System;

Console.WriteLine("**** Fun with Enums *****");

// These types are enums in the System namespace.
EmpTypeEnum e2 = EmpTypeEnum.Contractor;
DayOfWeek day = DayOfWeek.Monday;
ConsoleColor cc = ConsoleColor.Gray;

EvaluateEnum(e2);
EvaluateEnum(day);
EvaluateEnum(cc);
Console.ReadLine();

static void EvaluateEnum(Enum e)
{
    Console.WriteLine("=> Information about {0}", e.GetType().Name);
    // خط زیر نوع مقدار اینوم رو مشخص میکنه
    Console.WriteLine("Underlying storage type: {0}",
    Enum.GetUnderlyingType(e.GetType()));

    // Get all name-value pairs for incoming parameter.
    Array enumData = Enum.GetValues(e.GetType());
    Console.WriteLine("This enum has {0} members.", enumData.Length);

    // Now show the string name and associated value, using the D format
    // flag (see Chapter 3).
    for (int i = 0; i < enumData.Length; i++)
    {
        Console.WriteLine("Name: {0}, Value: {0:D}",
   enumData.GetValue(i));
    }
}

enum EmpTypeEnum 
{
    Manager = 10,
    Grunt = 1,
    Contractor = 100,
    VicePresident = 999
}






