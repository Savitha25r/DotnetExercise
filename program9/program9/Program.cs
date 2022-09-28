using System;
namespace program9
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string to Check Palindrome : ");
            string name = Console.ReadLine();
            string reverse = string.Empty;

            for (int i = name.Length - 1; i >= 0; i--)
            {
                reverse += name[i];
            }

            if (name == reverse)
            {
                Console.WriteLine($"{name} is Palindrome.");
            }
            else
            {
                Console.WriteLine($"{name} is not Palindrome");
            }
            Console.ReadKey();
        }
    }
}


/*using System;
public class program9
{
    public static void Main(string[] args)
    {
        int no, total = 0, t, rev;
        Console.Write("Please provide the no: ");
        no = int.Parse(Console.ReadLine());
        t = no;
        while (no > 0)
        {
            rev = no % 10;
            total = (total * 10) + rev;
            no = no / 10;
        }
        if (t == total)
            Console.Write("The given number is Palindrome.");
        else
            Console.Write("The given number is not Palindrome");
        Console.ReadLine();
    }
}*/