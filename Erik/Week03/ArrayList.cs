using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Erik.Week03
{
    public class ArrayLists
    {
        public static Random rand = new Random();
        public static void StartArrayLists()
        {

            //CreateArray(30);
            //Console.WriteLine("---------------------------");
            //int[] arr2 = CreateArray2(10);
            //PrintArray(arr2);
            //finalCopyMethode();
            //int[] arr = CreateRandomArray(10);
            //Console.WriteLine("[{0}]", string.Join(", ", arr));
            //PrintArray(arr);
            //Console.WriteLine();

            //ArrayPrintYourNumber(5, 20);
            //ArrayCrazyRange(20, -50, 50);

            //Crazy Range
            int[] arr = CreateRandomArray(20, 1, 100);
            PrintArray(arr);
            //PrintArrayWithIndex(arr);
            //Console.WriteLine(CountTheNumbers(arr)+ " Numbers are bigger then 30!");
            //Console.WriteLine("The Sum of the Numbers: " + ArraySumOfNumbers(7, 1, 100));
            //Console.WriteLine("The min Number: " + Minimum(arr));
            //Console.WriteLine("The min Number: " + Minimum(new double[] { 1.0, 0.5, 3.2 }));

            Console.WriteLine("The max Number: " + Maximum(arr));


            Console.WriteLine("Durchschnitt ist: " + Average(arr));


        }

        public static void PrintArrayWithIndex(int[] arr)
        {
            Console.Write("[");
            for (int i = 0; i < arr.Length; i++)
            {
                if (i > 0)
                {
                    Console.Write(", ");
                }
                Console.Write(arr[i]);
            }
            Console.WriteLine("]");
        }

        public static void PrintArray(int[] arr)
        {
            Console.Write("[");
            bool firstElement = true;
            foreach (int elements in arr)
            {
                if (!firstElement)
                {
                    Console.Write(", ");
                }
                Console.Write(elements);
                firstElement = false;
            }
            Console.WriteLine("]");
        }

        public static int[] CreateArray(int size)
        {
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + 1;
            }
            return arr;
        }

        public static int[] CreateArray2(int size)
        {
            int[] arry02 = new int[size];
            for (int i = 0; i < arry02.Length; i++)
            {
                arry02[i] = size - i;
            }
            return arry02;
        }

        public static int[] makeACopy(int[] original)
        {
            int[] arr = new int[original.Length];
            for (int i = 0; i < original.Length; i++)
            {
                arr[i] = original[i];
            }
            return arr;
        }

        public static void finalCopyMethode()
        {
            Console.Write("{0,-20} : ", "Original");
            int[] arr = CreateArray(10);
            PrintArray(arr);
            Console.Write("{0,-20} : ", "Copy");
            int[] copy = makeACopy(arr);
            PrintArray(copy);

            Console.WriteLine("---------------------------");
            Console.Write("{0,-20} : ", "Änderung original");
            arr[3] = 133;
            PrintArray(arr);

            Console.Write("{0,-20} : ", "Änderung Copy");
            PrintArray(copy);
        }

        public static int[] CreateRandomArray(int size, int min = 0, int max = 500)
        {
            int[] arr = new int[size];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(min, max);
            }
            return arr;
        }


        public static int CountTheNumbers(int[] arr)
        {
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 30)
                {
                    counter++;
                }
            }
            return counter;
        }


        public static void ArrayPrintYourNumber(int numberToChange, int size)
        {
            int[] yourNumber = CreateRandomArray(size);
            Console.WriteLine("Random Number Original: ");
            PrintArray(yourNumber);

            for (int i = 0; i < size; i += numberToChange)
            {
                Console.Write(yourNumber[i] + " ");
            }
        }

        public static void ArrayCrazyRange(int size, int min, int max)
        {
            int[] numberRange = CreateRandomArray(size, min, max);
            PrintArray(numberRange);
        }

        public static int ArraySumOfNumbers(int size, int min, int max)
        {
            int[] numberRange = CreateRandomArray(size, min, max);
            PrintArray(numberRange);
            int theSum = Int32.MaxValue;
            for (int i = 0; i < numberRange.Length; i++)
            {
                theSum = theSum + numberRange[i];
            }
            return theSum;
        }

        public static int ArrayMin(int size, int min, int max)
        {
            int[] numberRange = CreateRandomArray(size, min, max);
            PrintArray(numberRange);
            int theMinOfNumbers = numberRange[size / 2];

            for (int i = 0; i < numberRange.Length; i++)
            {
                if (numberRange[i] < theMinOfNumbers && numberRange[i] < theMinOfNumbers)
                {
                    theMinOfNumbers = numberRange[i];
                }
            }
            return theMinOfNumbers;
        }

        public static int Minimum(int[] arr)
        {
            int theMinOfNumbers = Int32.MaxValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < theMinOfNumbers)
                {
                    theMinOfNumbers = arr[i];
                }
            }
            return theMinOfNumbers;
        }


        public static double Minimum(double[] arr)
        {
            return Double.MaxValue;
        }

        public static int Maximum(int[] arr)
        {
            int theMaxofNumbers = Int32.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > theMaxofNumbers)
                {
                    theMaxofNumbers = arr[i];
                }
            }
            return theMaxofNumbers;
        }

        public static double Average(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return (double)sum / arr.Length;
        }
    }
}
