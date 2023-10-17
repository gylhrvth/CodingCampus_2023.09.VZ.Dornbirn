using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandro.Week03.SortAlgos
{
    internal class MergeSort
    {
        static Random random = new Random();
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

        public static void Start()
        {

            int[] randomArray1 = CreateRandomArray(10);
            Console.WriteLine($"{UNDERLINE}Insert Sort Action{NOUNDERLINE} \n");
            Console.WriteLine($"{UNDERLINE}Version #1{NOUNDERLINE}");
            PrintArray(randomArray1);
            Console.WriteLine("----------------------------------------");
            MergeSortIncreas(randomArray1,0, randomArray1.Length);
            Console.WriteLine(" ");
            int[] randomArray2 = CreateRandomArray(10);
            Console.WriteLine($"{UNDERLINE}Version 2#{NOUNDERLINE}");
            Console.WriteLine("----------------------------------------");
            mergeSort("", randomArray2,0,randomArray2.Length);
        }
        public static void mergeSort(String prefix, int[] arr, int lo, int hi)
        {
            Console.WriteLine(prefix + "mergeSort(..., " + lo + ", " + hi + ")");
            if (hi - lo <= 1) return;
            int mid = (lo + hi) / 2 + (lo + hi) % 2;
            mergeSort(prefix + "  ", arr, lo, mid);
            mergeSort(prefix + "  ", arr, mid, hi);

            int[] temp = new int[hi - lo];
            int i = lo;
            int j = mid;
            int k = 0;
            while ((i < mid) && (j < hi))
            {
                if (arr[i] < arr[j])
                {
                    temp[k] = arr[i];
                    ++i;
                    ++k;
                }
                else
                {
                    temp[k] = arr[j];
                    ++j;
                    ++k;
                }
            }
            while (i < mid)
            {
                temp[k] = arr[i];
                ++i;
                ++k;
            }
            while (j < hi)
            {
                temp[k] = arr[j];
                ++j;
                ++k;
            }
            for (int l = lo; l < hi; l++)
            {
                arr[l] = temp[l - lo];
            }
            Console.WriteLine("[{0}]", string.Join(", ", arr));
            
        }
        public static void MergeSortIncreas(int[] arr, int lo, int hi)
        {
            if (hi - lo <= 1)
            Console.WriteLine($"hi - lo ({hi} - {lo})  <= 1");
            if (hi - lo <= 1) return;

                int mid = (lo + hi) / 2;
           

            MergeSortIncreas(arr, lo, mid);
            MergeSortIncreas(arr, mid, hi);

            int[] temp = new int[hi - lo];
            int i = lo;
            int j = mid;
            int k = 0;

            while ((i < mid) && (j < hi))
            {
                if (arr[i] < arr[j])
                {
                    temp[k] = arr[i];
                    ++i;
                    ++k;
                }
                else
                {
                    temp[k] = arr[j];
                    j++;
                    k++;
                }
            }
            while (i < mid)
            {
                temp[k] = arr[i];
                ++i;
                ++k;
            }
            while (j < hi)
            {
                temp[k] = arr[j];
                ++j;
                ++k;
            }
            Console.Write("Das Orginale Array -- ");
            PrintArray(arr);
            Console.Write("Das Temporär Array -- ");
            PrintArray(temp);
            for (int l = lo; l < hi; l++)
            {
                arr[l] = temp[l - lo];
                Console.WriteLine($"l ist ={l} und das Orginal Array hat :{arr[l]} an dieser Position");
                Console.WriteLine($"l-lo ist ={l-lo} und das Temp Array hat :{temp[l-lo]} an dieser Position");
            }

            PrintArray(arr);
            
        }


        public static int[] CreateRandomArray(int size)
        {
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(101);
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
        public static void PrintSteps(int[] arr, int target, int swap, int indexTarget, int indexSwap)
        {
            string NORMAL = Console.IsOutputRedirected ? "" : "\x1b[39m";
            string GREEN = Console.IsOutputRedirected ? "" : "\x1b[92m";
            string YELLOW = Console.IsOutputRedirected ? "" : "\x1b[93m";
            string BLUE = Console.IsOutputRedirected ? "" : "\x1b[94m";

            Console.Write("[");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target && i + 1 == indexTarget)
                {
                    Console.Write($"{BLUE}{arr[i]}{NORMAL}");
                }
                else if (arr[i] == swap && i + 1 == indexSwap)
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



        }


    }

}

