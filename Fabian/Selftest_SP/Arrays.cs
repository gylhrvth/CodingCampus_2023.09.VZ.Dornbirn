using System.Diagnostics;

namespace Fabian.Selftest_SP
{
    public class Arrays
    {
        public static void Start()
        {
            int[] arr = new int[] { 0, 1, 23, 5, 12, 4, 4, 2, 5, 2, 10 };
            int[] arr2 = new int[] { 123, 19471, 1, 4, 15715, 15, 1, 5, 15, 1, -10, -100 };
            int[] arr3 = new int[] { 478199, 7812973, 12387123, 12, 3, 123, 12, 3, 1, 3, 1, 3, 1, 8, 9, 15, 1, 5, 1, 5, 1, 5, 15, 1, 5, 0 };

            FirstAndLast(arr);
            FirstAndLast(arr2);
            FirstAndLast(arr3);
            Console.WriteLine();

            PrintMyResult("Min", GetMin(arr));
            PrintMyResult("Min", GetMin(arr2));
            PrintMyResult("Min", GetMin(arr3));
            Console.WriteLine();

            PrintMyResult("Max", GetMax(arr));
            PrintMyResult("Max", GetMax(arr2));
            PrintMyResult("Max", GetMax(arr3));
            Console.WriteLine();

            PrintMyResult("Average", GetAvg(arr));
            PrintMyResult("Average", GetAvg(arr2));
            PrintMyResult("Average", GetAvg(arr3));
            Console.WriteLine();

            int[] arr4 = FillArray(10);
            PrintArrayFor(arr4);
            PrintArrayForEach(arr4);
            Console.WriteLine("[{0}]", string.Join(", ", arr4));
            Console.WriteLine();

            int[] arr5 = FillArrayRandom(10);
            BubbleSort(arr5, true);
            PrintArrayFor(arr5);
            int[] arr6 = FillArrayRandom(10);
            BubbleSort(arr6, false);
            PrintArrayFor(arr6);
            Console.WriteLine();


        }

        public static void FirstAndLast(int[] arr)
        {
            Console.WriteLine("First: {0}, Last: {1}", arr[0], arr[^1]);
        }
        public static int GetMin(int[] arr)
        {
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return min;
        }
        public static int GetMax(int[] arr)
        {
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }
        public static double GetAvg(int[] arr)
        {
            double avg = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                avg += arr[i];
            }
            avg /= arr.Length;
            return avg;
        }
        public static void PrintMyResult(string msg, int result)
        {
            Console.WriteLine(msg + ": " +  result);
        }
        public static void PrintMyResult(string msg, double result)
        {
            Console.WriteLine(msg + ": " + result);
        }
        public static int[] FillArray(int length)
        {
            int[] arr = new int[length + 1];

            for (int i = 0; i <= length; i++)
            {
                arr[i] = i;
            }
            return arr;
        }
        public static int[] FillArrayRandom(int length)
        {
            int[] arr = new int[length];
            Random rnd = new();
            for (int i = 0; i < length; i++)
            {
                arr[i] = rnd.Next(101);
            }
            return arr;
        }
        public static void PrintArrayFor(int[] arr)
        {
            bool first = true;
            Console.Write("[");
            for (int i = 0; i < arr.Length; i++)
            {
                if(!first) Console.Write(", " + arr[i]);
                else Console.Write(arr[i]);
                first = false;
            }
            Console.WriteLine("]");
         
        }
        public static void PrintArrayForEach(int[] arr)
        {
            bool first = true;
            Console.Write("[");
            foreach (int i in arr)
            {
                if(!first) Console.Write(", " + arr[i]);
                else Console.Write(arr[i]);
                first = false;
            }
            Console.WriteLine("]");
        }
        public static int[] BubbleSort(int[] arr, bool asc)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (asc && arr[j] > arr[j + 1] || !asc && arr[j] < arr[j + 1])
                    {
                        (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                    }                   
                }
            }
            return arr;
        }
    }
}
