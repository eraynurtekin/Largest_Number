using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_Number
{
    internal class Program
    {
        static int[] arr = { 1, 2, 43, 35, 234, 345, 61, 17 };

        static int largest()
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }
            return max;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Largest is given :" + largest());
            Console.ReadLine();
        }
    }
}
