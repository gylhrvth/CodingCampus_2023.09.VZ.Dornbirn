using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandro.Week03.SortAlgos
{
    internal class HeapSort
    {
        public static Random rand = new Random();
        static string RED = "\x1b[91m";
        static string MAGENTA = "\x1b[95m";
        static string NORMAL = "\x1b[39m";
        static string GREEN = "\x1b[92m";
        static string YELLOW = "\x1b[93m";
        static string BLUE = "\x1b[94m";
        static string CYAN = "\x1b[96m";
        static string GREY = "\x1b[97m";
        static string BOLD = "\x1b[1m";
        static string NOBOLD = "\x1b[22m";
        static string UNDERLINE = "\x1b[4m";
        static string NOUNDERLINE = "\x1b[24m";
        static string REVERSE = "\x1b[7m";
        static string NOREVERSE = "\x1b[27m";
        public static void Start() {

            int[] Array = CreateRandomArray(10);
            Console.WriteLine("Orginal Array");
            PrintArray(Array);
            Console.WriteLine("Sorted Array");
            PrintArray(heapSort(Array));
        
        }

        public static int[] heapSort(int[] arr)
        {
            buildHeap(arr);
            int n = arr.Length - 1;
            while (n > 0)
            {
                swap(arr, 0, n);
                
                --n;
                siftDown(arr, 0, n + 1);
            }
            return arr;
        }

        public static void buildHeap(int[] arr)
        {
            for (int i = arr.Length / 2; i >= 0; i--)
            {
                siftDown(arr, i, arr.Length);
            }
        }

        public static void siftDown(int[] arr, int i, int n)
        {
            if (2 * i >= n) return;
            int k = 2 * i;

            if ((2 * i + 1 < n) && (arr[2 * i] < arr[2 * i + 1]))
            {
                ++k;
            }

            if (arr[i] < arr[k])
            {
                swap(arr, i, k);
                siftDown(arr, k, n);
            }
        }

        public static void swap(int[] arr, int i, int j)
        {PrintSteps(arr, arr[i], arr[j]);
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
            
        }
        public static int[] CreateRandomArray(int size)
        {
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = rand.Next(101);
            }
            return array;
        }
        public static void PrintArray(int[] arr)
        {
            Console.Write("[");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
                if (i < arr.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.Write("]");
            Console.WriteLine();

        }
        public static void PrintSteps(int[] arr, int target, int swap)
        {

            Console.Write("[");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                {
                    Console.Write($"{BLUE}{arr[i]}{NORMAL}");
                }
                else if (arr[i] == swap)
                {
                    Console.Write($"{RED}{arr[i]}{NORMAL}");
                }
                else
                {
                    Console.Write($"{arr[i]}");
                }

                if (i < arr.Length - 1)
                {
                    Console.Write(", ");
                }

            }
            Console.Write("]");
            Console.WriteLine();


        }
    }
}
