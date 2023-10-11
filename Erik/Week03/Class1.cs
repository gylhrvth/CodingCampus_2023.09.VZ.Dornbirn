using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
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
            int[] arr2 = CreateArray2(10);
            PrintArray(arr2);

            //finalCopyMethode();
            
            
            int[] arr = CreateRandomArray(10);
            Console.WriteLine("[{0}]", string.Join(", ", arr));
            PrintArray(arr);




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

        public static int[] CreateRandomArray(int size)
        {
            int[] arr = new int[size];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(100);                
            }
            return arr;
        }
    }
}



