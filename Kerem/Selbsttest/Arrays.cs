using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kerem.Selbsttest
{
    internal class Arrays
    {
        public static Random rand = new Random();
        public static void Start()
        {
            int[] arr = new int[] { 0, 1, 23, 5, 12, 4, 4, 2, 5, 2, 10 };

            int[] arr2 = new int[] { 123, 19471, 1, 4, 15715, 15, 1, 5, 15, 1, -10, -100 };

            int[] arr3 = new int[] { 478199, 7812973, 12387123, 12, 3, 123, 12, 3, 1, 3, 1, 3, 1, 8, 9, 15, 1, 5, 1, 5, 1, 5, 15, 1, 5, 0 };

            Console.WriteLine("First and Last");
            PrintFirstAndLast(arr);
            PrintFirstAndLast(arr2);
            PrintFirstAndLast(arr3);
            Console.WriteLine("========================");

            Console.WriteLine("ArrayMin");
            PrintMyResult("Min", GetMin(arr2));
            Console.WriteLine("========================");

            Console.WriteLine("ArrayMax");
            PrintMyResult("Max", GetMax(arr2));
            Console.WriteLine("========================");

            Console.WriteLine("ArrayAvg");
            PrintMyResult("Avg", GetAvg(arr2));
            Console.WriteLine("========================");

            Console.WriteLine("FillArr");
            int[] arr4 = FillArr(10);
            Console.WriteLine("\n[{0}]", string.Join(", ", arr4));
            Console.WriteLine("========================");

            Console.WriteLine("BubbleSortASC");
            int[] arr5 = RandomArray(10);
            PrintResultArr(BubbleSortASC(arr5));
            Console.WriteLine("========================");

            Console.WriteLine("BubbleSortDSC");
            PrintResultArr(BubbleSortDSC(arr5));
            Console.WriteLine("========================");

            Console.WriteLine("BubbleSortChoice");
            PrintResultArr(BubbleSortChoice(arr5, false));






        }
        public static void PrintFirstAndLast(int[] arr)
        {
            Console.WriteLine("First: {0} Last: {1}", arr[0], arr[arr.Length-1]);
        }
        public static void PrintMyResult(string definition, int result)
        {
            Console.WriteLine("{0} : {1}", definition, result);
        }
        public static void PrintResultArr(int[] arr)
        {
            Console.Write("[");
            for (int i = 0; i < arr.Length; i++)
            {
                if(i == arr.Length - 1)
                {
                    Console.Write("{0} ", arr[i]);
                }
                else
                {
                    Console.Write("{0}, ", arr[i]);
                }
            }
            Console.Write("]");
            Console.WriteLine();
        }
        public static int GetMin(int[] arr)
        {
            int min = int.MaxValue;
            for(int i = 0; i < arr.Length; i++)
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
            int max = int.MinValue;
            for(int i = 0; i < arr.Length ; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }
        public static int GetAvg(int[] arr)
        {
            int avg = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                avg = avg + arr[i];
            }
            return (avg/ arr.Length);
        }
        public static int[] FillArr(int num)
        {
            int[]arr = new int[num+1];

            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = i;
                Console.Write(arr[i]+ " ");
            }
            Console.WriteLine();

            foreach(int element in arr)
            {
                Console.Write(element+ " ");
            }
            return arr;
            
        }
        public static int[] RandomArray(int size)
        {

            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(0, 100);
            }
            return arr;
        }
        public static int[] BubbleSortASC(int[] arr)
        {
            int length = arr.Length;
            for(int i = 0; i < length; i++)
            {
               for(int j = 0; j < length-1; j++)
               {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j+1];
                        arr[j+1] = arr[j];
                        arr[j] = temp;
                    }
               }
            }
            return arr;

        }
        public static int[] BubbleSortDSC(int[] arr)
        {
            int length = arr.Length;
            for(int i = 0; i < length;i++)
            {
                for(int j = 0; j < length - 1; j++)
                {
                    if (arr[j]  < arr[j + 1])
                    {
                        int temp = arr[j+1];
                        arr[(j+1)] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }
        public static int[] BubbleSortChoice(int[] arr, bool asc)
        {
            int length = arr.Length;
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length - 1; j++)
                {
                    if (asc)
                    {
                        if(arr[j] > arr[j + 1])
                        {
                            int temp = arr[j + 1];
                            arr[j + 1] = arr[j];
                            arr[j] = temp;

                        }
                    }
                    else
                    {
                        if (arr[j] < arr[j + 1])
                        {
                            int temp = arr[j + 1];
                            arr[(j + 1)] = arr[j];
                            arr[j] = temp;
                        }

                    }
                }
            }
            return arr;
        }

    }
}
