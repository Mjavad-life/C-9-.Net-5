using System;

Console.WriteLine("***** Fun with Arrays *****");
SimpleArrays();
JaggedMultidimensionalArray();
Console.ReadLine();
static void SimpleArrays()
{
    Console.WriteLine("=> Simple Array Creation.");
    // Create and fill an array of 3 integers
    Console.WriteLine("=> Simple Array Creation.");
    // Create and fill an array of 3 Integers
    int[] myInts = new int[3];
    myInts[0] = 100;
    myInts[1] = 200;
    myInts[2] = 300;
    // Now print each value.
    foreach (int i in myInts)
    {
        Console.WriteLine(i);
    }
    Console.WriteLine();
    string[] booksOnDotNet = new string[100];
    Console.WriteLine();

    int[,] myMatrix;
    myMatrix = new int[3, 4];
    // Populate (3 * 4) array.
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            myMatrix[i, j] = i * j;
        }
    }
    // Print (3 * 4) array.
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            Console.Write(myMatrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

static void JaggedMultidimensionalArray()
{
    Console.WriteLine("=> Jagged multidimensional array.");
    // A jagged MD array (i.e., an array of arrays).
    // Here we have an array of 5 different arrays.
    int[][] myJagArray = new int[5][];
    // Create the jagged array.
    for (int i = 0; i < myJagArray.Length; i++)
    {
        myJagArray[i] = new int[i + 7];
    }
    // Print each row (remember, each element is defaulted to zero!).
    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < myJagArray[i].Length; j++)
        {
            Console.Write(myJagArray[i][j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}