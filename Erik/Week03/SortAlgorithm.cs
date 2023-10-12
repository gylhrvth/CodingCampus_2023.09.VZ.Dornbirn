using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Erik.Week03
{
    public class SortAlgorithm
    {
        public static void StartSortAlgorithm()
        {
            SortAlgoBubblesort(NumbersOutput(10, 100, 40));
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

        public static void SortAlgoBubblesort(int[] arr)
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
                        Console.Write(arr[j] + "  ");
                    }
                    else
                    {
                        Console.Write(arr[j] + "  ");
                    }
                    if (counter % 20 == 0)
                    {
                        Console.WriteLine();
                    }
                    counter++;
                }
            }
        }
    }
}
