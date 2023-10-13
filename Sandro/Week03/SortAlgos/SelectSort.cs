using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandro.Week03.SortAlgos
{
    internal class SelectSort { 

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
        Console.WriteLine($"{UNDERLINE}Selected Sort Action{NOUNDERLINE} \n");
        Console.WriteLine($"{UNDERLINE}Increasing{NOUNDERLINE}");
        SelectSortIncreas(randomArray1);
        Console.WriteLine(" ");
        int[] randomArray2 = CreateRandomArray(10);
        Console.WriteLine($"{UNDERLINE}Decreasing{NOUNDERLINE}");
        SelectSortDecreas(randomArray2);

    }
    public static int[] SelectSortIncreas(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            int min = i;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if ((arr[j] < arr[min]))
                {
                    min = j;
                }
            }
            Console.Write($"Step {i + 1,2:00}.) ");
            PrintSteps(arr, arr[min], arr[i], i);
            Console.WriteLine($" -- Number {arr[min]} found on positon {min + 1}, will swap it with {arr[i]} on postion {i + 1}");
            int temp = arr[i];
            arr[i] = arr[min];
            arr[min] = temp;

        }


        return arr;
    }
    public static int[] SelectSortDecreas(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            int max = i;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if ((arr[j] > arr[max]))
                {
                    max = j;
                }
            }
            Console.Write($"Step {i + 1,2:00}.) ");
            PrintSteps(arr, arr[max], arr[i], i);
            Console.WriteLine($" -- Number {arr[max]} found on positon {max + 1}, will swap it with {arr[i]} on postion {i + 1}");
            int temp = arr[i];
            arr[i] = arr[max];
            arr[max] = temp;

        }


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
    public static void PrintSteps(int[] arr, int target, int swap, int index)
    {

        Console.Write("[");
        for (int i = 0; i < arr.Length; i++)
        {
            if (index - 1 >= i)
            {
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
