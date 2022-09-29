
    using System;
public class program7c
{
    public static void Main()
    {

        int mx;
        int mn;



        int[] marks = new int[10];

       
        //Inputs -- Marks



        for (int i = 0; i < marks.Length; i++)
        {
            marks[i] = Convert.ToInt32(Console.ReadLine());
        }



        mx = marks[0];
        mn = marks[0];



        //finding min and max marks
        for (int j = 1; j < marks.Length; j++)
        {
            if (marks[j] < mn)
            {
                mn = marks[j];
            }



            if (marks[j] > mx)
            {
                mx = marks[j];
            }
        }




        //printing  max marks
        Console.WriteLine("maximum mark is " + mx);
       
        Console.ReadLine();

    }
}


















