using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cemal.Week03
{
    internal class Arrays
    {
        public static void StartArray()
        {
            //Aufgabe 1
            Console.WriteLine("Aufgabe Number Array");
            int[] myArr = CreateArray(6);
            Console.WriteLine("[{0}]", string.Join(", ", myArr));
            Console.WriteLine();

            Console.WriteLine("Aufgabe Number Array Rückwärts");
            int[] myArr1 = CreateArray2(6);
            Console.WriteLine("[{0}]", string.Join(", ", myArr1));
            Console.WriteLine();


            //Aufgabe PrintArray
            Console.WriteLine("Aufgabe PrintArray");
            PrintArray(myArr);
            Console.WriteLine();


            //Aufgabe 2
            Console.WriteLine();
            Console.WriteLine("Aufgabe Copy");
            int[] copiedArray = MakeaCopy(myArr);
            foreach (var element in copiedArray)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();


            myArr[0] = 200;


            Console.WriteLine();
            Console.WriteLine("Orginal (verändert)");
            foreach (var element in myArr)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();


            Console.WriteLine();
            Console.WriteLine("Copy (verändert)");
            foreach (var element in copiedArray)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();


        }


        public static int[] CreateArray(int size)
        {
            int[] numbers = new int[size];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i + 1;
            }
            return numbers;
        }

        public static int[] CreateArray2(int size)
        {
            int[] numbers = new int[size];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = size - i;
            }
            return numbers;
        }


        public static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);

            }
        }


        public static int[] MakeaCopy(int[] orginal)
        {
            int[] copied = new int[orginal.Length];

            for (int i = 0;i < copied.Length;i++)
            {
                copied[i] = orginal[i];
            }
            return copied;
        }
    }
}
