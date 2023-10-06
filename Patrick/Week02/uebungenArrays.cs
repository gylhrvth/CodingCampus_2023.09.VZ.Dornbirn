using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week02
{
    internal class uebungenArrays
    {
        public static void start()
        {
            //createArrayIncrease(10);
            Console.WriteLine("Increase");
            printArray(createArrayIncrease(10));
            Console.WriteLine("------------------");

            Console.WriteLine("Decrease");
            printArray(createArrayDecrease(10));
            Console.WriteLine("------------------");


        }

        public static int[] createArrayIncrease(int count)
        {
            int[] array = new int[count];


            for (int x = 0; x < count; x++)
            {
                array[x] = x + 1;
                // Console.WriteLine(array[x]);
            }

            return array;
        }


        public static int[] createArrayDecrease(int count)
        {
            int[] array = new int[count];


            for (int x = 0; x < count; x++)
            {
                array[x] = count - x;
                // Console.WriteLine(array[x]);
            }


            return array;
        }


        public static void printArray(int[] array)
        {
            /*
            for (int x = 0; x < array.Length; x++)
            {
                Console.WriteLine(array[x]);
            }
            */
            Console.WriteLine("[{0}]", string.Join(", ", array));
        }




    }
}
