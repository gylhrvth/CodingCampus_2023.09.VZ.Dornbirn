using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ali.Week02
{
    internal class Arrays
    {
        public static Random rand = new Random();
        public static void Start()
        {
            Console.WriteLine("Aufgabe 1: Number Array");
            int[] arr = CreateArray(5);
            PrintAnArray(arr);

            int[] arr2 = CreateArray2(5);
            PrintAnArray(arr2);
            Console.WriteLine("");

            Console.WriteLine("Aufgabe 2: Copy Array");
            int[] orginal = OriginalArray(5);
            Console.WriteLine("Original");
            Console.WriteLine("[{0}]", string.Join(", ", OriginalArray(5)));

            Console.WriteLine("Copy");
            Console.WriteLine("[{0}]", string.Join(", ", MakeACopy(orginal)));
            Console.WriteLine("");

            Console.WriteLine("Aufgabe 3: Random Numer Array");
            Console.WriteLine("[{0}]", string.Join(", ", ArrayRandom(10)));

            int[] random1 = new int[10];
            foreach (int element in random1)
            {
                Console.Write(element+ " ");
            }


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
            for (int i = 0; i < arr.Length; ++i)
            {
                arr[i] = 1 + i;
            }

            return arr;
        }
        public static int[] CreateArray2(int size)
        {
            int[] arr2 = new int[size];
            for (int i = 0; i < arr2.Length; ++i)
            {
                arr2[i] = arr2.Length - i;
            }
            return arr2;
        }



        /*      public static void prtintStartArray()
              {
                  int[] arr = {1, 2, 3, 4, 5, 6, 7, 8, 9};





                  int[] arr2 = { 9, 8, 7, 6, 5, 4, 3, 2, 1 };

                  Console.WriteLine(arr2);

                  for (int j = 0;j < arr2.Length; ++j)
                  {
                      Console.WriteLine("{0}.= {1}", j, arr2[j]);


                  }
        */
        //public static int[] makeAcopy(int[] original)
        //{
        //    PrintAnArray(original);

        //    return original;

        //}

        public static int[] OriginalArray(int size)
        {
            int[] orginal = new int[size];

            for (int i = 0; i < orginal.Length; i++)
            {
                orginal[i] = i + 1;
            }
            return orginal;

        }

        public static int[] MakeACopy(int[] orginal)
        {
            int[] copy = new int[orginal.Length];

            for (int i = 0; i < orginal.Length; i++)
            {
                copy[i] = orginal[i];
            }
            return copy;

        }








        public static int[] ArrayRandom(int size)

        {

            int[] random1 = new int[size];
            for (int i = 0; i < random1.Length; i++)
            {
                random1[i] = rand.Next(0, 101);
            }
            return random1;
            



        }



    }




}


