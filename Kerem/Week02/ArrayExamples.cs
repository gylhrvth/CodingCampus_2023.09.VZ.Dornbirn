using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kerem.Week02
{
    internal class ArrayExamples
    {
        public static void StartArrayExamples()
        {
            int[] arr = CreateArray(10);
            PrintArray(arr);
            int[] arr2 = CreateArray2(10);
            PrintArray(arr2);


            //int[] arr = { 1, 2, 3, 4, 5, 6};
            //{
            //    Console.WriteLine(arr);
            //    for(int i = 0; i < arr.Length; ++i)
            //    {
            //        Console.WriteLine("{0}. = {1} ", i, arr[i]);
            //    }
            //}
            //int[] arr2 = { 6, 5, 4, 3, 2, 1 };
            //{
            //    Console.WriteLine(arr2);
            //    for(int i = 0; i < arr2.Length; ++i)
            //    {
            //        Console.WriteLine("{0}. = {1}", i, arr2[i]);
            //    }
            //}
        }

        public static void PrintArray(int[] arr)
        {
            // Hier muss man einen Ausdruck siehe Oben...
            //for (int i = 0; i < arr.Length; ++i)
            //{
            //    Console.WriteLine("{0}. = {1} ", i, arr[i]);
            //}
            // alternative wäre
            Console.WriteLine("[{0}]", string.Join(", ", arr));
        }


        public static int[] CreateArray(int size)
        {
            int[] arr = new int[size];
            // Hier kommt die Initialisierung
            for (int i = 0; i < arr.Length; ++i)
            {
                arr[i] = 1+ i;

            }

            return arr;
        }
        public static int[] CreateArray2(int size)
        {
            int[] arr2 = new int[size];
            // Hier kommt die Initialisierung
            for (int i = 0; i < arr2.Length; ++i)
            {
                arr2[i] = arr2.Length - i;

            }

            return arr2;
        }
    }
}
