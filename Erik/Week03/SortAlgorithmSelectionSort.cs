using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erik.Week03
{
    public class SortAlgorithmSelectionSort
    {
        public static void StartSortAlgorithmSelctionSort()
        {
            int[] arr = creatArrayList(10, 10, 101);
            printSortedArrayList(selectionArrayListAlgorithm(arr));
        }

        public static int[] creatArrayList(int randomSize, int randomNumMin, int randomNumMax)
        {
            int[] arrList = new int[randomSize];
            Random randomiseNumbers = new Random();
            Console.WriteLine("Unsorted:");

            for (int i = 0; i < arrList.Length; i++)
            {
                arrList[i] = randomiseNumbers.Next(randomNumMin, randomNumMax);
                Console.Write(arrList[i] + " ");
            }
            Console.WriteLine();
            return arrList;
            
        }

        public static int[] selectionArrayListAlgorithm(int[] arrList)
        {
            var tmpVar = 0;

            
            for (int i = 0; i < arrList.Length; i++)
            {
                int minimum = i;
                for (int j = i + 1; j < arrList.Length; j++)
                {
                    if (arrList[j] < arrList[minimum])
                    {
                        minimum = j;
                    }
                }
                tmpVar = arrList[minimum];
                arrList[minimum] = arrList[i];
                arrList[i] = tmpVar;
            }
            return arrList;

        }
        public static void printSortedArrayList(int[] sortedArrayList)
        {
            int[] arrList = sortedArrayList;

            Console.WriteLine("Sorted: ");
            Console.Write("[");
            for (int i = 0; i < sortedArrayList.Length; i++)
            {
                if (i > 0)
                {
                    Console.Write(", ");
                }
                Console.Write(sortedArrayList[i]);
            }
            Console.WriteLine("]");
        }
    }
}











