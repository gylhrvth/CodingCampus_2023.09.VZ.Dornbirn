using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandro.Week03.SortAlgos
{
    internal class BubbleSort
    {
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

        static Random random = new Random();

        public static void Start()
        {
            
            int[] randomArray1 = CreateRandomArray(10);
            Console.WriteLine($"{UNDERLINE}Bubble Sort Action{NOUNDERLINE} \n");
            Console.WriteLine($"{UNDERLINE}Increasing{NOUNDERLINE}");
            BubbleSortIncreas(randomArray1);
            Console.WriteLine(" ");
            int[] randomArray2 = CreateRandomArray(10);
            Console.WriteLine($"{UNDERLINE}Decreasing{NOUNDERLINE}");
            BubbleSortDecreas(randomArray2);
            Console.WriteLine(" ");


        }
        public static int[] BubbleSortIncreas(int[] arr)
        {
            int stepCount = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {

                    if (arr[j] > arr[j + 1])
                    {
                        Console.Write($"Round ({i}) Step {stepCount,2:00}.) ");
                        PrintSteps(arr, arr[j + 1], arr[j],i+1);
                        Console.WriteLine($" -- Die Zahl {arr[j]} ist größer als {arr[j + 1]}, es wird geswaped");
                        int temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;

                        stepCount++;
                    }
                }
            }
            Console.Write($"Sortiert! ");
            PrintArray(arr);
            return arr;
        }
        public static int[] BubbleSortDecreas(int[] arr)
        {
            int stepCount = 1;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        Console.Write($"Round ({i}) Step {stepCount,2:00}.) ");
                        PrintSteps(arr, arr[j+1], arr[j],i+1);
                        Console.WriteLine($" -- Die Zahl {arr[j]} ist kleiner als {arr[j +1]}, es wird geswaped");
                       
                        int temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;

                        stepCount++;
                    }
                }
            }
            Console.Write("Sortiert! ");
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

        public static void PrintSteps(int[] arr, int target, int swap,int round)
        {

            Console.Write("[");
            for (int i = 0; i < arr.Length; i++)
            {
                int printgreen = (arr.Length) - round;

                if (i > printgreen) {
                    Console.Write($"{GREEN}{arr[i]}{NORMAL}");
                }

                else if (arr[i] == target)
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
          


        }
    }
}
