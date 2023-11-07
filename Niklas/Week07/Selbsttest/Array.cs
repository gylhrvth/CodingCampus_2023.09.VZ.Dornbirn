using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Niklas.Week07.Selbsttest
{
    internal class Array
    {
        public static void Start()
        {
            int[] arr = new int[] { 0, 1, 23, 5, 12, 4, 4, 2, 5, 2, 10 };
            int[] arr2 = new int[] { 123, 19471, 1, 4, 15715, 15, 1, 5, 15, 1, -10, -100 };
            int[] arr3 = new int[] { 478199, 7812973, 12387123, 12, 3, 123, 12, 3, 1, 3, 1, 3, 1, 8, 9, 15, 1, 5, 1, 5, 1, 5, 15, 1, 5, 0 };

            PrintFirstAndLast(arr);
            Console.WriteLine();
            PrintMyresult(arr);
            Console.WriteLine();
            FillArr(10);
        }

        public static void PrintFirstAndLast(int[] arr)
        {
            Console.WriteLine(arr[0] + ", " + arr[arr.Length - 1]);
        }
        public static void PrintMyresult(int[] arr)
        {
            int max = Int32.MinValue;
            int min = Int32.MaxValue;

            foreach (int value in arr)
            {
                if (value < min)
                {
                    min = value;
                }
            }
            Console.WriteLine("min value: " + min);

            foreach (int value in arr)
            {
                if (value > max)
                {
                    max = value;
                }
            }
            Console.WriteLine("max value: " + max);

            int sum = 0;
            foreach (int value in arr)
            {
                sum += value;
            }

            double avg = sum / arr.Length;
            Console.WriteLine("Average value: " + avg);
        }
        public static void FillArr(int fill)
        {;
            int i = fill;
            for (; i > 0; i--)
            {
                Console.WriteLine(fill);
            }
          
        }
    }
}
