using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Timo.Selbsttest_Strukto
{
    internal class Arrays
    {
        public static void Start()
        {
            int[] arr = new int[] { 0, 1, 23, 5, 12, 4, 4, 2, 5, 2, 10 };

            int[] arr2 = new int[] { 123, 19471, 1, 4, 15715, 15, 1, 5, 15, 1, -10, -100 };

            int[] arr3 = new int[] { 478199, 7812973, 12387123, 12, 3, 123, 12, 3, 1, 3, 1, 3, 1, 8, 9, 15, 1, 5, 1, 5, 1, 5, 15, 1, 5, 0 };


            //Aufgabe 1)
            Console.WriteLine("Aufgabe 1: \n");
            Console.WriteLine(FirstAndLast(arr));
            Console.WriteLine(FirstAndLast(arr2));
            Console.WriteLine(FirstAndLast(arr3));
            Console.WriteLine("==========================");

            //Aufgabe 2)
            Console.WriteLine("Aufgabe 2: \n");
            Console.WriteLine("arr");
            PrintMyResult("Minimum", GetMin(arr));
            PrintMyResult("Maximum", GetMax(arr));
            PrintMyResult("Durchschnitt", GetAvg(arr));
            Console.WriteLine("\narr2");
            PrintMyResult("Minimum", GetMin(arr2));
            PrintMyResult("Maximum", GetMax(arr2));
            PrintMyResult("Durchschnitt", GetAvg(arr2));
            Console.WriteLine("\narr3");
            PrintMyResult("Minimum", GetMin(arr3));
            PrintMyResult("Maximum", GetMax(arr3));
            PrintMyResult("Durchschnitt", GetAvg(arr3));
            Console.WriteLine("==========================");

            //Aufgabe 3)
            Console.WriteLine("Aufgabe 3: \n");
            Console.WriteLine("For");
            PrintFor(Array3(15));
            Console.WriteLine("ForEach");
            PrintForEach(Array3(-18));
            Console.WriteLine("String join");
            PrintString(Array3(10));
            Console.WriteLine("==========================");

            //Aufgabe 4)
            Console.WriteLine("Aufgabe 4: \n");
            int[] arry = RandommArr(0, 100, 15);
            PrintString(arry);
            PrintString(Bubble(arry, true));
            Console.WriteLine("==========================");
        }


        //Aufgabe1:
        public static string FirstAndLast(int[] arr)
        {
            return "First: " + First(arr) + ", Last: " + Last(arr);
        }

        public static int First(int[] arr)
        {
            return arr[0];
        }

        public static int Last(int[] arr)
        {
            return arr[arr.Length - 1];
        }

        //-----------------------------------------------------------------------------------------------------------


        //Aufgabe 2:
        public static void PrintMyResult(string operation, double ergebnis)
        {
            //return operation + ": " + ergebnis;
            Console.WriteLine("{0}: {1 :N2}", operation, ergebnis);
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
            double avg = Sum(arr) * 1.00 / arr.Length;
            return avg;
        }

        public static int Sum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }

        //-----------------------------------------------------------------------------------------------------------


        //Aufgabe 3:
        public static int[] Array3(int number)
        {
            if (number >= 0)
            {
                int[] arr = new int[number + 1];
                for (int i = 0; i <= number; i++)
                {
                    arr[i] = i;
                }
                return arr;
            }
            else
            {
                int[] arr = new int[number * (-1) + 1];
                for (int i = 0; i <= number * -1; i++)
                {
                    arr[i] = -1 * i;
                }
                return arr;
            }
        }

        public static void PrintFor(int[] arr)
        {
            for (int i = 0; i < arr.Length; ++i)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        public static void PrintForEach(int[] arr)
        {
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        public static void PrintString(int[] arr)
        {
            Console.WriteLine("[{0}]", string.Join(", ", arr));
        }

        //-----------------------------------------------------------------------------------------------------------


        //Aufgabe 4:
        public static int[] RandommArr(int min, int max, int counts)
        {
            int[] arr = new int[counts];
            Random random = new Random();
            for (int i = 0; i < counts; i++)
            {
                arr[i] = random.Next(min, max + 1);
            }
            return arr;
        }

        public static int[] Bubble(int[] arr, bool asc)
        {
            if (asc)
            {
                for (int i = arr.Length; i > 1; i--)
                {
                    for (int a = 0; a < i - 1; a++)
                    {
                        if (arr[a] > arr[a + 1])
                        {
                            int temp = arr[a + 1];
                            arr[a + 1] = arr[a];
                            arr[a] = temp;
                        }
                    }
                }
            }
            else
            {
                for (int i = arr.Length; i > 1; i--)
                {
                    for (int a = 0; a < i - 1; a++)
                    {
                        if (arr[a] < arr[a + 1])
                        {
                            int temp = arr[a + 1];
                            arr[a + 1] = arr[a];
                            arr[a] = temp;
                        }
                    }
                }
            }
            return arr;
        }

    }
}
