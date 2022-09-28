/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program6a
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = { 1, 2, 6, 2, 18 };

            int i = 0;
            int sum = 0;
            float average = 0.0F;

            for (i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            average = (float)sum / arr.Length;

            Console.WriteLine("Average of Array elements: " + average);
            Console.ReadLine();
        }
    }
}*/












using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
class program6a
{
    public void sumAverageElements(int[] arr, int size)
    {

        int sum = 0;
        int average = 0;
        for (int i = 0; i < size; i++)
        {
            sum += arr[i];
        }
        average = sum / size;
        Console.WriteLine("Sum Of Array is : " + sum);
        Console.WriteLine("Average Of Array is : " + average);
        Console.ReadLine();
    }
    public static void Main(string[] args)
    {
        int size;
        Console.WriteLine("Enter the Size :");
        size = Convert.ToInt32(Console.ReadLine());
        int[] a = new int[size];
        Console.WriteLine("Enter the Elements of the Array : ");
        for (int i = 0; i < size; i++)
        {
            a[i] = Convert.ToInt32(Console.ReadLine());
        }
        int len = a.Length;
        program6a pg = new program6a();
        pg.sumAverageElements(a, len);
    }
}