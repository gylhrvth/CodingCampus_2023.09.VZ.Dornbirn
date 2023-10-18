using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Kerem.Week03
{
    internal class ArrayExamples
    {
        public static Random rand = new Random();
        public static int[] arr = RNminmaxavg();

        public static void StartArrayExamples()
        {
            Console.WriteLine("ORIGINAL");
            int[] original = CreateArray(10);
            Console.WriteLine("[{0}]", string.Join(", ", original));



            Console.WriteLine("ARRAY2");
            int[] arr2 = CreateArray2(10);
            Console.WriteLine("[{0}]", string.Join(", ", arr2));




            Console.WriteLine("COPY");
            int[] copy = MakeACopy(original);
            Console.WriteLine("[{0}]", string.Join(", ", copy));



            Console.WriteLine("CHANGEORIGINAL");
            original[0] = 30;
            Console.WriteLine("[{0}]", string.Join(", ", original));
            Console.WriteLine("COPY");
            Console.WriteLine("[{0}]", string.Join(", ", copy));


            Console.WriteLine("===========================");
            Console.WriteLine("RANDOMNUMB");
            int[] arr3 = RandomNumberArray(10);
            Console.WriteLine("[{0}]", string.Join(", ", arr3));


            Console.WriteLine("===========================");
            Console.WriteLine("array in foreach loop");
            foreach (int element in arr3)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"second value = {arr3[1]}");
            Console.WriteLine($"fith value = {arr3[4]}");
            Console.WriteLine($"tenth value = {arr3[9]}");
            Console.WriteLine();
            int[] arr4 = RNCrazyRange(10);
            foreach (int element in arr4)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
            Console.WriteLine("ArrayCount");
            int count = ArrayCount(arr4);
            Console.WriteLine("Es sind " + count + " Zahlen größer als 30");

            Console.WriteLine();
            Console.WriteLine("ArraySum");
            int randomnum = ArraySum(arr3);
            Console.WriteLine("Die Summe lautet = " + randomnum);

            Console.WriteLine();
            Console.WriteLine("RNMMINMAXAVG");
            Console.WriteLine("[{0}]", string.Join(", ", arr));

            Console.WriteLine("smallest number is = " + (Arraymin(arr)));
            Console.WriteLine("biggest number is = " + (Arraymax(arr)));
            Console.WriteLine("average number is = " + (Arrayavg(arr)));
            Console.WriteLine("index of smallest number is = " + (MinIndex(arr)));
            Console.WriteLine("index of biggest number is = " + (MaxIndex(arr)));

            Console.WriteLine("BubbleSortAscending");
            Console.WriteLine("[{0}]", string.Join(", ", SortArrayAscending(arr3)));
            Console.WriteLine();

            Console.WriteLine("BubbleSortDescending");
            Console.WriteLine("[{0}]", string.Join(", ", SortArrayDescending(arr3)));
            Console.WriteLine();

            //Console.WriteLine("BubbleSortConfig");
            //int[] array = RandomNumberArray(20,0,100);


            Console.WriteLine("Array2D");
            //Array2D(2, 3, 4, 1);


        }
        public static int[] CreateArray(int size)
        {
            int[] arr = new int[size];
            // Hier kommt die Initialisierung
            for (int i = 0; i < arr.Length; ++i)
            {
                arr[i] = 1 + i;


            }

            return arr;
        }
        public static int[] CreateArray2(int size)
        {
            int[] arr2 = new int[size];
            // Hier kommt die Initialisierung
            for (int i = 0; i < arr2.Length; ++i)
            {
                arr2[i] = arr2.Length - i;

            }

            return arr2;
        }
        public static int[] MakeACopy(int[] original)
        {
            int[] copy = new int[original.Length];
            for (int i = 0; i < original.Length; i++)
            {
                copy[i] = original[i];
            }
            return copy;
        }
        public static int[] RandomNumberArray(int size)

        {

            int[] arr3 = new int[size];

            //Console.Write("array in for loop");
            for (int i = 0; i < arr3.Length; ++i)
            {
                arr3[i] = rand.Next(0, 100);

            }
            Console.WriteLine();
            Console.WriteLine("array every 2nd value");
            for (int i = 0; i < arr3.Length; i += 2)
            {
                Console.WriteLine($"{i} = {arr3[i]}");
            }


            return arr3;
        }
        public static int[] RNCrazyRange(int size)
        {
            int[] arr4 = new int[size];
            for (int i = 0; i < arr4.Length; ++i)
            {
                arr4[i] = rand.Next(-50, 50);
            }

            return arr4;
        }
        public static int ArrayCount(int[] arr)
        {
            int count = 0;
            foreach (int i in arr)
            {
                if (i > 30)
                {
                    count++;
                }
            }
            return count;
        }
        public static int ArraySum(int[] arr3)
        {

            int sum = 0;
            foreach (int element in arr3)
            {
                sum += element;
            }

            return sum;
        }
        public static int[] RNminmaxavg()
        {
            int[] arr5 = new int[10];
            for (int i = 0; i < arr5.Length; ++i)
            {

                arr5[i] = rand.Next(1, 101);


            }

            return arr5;
        }
        public static int Arraymin(int[] arr)
        {
            int min = Int32.MaxValue;
            foreach (int element in arr)
            {
                if (element < min)
                {
                    min = element;

                }
            }
            return min;
        }
        public static int Arraymax(int[] arr)
        {
            int max = Int32.MinValue;
            foreach (int element in arr)
            {
                if (element > max)
                {
                    max = element;
                }

            }
            return max;
        }
        public static int ArraySumX(int[] arr)
        {
            int sumx = 0;
            foreach (int element in arr)
            {
                sumx += element;
            }

            return sumx;
        }


        public static double Arrayavg(int[] arr)
        {

            if (arr.Length == 0)
            {
                return 0;

            }
            return ArraySumX(arr) / (double)arr.Length;



        }
        public static int MinIndex(int[] arr)
        {
            int min = Int32.MaxValue;
            int minIndex = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int element = arr[i];

                if (element < min)
                {
                    min = element;
                    minIndex = i;

                }
            }
            return minIndex;
        }
        public static int MaxIndex(int[] arr)
        {
            int max = Int32.MinValue;
            int maxIndex = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int element = arr[i];
                if (element > max)
                {
                    max = element;
                    maxIndex = i;
                }


            }
            return maxIndex;

        }
        public static int[] SortArrayAscending(int[] arr8)
        {
            int a = arr8.Length;
            bool sorted = false;
            while (!sorted)
            {
                sorted = true;
                for (int i = 0; i < a - 1; i++)
                {
                    if (arr8[i] < arr8[i + 1])
                    {
                        int t = arr8[i];
                        arr8[i] = arr8[i + 1];
                        arr8[i + 1] = t;
                        sorted = false;
                    }
                }

            }
            return arr8;
        }
        public static int[] SortArrayDescending(int[] arr7)
        {



            for (int i = 0; i < arr7.Length; i++)
            {
                for (int j = 0; j < arr7.Length - 1; j++)
                {
                    if (arr7[j] > arr7[j + 1])
                    {
                        int temp = arr7[j];
                        arr7[j] = arr7[j + 1];
                        arr7[j + 1] = temp;
                    }


                }


            }
            return arr7;

        }
        public static void SortArrayConfig(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[i])
                    {
                        int temp = array[j];
                        array[j + 1] = array[i];
                        array[i + 1] = temp;
                    }

                }
            }
        }
        //public static int[] Array2D(int[] array)
        //{
            
        //}
    }
}



