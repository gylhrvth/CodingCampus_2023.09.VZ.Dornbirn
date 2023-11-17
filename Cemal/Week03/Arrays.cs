using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Cemal.Week03
{
    internal class Arrays
    {
        public static Random random = new Random();
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


            //Aufgabe 2
            Console.WriteLine();
            Console.WriteLine("Aufgabe Copy");
            int[] copiedArray = MakeaCopy(myArr);
            foreach (int element in copiedArray)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();


            myArr[0] = 200;

            Console.WriteLine();
            Console.WriteLine("Original (verändert)");
            foreach (int element in myArr)
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


            //Aufgabe 3 . 1 (mit FOREACH)

            int[] myRandom = RandomNumberArray(10);

            Console.WriteLine();
            Console.WriteLine("Random Number Array 1.0");
            Console.Write("[");
            foreach (var element in myRandom)
            {
                Console.Write(element + ", ");
            }
            Console.Write("]");
            Console.WriteLine();

            //Aufgabe 3 . 2 (mit FORi)

            Console.WriteLine();
            Console.WriteLine("Random Number Array 2.0");
            for (int i = 0; i < 1; i++)
            {
                Console.Write("[{0}]", string.Join(", ", myRandom));
            }
            Console.WriteLine();


            //Aufgabe 3.3 (Gib den zweiten, fünften und zehnten Wert)

            Console.WriteLine();
            Console.WriteLine("Random Number Array 3.0");
            Console.Write(myRandom[1] + ", ");
            Console.Write(myRandom[4] + ", ");
            Console.Write(myRandom[9]);
            Console.WriteLine();

            //Aufgabe 3.4 (Gibt jede zweiten Wert)

            Console.WriteLine();
            Console.WriteLine("Random Number Array 4.0");
            for (int i = 0; i < myRandom.Length; i += 2)
            {
                Console.Write(myRandom[i] + ", ");
            }
            Console.WriteLine();


            //Aufgabe 4

            int[] crazy = RandomNumberArrayCrazy(5);

            Console.WriteLine();
            Console.WriteLine("Random Number Array Crazy Range");
            foreach (var element in crazy)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();


            //Aufgabe 5

            Console.WriteLine();
            Console.WriteLine("Random Number Array Zählen");
            int erg = RandomNumberArrayZaehler(5);
            Console.WriteLine(erg);


            //Aufgabe 6
            Console.WriteLine();
            Console.WriteLine("Random Number Array Summe");
            int ergeb = RandomNumberArraySumme(5);
            Console.WriteLine(ergeb);


            //Aufgabe 7

            Console.WriteLine();
            Console.WriteLine(String.Join(" ", myRandom));
            Console.WriteLine();

            Console.WriteLine("Random Number Array Min");
            int min = RandomNumberArrayMin(myRandom);
            Console.WriteLine(min);
            Console.WriteLine();

            Console.WriteLine("Random Number Array Max");
            int max = RandomNumberArrayMax(myRandom);
            Console.WriteLine(max);
            Console.WriteLine();

            Console.WriteLine("Random Number Array Avg");
            double avg = RandomNumberArrayAvg(myRandom);
            Console.WriteLine(avg);
            Console.WriteLine();

            Console.WriteLine("Bubblesort");
            int[] bubbleArray = RandomNumberArray(10);
            PrintMyArray(bubbleArray);
            PrintMyArray(Bubblesort(bubbleArray));

            Console.WriteLine("Wilkommen bei TicTacToe!");
            Console.WriteLine("möchtest du Spieler 'X' oder Spieler 'O' werden");
            Console.ReadLine();




        }
        ///////////////////////////////////////////////////////////////////////////////////

        //public static void PrintMyArray(int[] array) {
        //    int count = 0;
        //    Console.Write("[");
        //    foreach (var element in array)
        //    {
        //        count ++;
        //        if (count == array.Length)
        //        {
        //            Console.Write(element);
        //        }
        //        else
        //        {
        //            Console.Write(element + ", ");
        //        }
        //    }
        //    Console.Write("]");
        //    Console.WriteLine();
        //}

        public static void PrintMyArray(int[] array)
        {
            foreach (var element in array)
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


        public static int[] MakeaCopy(int[] orginal)
        {
            int[] copied = new int[orginal.Length];

            for (int i = 0; i < copied.Length; i++)
            {
                copied[i] = orginal[i];
            }
            return copied;
        }

        public static int[] RandomNumberArray(int size)
        {
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(101);
            }
            return arr;
        }

        public static int[] RandomNumberArrayCrazy(int size)
        {
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(-50, 50);
            }
            return arr;
        }

        public static int RandomNumberArrayZaehler(int arr)
        {
            int[] array = new int[arr];
            int ergebnis = 0;

            for (int i = 1; i < array.Length; i++)
            {
                array[i] = random.Next(1, 101);
                if (array[i] > 30)
                {
                    ergebnis++;
                }
            }
            return ergebnis;
        }

        public static int RandomNumberArraySumme(int arr)
        {
            int[] array = new int[arr];
            int ergebnis = 0;

            for (int i = 1; i < array.Length; i++)
            {
                array[i] = random.Next(1, 101);
                ergebnis += array[i];
            }
            return ergebnis;
        }

        public static int RandomNumberArrayMin(int[] arr)
        {
            int mindestwert = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                mindestwert = Math.Min(mindestwert, arr[i]);
            }
            return mindestwert;
        }

        public static int RandomNumberArrayMax(int[] arr)
        {
            int maximalwert = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                maximalwert = Math.Max(maximalwert, arr[i]);
            }
            return maximalwert;
        }

        public static double RandomNumberArrayAvg(int[] arr)
        {
            double avg = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                avg = arr.Average();
            }
            return avg;
        }

        public static int[] Bubblesort(int[] array)
        {
            
            int temp;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length -1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j+1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }

        public static void TicTacToe()
        {
            
        }
    }
}
