using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Gheorghe.Week03
{
    internal class Arrays03
    {
        public static Random rand = new Random();
        public static void Start()
        {
            /*

            // ARRAY Print
            int[] original = Array(10);
            Console.WriteLine("===================   ");
            Console.WriteLine("Array Print");
            foreach (int element in original)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
            Console.WriteLine("==================");



            //Arry Copy 
            int[] copy = MakeaACopy(original);
            Console.WriteLine("Array Copy");
            foreach (int element in copy)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();

            //Änderung original

            original[3] = 200;
            Console.WriteLine("==================");
            Console.WriteLine("Änderung original");
            foreach (int element in original)
            {
                Console.Write(element + " ");

            }
            Console.WriteLine();



            // Änderung von Copy
            copy[2] = 100;
            Console.WriteLine("======================");
            Console.WriteLine("Änderung Copy");
            foreach (int element in copy)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
            */

            int[] arr = NumberArray(7);
            int[] cp = MakeaACopy(arr);
            //Console.WriteLine("[{0}]", string.Join(", ", arr));
            PrintArray(arr);
            Console.WriteLine("Random Arry original");
            Console.WriteLine("==================");

            PrintArray(cp);
            Console.WriteLine("Copy von Array");


            Console.WriteLine("====================");
            PrintArray(arr);
            arr[0] = 999;
            PrintArray(cp);
            Console.WriteLine("Änderung von Array");



            Console.WriteLine("======================");
            Console.WriteLine("CrazyRangeArray");
            int[] crazyRange = CrazyRangeArray(10);
            PrintArray(crazyRange);

            Console.WriteLine("======================");
            Console.WriteLine("NumbersArray");
            int[] numbersarray = NumberArray(100);
            PrintArray(numbersarray);
            Console.WriteLine("=======================");

            int[] arrayszahl = NummerArray(10);
            PrintNummerArray(arrayszahl);

            Console.WriteLine("Numbers bigger than 30: " + CountNumbersBigger30(arrayszahl));
        }




        public static int[] Array(int size)
        {
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr.Length;
            }
            return arr;
        }
        public static int[] MakeaACopy(int[] original)
        {
            int[] copy = new int[original.Length];
            for (int i = 0; i < copy.Length; i++)
            {
                copy[i] = original[i];
            }
            return copy;
        }




        public static int[] NumberArray(int size)
        {
            int[] randoms = new int[size];
            for (int i = 0; i < randoms.Length; i++)
            {
                randoms[i] = rand.Next(0, 101);
            }
            return randoms;
        }
        public static void PrintArray(int[] arr)
        {
            Console.Write("[");
            bool first = true;
            foreach (int value in arr)
            {
                if (!first)
                {
                    Console.Write(", ");
                }
                Console.Write(value);
                first = false;
            }
            Console.WriteLine("]");
        }




        public static int[] CrazyRangeArray(int size)
        {
            int[] range = new int[size];
            for (int i = 0; i < range.Length; i++)
            {
                range[i] = rand.Next(-50, 50);
            }
            return range;
        }
        public static void PrintCrazyRangeArry(int[] range)
        {
            foreach (int element in range)

            {
                Console.Write(element);
            }
        }






        public static int[] NummerArray(int size)
        {
            int[] Ziffer = new int[size];
            for (int i = 0; i < size; i++)
            {
                Ziffer[i] = rand.Next(1, 100);
            }
            return Ziffer;
        }
        public static void PrintNummerArray(int[] Ziffer)
        {
            foreach (int element in Ziffer)
            {
                Console.Write(element);
                Console.Write(", ");
            }
        }

        public static int CountNumbersBigger30(int[] arr)
        {
            int numbersBiggerThan30 = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 30)
                {
                    numbersBiggerThan30++;
                }
            }
            return numbersBiggerThan30;
        }

    }
}





/*  public static void Start()
  {
   createArraysIncrease(10);
   createArraysDecrease(15);
}

public static int[] createArraysIncrease(int size)
{
int[] array = new int[size];
for (int i = 0; i < size; i++)
{
 array[i] = i;
 Console.WriteLine(array[i]);

}
return array;
}


public static int[] createArraysDecrease(int size)
{
int[] array = new int[size];
for (int i = 0; i < size; i++)
{
 array[i] = size - i;
 Console.WriteLine(array[i]);

}
return array;
}


} */






