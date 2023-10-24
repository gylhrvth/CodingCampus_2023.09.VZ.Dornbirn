using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Hassan.Week03
{
    public class Arrays
    {
        public static void Start()
        {

            int[] array1 = CreateArray(10);
            Console.WriteLine("Array mit aufsteigenden Werten:");
            foreach (int element in array1)
            {
                Console.Write(element + " ");
            }

            Console.WriteLine();

            int[] copiedArray = MakeACopy(array1);

            Console.WriteLine("Kopiertes Array:");
            foreach (int element in copiedArray)
            {
                Console.Write(element + " ");
            }

            Console.WriteLine();

            // Ändere das ursprüngliche Array
            array1[0] = 100;

            Console.WriteLine("Ursprüngliches Array nach der Änderung:");
            foreach (int element in array1)
            {
                Console.Write(element + " ");
            }

            Console.WriteLine();

            Console.WriteLine("Kopiertes Array nach der Änderung des Originals:");
            foreach (int element in copiedArray)
            {
                Console.Write(element + " ");
            }
        }
    

        public static int[] CreateArray(int size)
        {
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = i + 1;
            }
            return array;
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


    }

}
