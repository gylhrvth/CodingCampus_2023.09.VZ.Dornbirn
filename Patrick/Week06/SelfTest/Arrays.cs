using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Patrick.Week06.SelfTest
{
    internal class Arrays
    {
        public static void Start()
        {
            int[] arr = new int[] { 0, 1, 23, 5, 12, 4, 4, 2, 5, 2, 10 };
            int[] arr2 = new int[] { 123, 19471, 1, 4, 15715, 15, 1, 5, 15, 1, -10, -100 };
            int[] arr3 = new int[] { 478199, 7812973, 12387123, 12, 3, 123, 12, 3, 1, 3, 1, 3, 1, 8, 9, 15, 1, 5, 1, 5, 1, 5, 15, 1, 5, 0 };

            //Aufgabe1
            //PrintFirstAndLast(arr);
            //PrintFirstAndLast(arr2);
            //PrintFirstAndLast(arr3);

            //Aufgabe2
            //Console.WriteLine("Maximum in Array1 = " + MaxinArray(arr));
            //Console.WriteLine("Maximum in Array2 = " + MaxinArray(arr2));
            //Console.WriteLine("Maximum in Array3 = " + MaxinArray(arr3));
            //Console.WriteLine("Minimum in Array1 = " + MinInArray(arr));
            //Console.WriteLine("Minimum in Array2 = " + MinInArray(arr2));
            //Console.WriteLine("Minimum in Array3 = " + MinInArray(arr3));
            //Console.WriteLine("Durchschnitt in Array1 = " + AvgArray(arr));
            //Console.WriteLine("Durchschnitt in Array2 = " + AvgArray(arr2));
            //Console.WriteLine("Durchscnitt in Array3 = " + AvgArray(arr3));

            //Aufgabe3
            //int size = 11;
            //int[] array1 = CreateArray(size);
            //PrintArrayFor(CreateArray(size));
            //PrintArrayForEach(CreateArray(size));
            //Console.WriteLine("[{0}]", string.Join(", ", array1));

            //Aufgabe4
            PrintArrayFor(BubbleSortAscDescArray(arr2, true));
            PrintArrayFor(BubbleSortAscDescArray(arr2, false));

        }


        public static void PrintFirstAndLast(int[] arr)
        {
            string first = arr[0].ToString();
            string last = arr[arr.Length - 1].ToString();

            Console.WriteLine($"First: {first}, Last: {last}");
        }

        public static int MaxinArray(int[] arr)
        {
            int max = int.MinValue;
            for (int i = 0; i< arr.Length; i++)
            {
                if(arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }

        public static int MinInArray(int[] arr)
        {
            int min = int.MaxValue;
            for(int i = 0; i< arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return min;
        }

        public static int AvgArray(int[] arr)
        {
            int avg = 0;
            for(int i = 0;i< arr.Length; i++)
            {
                avg += arr[i];
            }
            return avg / arr.Length;
        }

        public static int[] CreateArray(int value)
        {
            int[] array = new int[value];
            for(int i = 0; i < value; i++)
            {
                array[i] = i;
            }
            return array;
        }

        public static void PrintArrayFor(int[] arr)
        {
            Console.Write("[");
            for(int i = 0; i < arr.Length; i++)
            {
                if (i == arr.Length - 1)
                {
                    Console.Write(arr[i]);
                }
                else
                {
                    Console.Write(arr[i] + ", ");
                }
            }
            Console.WriteLine("]");
        }

        public static void PrintArrayForEach(int[] arr)
        {
            Console.Write("[");
            foreach(int element in arr)
            {
                Console.Write(element + ", ");
            }
            Console.WriteLine("]");
        }

        public static int[] BubbleSortAscDescArray(int[] arr, bool falseTrue)
        {
            if(falseTrue == true)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr.Length - i - 1; j++)
                    {
                        if (arr[j] > arr[j + 1])
                        {
                            int tempMemory = arr[j];
                            arr[j] = arr[j + 1];
                            arr[j + 1] = tempMemory;
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr.Length - i - 1; j++)
                    {
                        if (arr[j] < arr[j + 1])
                        {
                            int tempMemory = arr[j];
                            arr[j] = arr[j + 1];
                            arr[j + 1] = tempMemory;
                        }
                    }
                }
            }
            return arr;

        }
    }

}
