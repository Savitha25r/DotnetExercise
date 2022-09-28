using System;

namespace program8a
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string : ");
            string str = Console.ReadLine();
            int len = str.Length;
            Console.WriteLine("Length of the string is : " + len);
            Console.ReadLine();
        }
    }
}