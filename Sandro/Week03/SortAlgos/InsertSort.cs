using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandro.Week03.SortAlgos
{
    internal class InsertSort
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
            Console.WriteLine($"{UNDERLINE}Increasing{NOUNDERLINE}");
            InsertSortIncreas(randomArray1);
            Console.WriteLine(" ");
            int[] randomArray2 = CreateRandomArray(10);
            Console.WriteLine($"{UNDERLINE}Decreasing{NOUNDERLINE}");
            InsertSortDecreas(randomArray2);

        }
        public static int[] InsertSortIncreas(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int round = i - 1;
                int step = 1;
                int j = i;

                if (j > 0 && arr[j - 1] > arr[j])
                {
                    while (j > 0 && arr[j - 1] > arr[j])
                    {

                        Console.Write($"Round {round,2:00} / Step {step,2:00}.) ");
                        PrintSteps(arr, arr[j - 1], arr[j], j, j + 1);
                        Console.WriteLine($" -- Number {arr[j - 1]} found on positon {j}, will swap it with {arr[j]} on postion {j + 1}");

                        int temp = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = temp;
                        j = j - 1;
                        step++;
                    }
                }
                else
                {
                    Console.WriteLine($"Round {round,2:00} / Nothing found to swap");
                }

            }
            Console.Write("Totaly sorted Array) ");
            PrintArray(arr);
            return arr;
        }
        public static int[] InsertSortDecreas(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int round = i - 1;
                int step = 1;
                int j = i;

                if (j > 0 && arr[j - 1] < arr[j])
                {
                    while (j > 0 && arr[j - 1] < arr[j])
                    {

                        Console.Write($"Round {round,2:00} / Step {step,2:00}.) ");
                        PrintSteps(arr, arr[j - 1], arr[j], j, j + 1);
                        Console.WriteLine($" -- Number {arr[j - 1]} found on positon {j}, will swap it with {arr[j]} on postion {j + 1}");

                        int temp = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = temp;
                        j = j - 1;
                        step++;
                    }
                }
                else
                {
                    Console.WriteLine($"Round {round,2:00} / Nothing found to swap");
                }

            }
            Console.Write("Totaly sorted Array) ");
            PrintArray(arr);
            return arr;
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

            Console.Write("[");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target && i + 1 == indexTarget)
                {
                    Console.Write($"{BLUE}{arr[i]}{NORMAL}");
                }
                else if (arr[i] == swap && i + 1 == indexSwap)
                {
                    Console.Write($"{MAGENTA}{arr[i]}{NORMAL}");
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
