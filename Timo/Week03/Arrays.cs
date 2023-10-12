﻿using System;
using System.Drawing;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Threading.Channels;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Timo.Week03
{
    public class Arrays
    {
        public static Random random = new Random();

        public static void Start()
        {

            //Console.Beep(2000, 700);
            //Aufgabe1.1: Number Array Aufwärts
            Console.WriteLine("\nAufgabe1.1: Number Array");
            PrintArrayAndIndex(CreateArrayUp(15));

            //Aufgabe1.2: Number Array Abwärts
            Console.WriteLine("\nAufgabe1.2: Number Array");
            PrintArrayAndIndex(CreateArrayDown(19));

            Console.WriteLine("=======================================");

            //Aufgabe2 Kopie:

            int[] testArr = CreateArrayUp(5);
            int[] copyArr = MakeACopy(testArr); // Hier kommt die Kopie
            Console.WriteLine("Original:"); Console.WriteLine("[{0}]", string.Join(", ", testArr));
            Console.WriteLine("Kopie:"); Console.WriteLine("[{0}]", string.Join(", ", copyArr));
            Console.WriteLine("- - - - - - - -");
            testArr[0] = 99;
            Console.WriteLine("Original neu:"); Console.WriteLine("[{0}]", string.Join(", ", testArr));
            Console.WriteLine("Kopie:"); Console.WriteLine("[{0}]", string.Join(", ", copyArr));

            Console.WriteLine("=======================================");

            //Aufgabe3.1 Random foreach
            Console.WriteLine("\nAufgabe3.1: Random Number Array");
            int[] arr = Random(5, 0, 100);

            //Aufgabe3.2 Random for
            Console.WriteLine("\nAufgabe3.2: Random Number Array");
            int[] arr2 = RandomFor(10, 1, 100);
            PrintString(arr2);

            //Aufgabe3.3 Den zweiten, fünften und zehnten Wert des Arrays ausgeben
            Console.WriteLine("\nAufgabe3.3: ausgewählte Werte");
            int[] speicher = { 2, 5, 10, 11 };
            PrintRandomSpezial(arr2, new int[] { 16, 5, 3, 1});                     //Speicher is for storing the values i want to check

            //Aufgabe3.4 jeder zweite Wert
            Console.WriteLine("\nAufgabe3.4: jeder zweite Wert");
            PrintRandomGeradeUngerade(arr2, 1);                     //firstInt start of the count -> if firstInt=0 1st, 3rd, 5th... position, if firstInt=1 2nd, 4th, 6th... position

            Console.WriteLine("=======================================");

            //Aufgabe 4
            Console.WriteLine("\nAufgabe 4: Random Number Array Crazy Range");
            int[] crazy = Random(5, -50, 50);

            Console.WriteLine("=======================================");

            //Aufgabe5 zählen wenn bestimmte Größe
            Console.WriteLine("\nAufgabe 5: Random Number Array Zählen");
            int count = ArrayCount(RandomFor(15, 1, 100), 30);
            PrintArrayCount(count);

            Console.WriteLine("=======================================");

            //Aufgabe6 Summe des Arrays
            Console.WriteLine("\nAufgabe 6: Random Number Array Summe");
            int sum = ArraySum(RandomFor(10, 1, 100));
            PrintArraySum(sum);

            Console.WriteLine("=======================================");


            //Aufgabe7 Min, Max, Avg
            Console.WriteLine("\nAufgabe 7: Random Number Array Min/Max/Avg");
            int[] Array = {}; //RandomFor(20, 1, 100);
            int min = Minimum(Array);
            int max = Maximum(Array);
            int avg = Average(Array);
            int indexMin = IndexMinimum(Array);
            int indexMax = IndexMaximum(Array);
            PrintString(Array);
            Console.WriteLine("Minimum: {0} - am Index: {3}\nMaximum: {1} - am Index: {4}\nAverage: {2}", min, max, avg, indexMin, indexMax);

            Console.WriteLine("=======================================");

            //Aufgabe8 Bubblesort
            Console.WriteLine("\nAufgabe 8: Bubblesort mit Zahlen");
            int[] testBubble = RandomFor(20, 1, 100);
            PrintString(testBubble);
            PrintString(Bubblesort(testBubble, false));             //use 'true' for ascending sorting, 'false' for descending sorting
            PrintString(Bubblesort(testBubble, true));              //use 'true' for ascending sorting, 'false' for descending sorting

            Console.WriteLine("=======================================");

        }


        //Print Position + Array
        public static void PrintArrayAndIndex(int[] arr)
        {
            for (int i = 0; i < arr.Length; ++i)
            {
                Console.WriteLine("{0}. = {1}", i, arr[i]);
            }
        }

        //Print String
        public static void PrintString(int[] arr2)
        {
            Console.WriteLine("[{0}]", string.Join(", ", arr2));
        }


        //------------------------------------------------------------------------------------------------------------------------------

        //Aufgabe1.1: Number Array Aufwärts
        public static int[] CreateArrayUp(int size)
        {
            int[] arrUp = new int[size];
            for (int i = 0; i < arrUp.Length; i++)
            {
                arrUp[i] = i + 1;
            }
            return arrUp;
        }


        //Aufgabe1.2: Number Array Abwärts
        public static int[] CreateArrayDown(int size)
        {
            int[] arrDown = new int[size];
            int a = arrDown.Length;
            for (int i = 0; i < arrDown.Length; i++)
            {
                arrDown[i] = a;
                a--;
            }
            return arrDown;
        }


        //------------------------------------------------------------------------------------------------------------------------------

        //Aufgabe2: Kopie
        public static int[] MakeACopy(int[] original)
        
        {
            int[] copy = new int[original.Length];
            for (int i = 0; i < original.Length; i++)
            {
                copy[i] = original[i];
            }
            return copy;
        }


        //------------------------------------------------------------------------------------------------------------------------------

        //Aufgabe3.1 Random foreach
        public static int[] Random(int i, int min, int max)
        {

            int[] arr = new int[i];
            foreach (int number in arr)
            {
                int randomNumber = random.Next(min, max);
                arr[number] = randomNumber;
                Console.WriteLine($"{arr[number]} ");
            }
            return arr;
        }
        //ToDo 3.1 print Methode schreiben

        //Aufgabe3.2 Random for
        public static int[] RandomFor(int i, int min, int max)
        {
            int[] arr2 = new int[i];
            for (int number = 0; number < i; number++)
            {
                int randomNumber = random.Next(min, max);
                arr2[number] = randomNumber;
            }
            return arr2;
        }


        //Aufgabe3.3 Den zweiten, fünften und zehnten Wert des Arrays ausgeben
        public static int[] PrintRandomSpezial(int[] arr2, int[] speicher)
        {
            for (int a = 0; a < speicher.Length; a++)
            {
                if (speicher[a] > arr2.Length)
                {
                    Console.WriteLine("Die Stelle {0} darf nicht länger sein als die  Länge ({1}) des Arrays!", speicher[a],arr2.Length);
                }
                else
                {
                    Console.WriteLine(speicher[a] + ". Stelle: " + arr2[speicher[a] - 1]);
                }
            }
            return arr2;
        }

        //Aufgabe3.4 jeder zweite Wert
        public static int[] PrintRandomGeradeUngerade(int[] arr2, int firstInt)
        {
            if (firstInt != 0 && firstInt != 1)
            {
                Console.WriteLine("Bitte geben Sie für 'firstInt' die Zahl 0 oder 1 ein!");
            }
            else
            {
                for (int i = 0; i < arr2.Length; i++)
                {
                    if (i % 2 == firstInt)
                    {
                        Console.WriteLine(arr2[i]);
                    }
                }
            }
            return arr2;
        }

        //------------------------------------------------------------------------------------------------------------------------------

        //Aufgabe4
        //wie bei 3.1

        //------------------------------------------------------------------------------------------------------------------------------

        //Aufgabe5 zählen wenn bestimmte Größe
        public static int ArrayCount(int[] arr, int size)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > size)
                {
                    count++;
                }
            }
            return count;
        }
        //Print 
        public static int PrintArrayCount(int count)
        {
            Console.WriteLine("Anzahl der Werte größer als 30: " + count);
            return count;
        }

        //------------------------------------------------------------------------------------------------------------------------------

        //Aufgabe6 Summe des Arrays
        public static int ArraySum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }
            return sum;
        }
        //Print
        public static int PrintArraySum(int sum)
        {
            Console.WriteLine("Summe aller Zahlen im Array: " + sum);
            return sum;
        }

        //------------------------------------------------------------------------------------------------------------------------------

        //Aufgabe7.1 Min.
        //ToDo 7.1 leeres Array!
        public static int Minimum(int[] arr)
        {
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return min;
        }
        //Print
        public static int PrintMinimum(int min)
        {
            Console.WriteLine("Minimum: " + min);
            return min;
        }

        //Aufgabe7.2 Max.,
        //ToDo 7.2 leeres Array!

        public static int Maximum(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }
        //Print
        public static int PrintMaximum(int max)
        {
            Console.WriteLine("Maximum: " + max);
            return max;
        }

        //Aufgabe7.3 Avg
        //ToDo 7.3 Kommazahlen!!! leeres Array!

        public static int Average(int[] arr)
        {
            int avg = ArraySum(arr) / arr.Length;
            return avg;
        }
        //Print
        public static int PrintAveraqge(int avg)
        {
            Console.WriteLine("Average: " + avg);
            return avg;
        }

        //Aufgabe7.4 IndexMin
        //ToDo 7.4 leeres Array!

        public static int IndexMinimum(int[] arr)
        {
            int indexMin = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < arr[indexMin])
                {
                    indexMin = i;
                }
            }
            return indexMin;
        }

        //Aufgabe7.5 IndexMax
        //ToDo 7.5 leeres Array!

        public static int IndexMaximum(int[] arr)
        {
            int indexMax = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > arr[indexMax])
                {
                    indexMax = i;
                }
            }
            return indexMax;
        }
        //------------------------------------------------------------------------------------------------------------------------------

        //Aufgabe 8 Bubblesort
        public static int[] Bubblesort(int[] arr, bool asc)
        {
            if (asc)
            {
                int temp = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    int x = 0;
                    int a = x;
                    while (a < arr.Length)
                    {
                        if (arr[i] < arr[a])
                        {
                            temp = arr[a];
                            arr[a] = arr[i];
                            arr[i] = temp;
                            a = x;
                        }
                        else
                        {
                            a++;
                        }
                    }
                    x++;
                }
            }
            else
            {
                int temp = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    int x = 0;
                    int a = x;
                    while (a < arr.Length)
                    {
                        if (arr[i] > arr[a])
                        {
                            temp = arr[a];
                            arr[a] = arr[i];
                            arr[i] = temp;
                            a = x;
                        }
                        else
                        {
                            a++;
                        }
                    }
                    x++;
                }
            }
            return arr;
        }
    }
}
