using Jovo.Week03;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jovo.Üben.Selbsttest1
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
            ArrayFirstLast(arr);
            ArrayFirstLast(arr2);
            ArrayFirstLast(arr3);
            Console.WriteLine("===================");

            Console.WriteLine("ArrayMin");
            PrintMyResult("Minimum", GetMin(arr2));
            Console.WriteLine("===================");

            Console.WriteLine("ArrayMax");
            PrintMyResult("Max", GetMax(arr2));
            Console.WriteLine("====================");

            Console.WriteLine("ArrayAvg");
            PrintMyResult("Avg", GetAvg(arr3));
            Console.WriteLine("=====================");

            Console.WriteLine("fillArr");
            fillArr(10);
            Console.WriteLine("\n================");

            Console.WriteLine("BubblesortASC");
            int[] arr4 = RandomArray(10);
            PrintMyResultArr(BubblesortASC(arr4));
            Console.WriteLine("====================");

            Console.WriteLine("BubblesortDSC");
            PrintMyResultArr(BubblesortDSC(arr4));
            Console.WriteLine("======================");

            Console.WriteLine("Bubblesortchoice");
            PrintMyResultArr(Bubblesortchoice(arr4, true));


        }



        public static void ArrayFirstLast(int[] arr)
        {
            Console.WriteLine("First:{0}, Last:{1}", arr[0], arr[arr.Length - 1]);


        }
        public static void PrintMyResult(string Solution, int result)
        {
            Console.WriteLine("{0}: {1}", Solution, result);
        }


        public static void PrintMyResultArr(int[] arr)
        {
            Console.Write("[ ");
            for (int i = 0; i < arr.Length; i++)
            {
                if (i == arr.Length - 1)
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
            int Min = int.MaxValue;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < Min)
                {
                    Min = arr[i];
                }

            }
            return Min;

        }


        public static int GetMax(int[] arr)
        {
            int Max = int.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > Max)
                {
                    Max = arr[i];
                }
            }
            return Max;
        }



        public static int GetAvg(int[] arr)
        {
            int avg = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                avg = avg + arr[i];
            }
            return avg / arr.Length;
        }


        public static void fillArr(int number)
        {
            int[] arr = new int[number + 1];


            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i;
                Console.Write(arr[i]);
            }

            Console.WriteLine();

            foreach (int element in arr)
            {
                Console.Write(element);
            }
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

        public static int[] BubblesortASC(int[] arr)
        {
            int length = arr.Length;
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }

                }


            }
            return arr;

        }

        public static int[] BubblesortDSC(int[] arr)
        {
            int length = arr.Length;
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length - 1; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        int temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }

                }


            }
            return arr;

        }



        public static int[] Bubblesortchoice(int[] arr, bool asc)
        {
            int length = arr.Length;
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length - 1; j++)
                {
                    if (asc)
                    {
                        if (arr[j] < arr[j + 1])
                        {
                            int temp = arr[j + 1];
                            arr[j + 1] = arr[j];
                            arr[j] = temp;

                        }
                    }
                    else
                    {
                        if (arr[j] > arr[j + 1])
                        {
                            int temp = arr[j + 1];
                            arr[j + 1] = arr[j];
                            arr[j] = temp;
                        }
                    }
                }
            }
            return arr;
        }

    }
}
