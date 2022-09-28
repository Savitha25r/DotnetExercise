using System;  
public class program7b
{
    public static void Main()
    {
        int i, n, total = 0;
        double avg;

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
        avg = total / 10.0;
        Console.Write("The total of 10 no is : {0}\nThe Average is : {1}\n", total, avg);
        Console.ReadLine();
    }
}
