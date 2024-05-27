using System;

//WhileLoopExample();
ExecutePatternMatchingSwitch();

static void WhileLoopExample()
{
    string userIsDone = "";
    // Test on a lower-class copy of the string.
    while (userIsDone.ToLower() != "yes")
    {
        Console.WriteLine("In while loop");
        Console.Write("Are you done? [yes] [no]: ");
        userIsDone = Console.ReadLine();
    }
}


static void ExecutePatternMatchingSwitch()
{
    Console.WriteLine("1 [Integer (5)], 2 [String (\"Hi\")], 3 [Decimal (2.5)]");
    Console.Write("Please choose an option: ");
    string userChoice = Console.ReadLine();
    // خط کد زیر رو دستکاری کردم
    object choice;
    switch (userChoice)
    {
        case "1":
            choice = 5;
            break;
        case "2":
            choice = "Hi";
            break;
        case "3":
            choice = 2.5m; // روباید اضافه میکردم m
            break;
        default:
            choice = 5;
            break;
    }
    switch (choice)
    {
        case int i:
            Console.WriteLine("Your choice is an integer {0}.", i);
            break;
        case string s:
            Console.WriteLine("Your choice is a string. {0}", s);
            break;
        case decimal d:
            Console.WriteLine("Your choice is a decimal. {0}", d);
            break;
        default:
            Console.WriteLine("Your choice is something else");
            break;
    }
}