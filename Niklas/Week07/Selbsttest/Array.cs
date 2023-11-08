using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Niklas.Week07.Selbsttest
{
    internal class Array
    {
        public static Random random = new Random();
        public static void Start()
        {
            int[] arr = new int[] { 0, 1, 23, 5, 12, 4, 4, 2, 5, 2, 10 };

            int[] arr1 = CreateArrayRandom(20, 0, 101);
            int[] arr2 = CreateArrayRandom(20, 0, 101);

            PrintFirstAndLast(arr);
            Console.WriteLine();
            PrintMyresult(arr);
            Console.WriteLine();
            FillArr(arr);
            CreateArrayRandom(20, 0, 101);
            Bubblesort(arr1, false);
            Console.WriteLine("Bubblesort: " + string.Join(", ", arr1));
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
        public static void FillArr(int[] arr)
        {
            int i = 0;

            for (; i < arr.Length; i++)
                Console.Write(i + " ");

            Console.WriteLine();

            foreach (int value in arr)
            {
                Console.Write(value + " ");
            }

            Console.WriteLine();
            Console.WriteLine("[{0}]", string.Join(", ", arr));


        }
        public static int[] Bubblesort(int[] arr, bool AorD)
        {
            if (AorD == true)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    for (int j = 0; j < arr.Length - 1 - i; j++)
                    {
                        if (arr[j] > arr[j + 1])
                        {
                            int temp = arr[j];
                            arr[j] = arr[j + 1];
                            arr[j + 1] = temp;
                        }
                    }
                }
            }
            else if (AorD == false)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    for (int j = 0; j < arr.Length - 1 - i; j++)
                    {
                        if (arr[j] < arr[j + 1])
                        {
                            int temp = arr[j];
                            arr[j] = arr[j + 1];
                            arr[j + 1] = temp;
                        }
                    }
                }
            }
            return arr;
        }

        public static int[] CreateArrayRandom(int size, int min, int max)
        {
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(min, max);
            }
            return arr;
        }

    }
}
