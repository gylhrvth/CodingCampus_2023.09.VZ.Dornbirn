using System;
using System.Reflection.Metadata.Ecma335;

namespace Sven.Week02
{
    public class ArrayUebungen
    {

        public static Random Random = new Random();

        public static void ArrayExamples()
        {
            Console.WriteLine("Example 1 Count:");
            Count();
            Console.WriteLine();

            Console.WriteLine("Example 2 Copy:");
            Copy();
            Console.WriteLine();

            Console.WriteLine("Example 3 Crazy Range:");
            CrazyRange();
            Console.WriteLine();

            Console.WriteLine("Example 4 Random:");
            int[] arr = RandomArray(10);
            Console.WriteLine("[{0}]", string.Join(", ", arr));
            Console.WriteLine();

            Console.WriteLine("RandomCount1");
            int count = RandomCount1(arr);
            Console.WriteLine("Es sind " + count + " Zahlen über 30");
            Console.WriteLine();

            Console.WriteLine("Example 5 Random2:");
            int sum = RandomSum(arr);
            Console.WriteLine("Die Summe der Zahlen ist: " + sum);
            Console.WriteLine();

            Console.WriteLine("Example 6 RandomMin: ");
            int min = RandomMin(arr);
            Console.WriteLine("Das Minimum ist:  " + min);
            Console.WriteLine();

            Console.WriteLine("Example 7 RandomMax: ");
            int max = RandomMax(arr);
            Console.WriteLine("Das Maximum ist:  " + max);
            Console.WriteLine();

            Console.WriteLine("Example 8 RandomAvg: ");
            double avg = RandomAvg(arr);
            Console.WriteLine("Das Avg ist:  " + avg);
            Console.WriteLine();

            Console.WriteLine("Example 9 SortAscending:");
            SortAscending(arr);
            Console.WriteLine();

            Console.WriteLine("Example 9 SortDescending:");
            SortDescending(arr);
            Console.WriteLine();




        }


        static void Count()
        {
            int[] arr = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };



            for (int i = 0; i < arr.Length; ++i)
            {
                Console.WriteLine("{0}. = {1}", i, arr[i]);
            }

            Console.WriteLine("=============================");


            int[] arr2 = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };


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


        public static int[] RandomArray(int size)
        {
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Random.Next(101);

            }
            return arr;

        }


        static void CrazyRange()
        {

            for (int i = 0; i < 10; i++)
            {
                int[] arr = { Random.Next(-50, 50) };

                Console.WriteLine(String.Join(", ", arr));

            }

        }

        public static int RandomCount1(int[] arr)
        {
            int count = 0;
            foreach (int i in arr)
            {
                if (i > 30)
                {
                    count++;
                }
            }
            return count;
        }


        public static int RandomSum(int[] arr)
        {

            int sum = 0;
            foreach (int i in arr)
            {
                sum += i;

            }
            return sum;


        }
        public static int RandomMin(int[] arr)
        {

            int min = int.MaxValue;
            foreach (int i in arr)
            {
                if (i < min)
                {
                    min = i;
                }

            }
            return min;


        }
        public static int RandomMax(int[] arr)
        {

            int max = int.MinValue;
            foreach (int i in arr)
            {
                if (i > max)
                {
                    max = i;
                }
            }
            return max;
        }



        public static double RandomAvg(int[] arr)
        {

            int sum = 0;
            foreach (int i in arr)
            {
                sum += i;
            }

            return (double)sum / arr.Length;
        }


        public static void SortAscending(int[] arr)
        {
            int temp = 0;

            for (int count = 0; count < arr.Length; count++)
            {
                for (int sort = 0; sort < arr.Length - 1; sort++)
                {
                    if (arr[sort] > arr[sort + 1])
                    {
                        temp = arr[sort + 1];
                        arr[sort + 1] = arr[sort];
                        arr[sort] = temp;
                    }
                }
                Console.Write("{0} ", arr[count]);

            }

        }
        public static void SortDescending(int[] arr)
        {
            int temp = 0;

            for (int count = 0; count < arr.Length ; count++)
            {
                for (int sort = 0; sort < arr.Length - 1; sort++)
                {
                    if (arr[sort] > arr[sort + 1])
                    {
                        temp = arr[sort + 1];
                        arr[sort + 1] = arr[sort];
                        arr[sort] = temp;
                    }
                }
                Console.Write("{0} ", arr[count]);
            }
        }
    }
}

