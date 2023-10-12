using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Erik.Week03
{
    public class SortAlgorithmBubblesort
    {
        public static void StartSortAlgorithm()
        {

            System.Diagnostics.Stopwatch.StartNew();
            var timer = new Stopwatch();
            //SortAlgoBubblesort(NumbersOutput(10, 100, 20));
            PrintArrayWithIndex(SortAlgoBubblesort(NumbersOutput(10, 100, 20)));




        }

        public static int[] NumbersOutput(int randMin, int randMax, int randSize)
        {
            int[] arr1 = new int[randSize];
            Random random = new Random();
            Console.WriteLine("Unsorted Numbers:");

            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = random.Next(randMin, randMax);
            }
            for (int i = 0; i < arr1.Length; i++)
            {
                if (i % 20 == 0)
                {
                    Console.WriteLine("");
                }
                Console.Write(arr1[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Sorted Numbers:");
            Console.WriteLine();
            return arr1;
        }

        public static int[] SortAlgoBubblesort(int[] arr)
        {
            int n = arr.Length;
            int counter = 1;


            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int tmp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = tmp;
                        //PrintArrayWithIndex(arr);
                        // Console.Write(arr[j] + " ");
                    }
                    //else
                    //{
                    //    Console.Write(arr[j] + " ");
                    //}

                    counter++;
                }
            }
            return arr;
        }

        public static void PrintArrayWithIndex(int[] arr)
        {
            Console.Write("[");
            for (int i = 0; i < arr.Length; i++)
            {
                if (i > 0)
                {
                    Console.Write(", ");
                }
                Console.Write(arr[i]);
            }
            Console.WriteLine("]");
        }
    }
}
