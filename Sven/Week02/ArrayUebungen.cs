using System;

namespace Sven.Week02
{
    internal class ArrayUebungen
    {
        public static void ArrayExamples()
        {
            Console.WriteLine("Example1 Count:");
            Count();
            Console.WriteLine();

            Console.WriteLine("Example2 Copy:");
            Copy();
            Console.WriteLine();

            Console.WriteLine("Example3 Random:");
            RandomArray();
            Console.WriteLine();

            Console.WriteLine("Example4 Range:");
            CrazyRange();
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

        static void Copy()
        {

            int[] arr = { 10, 23, 34, 12, 45, 16, 2 };
            foreach (int i in arr)
            {
                Console.Write(i + ", ");
            }

            Console.WriteLine();

            arr[2] = 0;

            int[] arr2 = arr;
            foreach (int i in arr)
            {
                Console.Write(i + ", ");
            }


            /*
            int[] arr = { 6, 2, 8, 5, 4 };

            int[] copy = new int[arr.Length];
            Array.Copy(arr, copy, arr.Length);

            for (int i = 0; i < 10; i++)

                Console.WriteLine(String.Join(", ", copy));
            */

        }

        static void RandomArray()
        {

            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                int[] arr = { random.Next(100) };

                Console.WriteLine(String.Join(", ", arr));
            }

        }


        static void CrazyRange()
        {

            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                int[] arr = { random.Next(-50, 50) };

                Console.WriteLine(String.Join(", ", arr));


            }
        }

    }

}

