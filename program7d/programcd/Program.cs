using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programcd
{
    class Program
    {
        static void Main(string[] args)

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




            //printing  min marks
           
            Console.WriteLine("minimum mark is " + mn);
            Console.ReadLine();

        }
    }
}
