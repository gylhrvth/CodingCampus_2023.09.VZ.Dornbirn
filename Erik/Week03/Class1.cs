using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Erik.Week03
{
    public class ArrayLists
    {

        public static void StartArrayLists()
        {

            //CreateArray(10);
            //Console.WriteLine("---------------------------");
            //CreateArray2(10);
            finalCopyMethode();




        }

        public static int[] CreateArray(int size)
        {
            int[] arr = new int[size];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + 1;
                //Console.WriteLine("{0}: {0}", i);
            }
            return arr;
        }

        public static void CreateArray2(int size)
        {
            int[] arry02 = new int[size];

            for (int i = size; i > 0; i--)
            {
                arry02[i - 1] = size;
                Console.Write("{0} : {0}", i);
            }
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

            Console.WriteLine("Original");
            int[] arr = CreateArray(10);

            foreach (int elements in arr)
            {
                Console.Write(elements + " ");
            }

            Console.WriteLine();
            Console.WriteLine("---------------------------");
            Console.WriteLine("Copy");
            int[] copy = makeACopy(arr);
            foreach (int elements in copy)
            {
                Console.Write(elements + " ");
            }

            Console.WriteLine();
            Console.WriteLine("---------------------------");
            Console.WriteLine("Änderung original");
            arr[3] = 133;
            foreach (int elements in arr)
            {
                Console.Write(elements + " ");
            }
            Console.WriteLine();
            Console.WriteLine("---------------------------");
            Console.WriteLine("Änderung Copy");
            foreach (int elements in copy)
            {
                Console.Write(elements + " ");
            }

        }
    }
}



