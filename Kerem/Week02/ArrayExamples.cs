using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Kerem.Week02
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
            Console.WriteLine("[{0}]", string.Join(", ",arr3));


            Console.WriteLine("===========================");
            Console.WriteLine("RANDOMNUMB FOREACH");
            foreach (int element in arr3)
            {
                Console.Write(element + ", ");
            }


        }



        public static int[] CreateArray(int size)
        {
            int[] arr = new int[size];
            // Hier kommt die Initialisierung
            for (int i = 0; i < arr.Length; ++i)
            {
                arr[i] = 1+ i;
                

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
            int[] arr3  = new int [size];
            
            for( int i = 0; i < arr3.Length; ++i)
            {
                int value = arr3[i];
                arr3[i] = rand.Next(0, 100);
                arr3[3] = 100000;
               
            }
         
            Console.WriteLine();

                
            return arr3;
        }

    }
}
