using System;

class program9c
{

    // Driver code
    public static void Main()
    {

        // Get the strings which is to be checked
        String string1 = Console.ReadLine();
        Console.WriteLine("Enter the first string: "
                          + string1);

        // Get the strings which is to be checked
        String string2 = Console.ReadLine();
        Console.WriteLine("Enter the second string :"
                          + string2);

        // Check if both strings are equal
        Console.WriteLine("\nAre both strings same: ");

        if (string1.Equals(string2) == true)
        {
            Console.WriteLine("Yes");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("No");
            Console.ReadLine();
        }
    }
}