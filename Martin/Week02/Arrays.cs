using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martin.Week02
{
    internal class Arrays
    {
        public static void StartArrays()
        {
            NumberArray();
            ReverseNumberArray();
            //RandomNumberArray();


            int[] Numbers = { 1, 2, 4, 5, 6, 7, 8 };
            int[] Numbers2 = Numbers;

            Console.WriteLine("[{0}]", string.Join(", ", Numbers));
            Console.WriteLine("[{0}]", string.Join(", ", Numbers2));

            Numbers2[0] = 100;
            Console.WriteLine("[{0}]", string.Join(", ", Numbers));
            Console.WriteLine("[{0}]", string.Join(", ", Numbers2));

        }


        // Todo 1: Print Array function
        // Todo 2: public static int[] CreateArray(int size)
        // Todo 3: public static int[] CreateArray2(int size)   ... initialisiert mit absteigenden Werten

        // Todo 4: Problem mit Copy


        //Aufgabe: Number Array

        public static void NumberArray()
        {
            int[] Numbers = new int[10];

            int[] ReverseNumbers = new int[10];


            for (int i = 1; i < Numbers.Length; i++)
            {
                Numbers[i] = i;
                Console.WriteLine(Numbers[i]); // zählt alle Numbers in ReverseNumbers auf
            }
        }


        public static void ReverseNumberArray()
        {

            int[] ReverseNumbers = new int[10];


            for (int i = 1; i < ReverseNumbers.Length; i++)
            {
                ReverseNumbers[i] = i;
                Console.WriteLine(ReverseNumbers[i]); // zählt alle Numbers in ReverseNumbers auf
            }
        }

        public static void PrintArrayfunction()
        {

        }

   


        //Aufgabe: Kopie

        public static int[] makeACopy(int[] original)
         {
            Console.WriteLine(original[1]);
            return original;
         }

        //Random Number Array

        public static void RandomNumberArray()
        {
            Random random = new Random();

            int[] arr2 = new int[10]; //hat 10 freie plätze

            /* for (int i = 0; i < arr2.Length ;i++) // arr2.Length == so viele durchgänge wie viele plätze verfügbar sind also 10
             {
                arr2[i] = random.Next(1,100); // eine zahl genarieren von 1-100
                Console.WriteLine(i+ " = " +arr2[i]);
             }
            */
            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = random.Next(1, 100);
            }


            foreach (int value in arr2) //für jeden nummer in dem array
            {
                Console.Write("{0} ", value);
            }
            Console.WriteLine();

            Console.WriteLine("[{0}]", string.Join(", ", arr2));

        }
        

        public static void Test()
        {
            int[] arr = { 10, 12, 15, 66 };

            Console.WriteLine(arr);
            for (int i = 0; i < arr.Length; ++i)
            {
                Console.WriteLine("{0}. = {1}", i, arr[i]);
            }
            Console.WriteLine("===================");

            arr[0] = 100;
            for (int i = 0; i < arr.Length; ++i)
            {
                Console.WriteLine("{0}. = {1}", i, arr[i]);
            }


            Random rand = new Random();
            int[] arr2 = new int[10];
            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = rand.Next(10, 20);
            }

            Console.WriteLine("===================");
            for (int i = 0; i < arr2.Length; ++i)
            {
                Console.WriteLine("{0}. = {1}", i, arr2[i]);
            }



            Console.WriteLine(arr[4]);
        }
    }
}
