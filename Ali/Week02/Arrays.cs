using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Ali.Week02
{
    internal class Arrays
    {
        public static void Start()
        {
            Console.WriteLine("Aufgabe 1: Number Array");
            int[] arr = CreateArray(5);
            PrintAnArray(arr);
        }


        public static void PrintAnArray(int[] arr)
        {
            Console.WriteLine("[{0}]", string.Join(", ", arr));
 /*
           for (int i = 0; i < arr.Length; ++i)
            {
                Console.WriteLine("{0}. = {1}", i, arr[i]);
            }
 */
        }

        public static int[] CreateArray(int size)
        {
            int[] arr = new int[size];

            return arr;
        }



        public static void prtintStartArray()
        {
            int[] arr = {1, 2, 3, 4, 5, 6, 7, 8, 9};

            
            


            int[] arr2 = { 9, 8, 7, 6, 5, 4, 3, 2, 1 };

            Console.WriteLine(arr2);

            for (int j = 0;j < arr2.Length; ++j)
            {
                Console.WriteLine("{0}.= {1}", j, arr2[j]);


            }

                        
        }
        public static void printStartArrayCopy()
        {

        }

    }

}
