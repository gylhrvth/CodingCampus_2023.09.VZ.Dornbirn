using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Michael.Week01
{
    internal class Arrays
    {

        public static void NumberArray()
        {
            int size = ConsoleInputs.IntInput("how big should our array be?");

            int[] myArray = new int[size];
            int[] myArrayReversed = new int[size];

            for (int i = 0; i < size; i++)
            {
                myArray[i] = i + 1;
                myArrayReversed[i] = size - i;
            }

            Console.WriteLine("test");

            Console.WriteLine("normal array:");

            writeIntArray(myArray);

            Console.WriteLine("\n\nreversed array:");

            writeIntArray(myArrayReversed);

        }


        public static void writeIntArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
        }


        public static int[] makeACopy(int[] original)
        {
            return original;
        }


        public static int[] makeACopyAlt(int[] original)
        {
            int[] myArray = new int[original.Length];

            for (int i = 0; i < original.Length; i++)
            {
                myArray[i] = original[i];
            }

            return myArray;

        }




        public static void Array()
        {
            while(true)
            {

                for (int j = 0; j < 20; j++)
                {

                    Methods.printEmptyCirclePythagoras('#', 20, j);

                    System.Threading.Thread.Sleep(1000);
                }
            }
        }

    }
}
