using System;


ShowEnvironmentDetails();

Console.ReadLine();
return -1;

static void ShowEnvironmentDetails()
{
    // درایور ها و چیزهای باحال دیگه رو نشون میده
    foreach(string drive in Environment.GetLogicalDrives())
    {
        Console.WriteLine("Drive: {0}", drive);
    }
    Console.WriteLine("OS: {0}", Environment.OSVersion);
    Console.WriteLine("Number of Processors :{0}", Environment.ProcessorCount);
    Console.WriteLine(".Net Version {0}", Environment.Version);
    
}



