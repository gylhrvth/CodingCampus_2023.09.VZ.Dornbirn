using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Kerem.Week03
{
    internal class ArrayExamples
    {
        public static Random rand = new Random();
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
            foreach( int element in arr4)
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
            for( int i = 0; i< arr4.Length; ++i)
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
            foreach( int element in arr3)
            {
                sum += element;
            }

            return sum;
        }

    }
    
}
