using System;  
public class program7a
{
    public static void Main()
    {
        int i, n, total = 0;
       

        Console.Write("\n\n");
        Console.Write("Read 10 numbers and calculate sum and average:\n");
        Console.Write("----------------------------------------------");
        Console.Write("\n\n");

        Console.Write("Input the 10 numbers : \n");
        for (i = 1; i <= 10; i++)
        {
            Console.Write("Number-{0} :", i);

            n = Convert.ToInt32(Console.ReadLine());
            total += n;
        }
       
        Console.Write("The total of 10 no is : {0}\n", total);
        Console.ReadLine();
    }
}
