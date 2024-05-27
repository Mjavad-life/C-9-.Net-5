using System;
using System.Numerics;
using System.Text;


// LocalVarDeclarations();
//DefaultDeclarations();
//NewingDataTypes();
//NewingDataTypesWith9();
//ObjectFunctionality();
//ParseFromStrings();
//UseBigInteger();
//EscapeChars();
//StringEquality();
//StringEqualitySpecifyingCompareRules();
FunWithStringBuilder();


static void LocalVarDeclarations()
        {
            Console.WriteLine("***** Fun with Basic Data Types *****\n");
            Console.WriteLine("=> Data Declarations:");
            int myInt = 0;

            // You can also declare and assign on two lines.
            string myString;
            myString = "This is my character data";

            // Declare 3 bools on a single line.
            bool b1 = true, b2 = false, b3 = b1;

            // Use System.Boolean data type to declare a bool.
            System.Boolean b4 = false;

            Console.WriteLine();
        }

static void DefaultDeclarations()
        {
            Console.WriteLine("=> Default Declarations:");
            int myInt = default;
        }

static void NewingDataTypes()
        {
            Console.WriteLine("=> Using new to create variables:");

            bool b = new bool();            // Set to false.
            int i = new int();              // Set to 0.
            double d = new double();        // Set to 0.
            DateTime dt = new DateTime();   // Set to 1/1/0001 12:00:00 AM

            Console.WriteLine("{0}, {1}, {2}, {3}", b, i, d, dt);
            Console.WriteLine();
        }

static void NewingDataTypesWith9()
        {
            Console.WriteLine("=> Using new to create variables:");

            bool b = new();         // Set to false.
            int i = new();          // Set to 0.
            double d = new();       // Set to 0.
            DateTime dt = new();    // Set to 1/1/0001 12:00:00 AM

            Console.WriteLine("{0}, {1}, {2}, {3}", b, i, d, dt);
            Console.WriteLine();
        }

static void ObjectFunctionality()
        {
            Console.WriteLine("=> System.Object Functionality:");

            // A C# int is really a shorthand for System.Int32,
            // which inherits the following members from System.Object.

            Console.WriteLine("12.GetHashCode() = {0}", 12.GetHashCode());
            Console.WriteLine("12.Equals(23) = {0}", 12.Equals(23));
            Console.WriteLine("12.ToString() = {0}", 12.ToString());
            Console.WriteLine("12.GetType() = {0}", 12.GetType());
            Console.WriteLine();
        }

static void ParseFromStrings()
{
    Console.WriteLine("=> Data type parsing:");
    bool b = bool.Parse("True");
    Console.WriteLine("Value of b: {0}", b);
    double d = double.Parse("99.884");
    Console.WriteLine("Value of d: {0}", d);
    int i = int.Parse("8");
    Console.WriteLine("Value of i: {0}", i);
    char c = Char.Parse("w");
    Console.WriteLine("Value of c: {0}", c);
    Console.WriteLine();

     
    if(bool.TryParse("True", out bool p))
    {
        Console.WriteLine("doroste");
    }
    else
    {
        Console.WriteLine("borobaba");
    }
}

static void UseBigInteger()
{
    Console.WriteLine("=> Use BigInteger:");
    BigInteger biggy =
    BigInteger.Parse("9999999999999999999999999999999999999999999999");
    Console.WriteLine("Value of biggy is {0}", biggy);
    Console.WriteLine("Is biggy an even value?: {0}", biggy.IsEven);
    Console.WriteLine("Is biggy a power of two?: {0}", biggy.IsPowerOfTwo);
    BigInteger reallyBig = BigInteger.Multiply(biggy,
    BigInteger.Parse("8888888888888888888888888888888888888888888"));
    Console.WriteLine("Value of reallyBig is {0}", reallyBig);
}

static void EscapeChars()
{
    Console.WriteLine("=> Escape characters:\a");
    string strWithTabs = "Model\tColor\tSpeed\tPet Name\a ";
    Console.WriteLine(strWithTabs);
    Console.WriteLine("Everyone loves \"Hello World\"\a ");
    Console.WriteLine("C:\\MyApp\\bin\\Debug\a ");
    // Adds a total of 4 blank lines (then beep again!).
    Console.WriteLine("All finished.\n\n\n\a\a\a\a ");
    Console.WriteLine();
    string myLongString = @"This is a very
        very                                                holo
                very
                        long string";
    Console.WriteLine(myLongString);
}

static void StringEquality()
{
    Console.WriteLine("=> String equality:");
    string s1 = "Hello!";
    string s2 = "Yo!";
    Console.WriteLine("s1 = {0}", s1);
    Console.WriteLine("s2 = {0}", s2);
    Console.WriteLine();
    

// Test these strings for equality.
    Console.WriteLine("s1 == s2: {0}", s1 == s2);
    Console.WriteLine("s1 == Hello!: {0}", s1 == "Hello!");
    Console.WriteLine("s1 == HELLO!: {0}", s1 == "HELLO!");
    Console.WriteLine("s1 == hello!: {0}", s1 == "hello!");
    Console.WriteLine("s1.Equals(s2): {0}", s1.Equals(s2));
    Console.WriteLine("Yo!.Equals(s2): {0}", "Yo!".Equals(s2));
    Console.WriteLine();
}

static void StringEqualitySpecifyingCompareRules()
{
    Console.WriteLine("=> String equality (Case Insensitive:");
    string s1 = "Hello!";
    string s2 = "HELLO!";
    Console.WriteLine("s1 = {0}", s1);
    Console.WriteLine("s2 = {0}", s2);
    Console.WriteLine();
    // Check the results of changing the default compare rules.
    Console.WriteLine("Default rules: s1={0},s2={1}s1.Equals(s2): {2}", s1, s2,
    s1.Equals(s2));
    Console.WriteLine("Ignore case: s1.Equals(s2, StringComparison.OrdinalIgnoreCase): {0}",
    s1.Equals(s2, StringComparison.OrdinalIgnoreCase));
    Console.WriteLine("Ignore case, Invariant Culture: s1.Equals(s2, StringComparison.InvariantCultureIgnoreCase): {0}",
    s1.Equals(s2, StringComparison.InvariantCultureIgnoreCase));

    Console.WriteLine();

    Console.WriteLine("Default rules: s1={0},s2={1} s1.IndexOf(\"E\"): {2}", s1, s2,
    s1.IndexOf("E"));
Console.WriteLine("Ignore case: s1.IndexOf(\"E\", StringComparison.OrdinalIgnoreCase):{0}", s1.IndexOf("E ",
StringComparison.OrdinalIgnoreCase));

Console.WriteLine("Ignore case, Invariant Culture: s1.IndexOf(\"E\", StringComparison.InvariantCultureIgnoreCase): {0}",
s1.IndexOf("E", StringComparison.InvariantCultureIgnoreCase));

Console.WriteLine();
}

static void FunWithStringBuilder()
{
    Console.WriteLine("=> Using the StringBuilder:");
    StringBuilder sb = new StringBuilder("**** Fantastic Games ****");
    sb.Append("\n");
    Console.WriteLine(sb.ToString());
    sb.AppendLine("Half Life");
    Console.WriteLine(sb.ToString());
    sb.AppendLine("Morrowind");
    Console.WriteLine(sb.ToString());
    sb.AppendLine("Deus Ex" + "2");
    Console.WriteLine(sb.ToString());
    sb.AppendLine("System Shock");
    Console.WriteLine(sb.ToString());
    sb.Replace("2", " Invisible War");
    Console.WriteLine(sb.ToString());
    Console.WriteLine("sb has {0} chars.", sb.Length);
    Console.WriteLine();
}

// }
//}