using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Niklas.Week03
{
    internal class ArrayNumber
    {
        public static Random random = new Random();
        public static void Start()
        {
            Console.WriteLine("\nCount: ");
            Count();
            Console.WriteLine();

            Console.WriteLine("\nCopy: ");
            MakeACopy();
            Console.WriteLine();

            Console.WriteLine("\nRandom Number: ");
            RandomNumber();
            Console.WriteLine();
        }

        static void Count()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine(arr);

            for (int i = 0; i < arr.Length; ++i)
            {
                Console.WriteLine("{0}. = {1}", i, arr[i]);
            }

            int[] arr2 = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            Console.WriteLine(arr2);

            for (int i = 0; i < arr2.Length; ++i)
            {
                Console.WriteLine("{0}. = {1}", i, arr2[i]);
            }
        }

        public static void MakeACopy()
        {
            for (int i = 0; i < 2; i++)
            {
                int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

                int[] copy = new int[arr.Length];
                Array.Copy(arr, copy, arr.Length);

                Console.WriteLine(string.Join(", ", copy));

            }

        }
        public static void RandomNumber()


        {
            int[] fixArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] myArray = CreateArray(10);

            foreach (int value in myArray)
            {
                Console.WriteLine("{0}", value);
            }

            Console.WriteLine("[{0}]", string.Join(", ", myArray));

           // Console.WriteLine("[{0}]", string.Join(", ", myArray)); ?


        }

        public static int[] CreateArray(int size)
        {
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(100);
            }

            return arr;
        }



    }
}











