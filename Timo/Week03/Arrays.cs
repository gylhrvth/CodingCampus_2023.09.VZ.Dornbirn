using System;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
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
        public static Stopwatch stopwatch = new Stopwatch();
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
            PrintRandomSpezial(arr2, new int[] { 16, -5, 3, 1 });     //Speicher is for storing the values i want to check

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
            int[] Array = RandomFor(19, -100, 100);
            int min = Minimum(Array);
            int max = Maximum(Array);
            double avg = Average(Array);
            int indexMin = IndexMinimum(Array);
            int indexMax = IndexMaximum(Array);
            PrintString(Array);
            if (min == Int32.MaxValue)
            {
                Console.WriteLine("Fehler: Das Array darf nicht leer sein!");
            }
            else
            {
                Console.WriteLine("Minimum: {0} - am Index: {3}\nMaximum: {1} - am Index: {4}\nAverage: {2:N2}", min, max, avg, indexMin, indexMax);
            }

            Console.WriteLine("=======================================");


            //Aufgabe8 (Bubble)sort
            Console.WriteLine("\nAufgabe 8: (Bubble)sort mit Zahlen");
            int[] testSort = RandomFor(100000, 1, 100);
            //PrintString(testSort);
            //PrintString(Sort(testSort, true));              //use 'true' for ascending sorting, 'false' for descending sorting
            //PrintString(Sort(testSort, false));             //use 'true' for ascending sorting, 'false' for descending
            //PrintString(BubbleSort(testSort, true));
            //PrintString(BubbleSort(testSort, false));
            PrintString(BubbleSortTime(testSort, true));
            PrintString(BubbleSortBetterTime(testSort, true));



            //testSort = RandomFor(50000, 1, 100);
            //BubbleSort(testSort, true);

            Console.WriteLine("=======================================");
            Console.WriteLine("=======================================");


            //Aufgabe9 2D-Array
            Console.WriteLine("\nAufgabe 9: 2D-Array");
            //PrintArray2D(Arr2DRandom(10, 10, 0, 100));
            //PrintArray2D(Matrix2(5, 10, 1, 100));
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
                if (speicher[a] > arr2.Length || speicher[a] < 0)
                {
                    Console.WriteLine("Die Stelle {0} darf nicht außerhalb des Arrays (0 - {1}) liegen!", speicher[a], arr2.Length);
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
        public static int Minimum(int[] arr)
        {
            int min = Int32.MaxValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return min;
        }
        //Print
        public static void PrintMinimum(int min)
        {
            if (min == Int32.MaxValue)
            {
                Console.WriteLine("Minimum: Das Array darf nicht leer sein!");
            }
            else
            {
                Console.WriteLine("Minimum: " + min + " ");
            }
        }

        //Aufgabe7.2 Max.
        public static int Maximum(int[] arr)
        {
            int max = Int32.MinValue;
            for (int i = 0; i < arr.Length; i++)
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
        public static double Average(int[] arr)
        {
            double avg = (ArraySum(arr) * 1.00) / arr.Length;
            return avg;
        }
        //Print
        public static int PrintAveraqge(int avg)
        {
            Console.WriteLine("Average: " + avg);
            return avg;
        }

        //Aufgabe7.4 IndexMin
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

        //Aufgabe8 TimoSort
        public static int[] Sort(int[] arr, bool asc)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int a = i;
                while (a < arr.Length)
                {
                    if (asc && (arr[i] > arr[a]) || !asc && (arr[i] < arr[a]))
                    {
                        int temp = arr[a];
                        arr[a] = arr[i];
                        arr[i] = temp;
                        a = i;
                    }
                    else
                    {
                        a++;
                    }
                }
            }
            return arr;
        }

        //Aufgabe8 Bubblesort
        public static int[] BubbleSort(int[] arr, bool asc)
        {
            int steps = 0;
            for (int i = arr.Length; i > 1; i--)
            {
                for (int a = 0; a < i - 1; a++)
                {
                    if ((asc && arr[a] > arr[a + 1]) || (!asc && arr[a] < arr[a + 1]))
                    {
                        int temp = arr[a + 1];
                        arr[a + 1] = arr[a];
                        arr[a] = temp;
                    }
                    steps++;

                }
                if (i % 10000 == 0)
                {
                    Console.WriteLine("sorted");
                }
            }
            Console.WriteLine("Size: " + arr.Length + "Steps: " + steps);
            return arr;
        }

        //Aufgabe8 Bubblesort besser
        public static int[] BubbleSortBetterTime(int[] arr, bool asc)
        {
            int[] penis = new int[0];

            stopwatch.Start();
            if (asc)
            {
                for (int i = arr.Length; i > 1; i--)
                {
                    for (int a = 0; a < i - 1; a++)
                    {
                        if (arr[a] > arr[a + 1])
                        {
                            int temp = arr[a + 1];
                            arr[a + 1] = arr[a];
                            arr[a] = temp;
                        }
                    }
                }
            }
            else
            {
                for (int i = arr.Length; i > 1; i--)
                {
                    for (int a = 0; a < i - 1; a++)
                    {
                        if (arr[a] < arr[a + 1])
                        {
                            int temp = arr[a + 1];
                            arr[a + 1] = arr[a];
                            arr[a] = temp;
                        }
                    }
                }
            }
            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;

            // Format and display the TimeSpan value.
            string elapsedTime = string.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
            return penis;
        }


        //
        //Aufgabe8 Bubblesort Zeit
        public static int[] BubbleSortTime(int[] arr, bool asc)
        {
            int[] penis = new int[0];
            stopwatch.Start();
            for (int i = arr.Length; i > 1; i--)
            {
                for (int a = 0; a < i - 1; a++)
                {
                    if ((asc && arr[a] > arr[a + 1]) || (!asc && arr[a] < arr[a + 1]))
                    {
                        int temp = arr[a + 1];
                        arr[a + 1] = arr[a];
                        arr[a] = temp;
                    }
                }
            }
            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;

            // Format and display the TimeSpan value.
            string elapsedTime = string.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);
            return penis;
        }




        

        //------------------------------------------------------------------------------------------------------------------------------

        //Aufgabe9 2D-Array
        public static int[][] Arr2DRandom(int height, int length, int min, int max)
        {
            int[][] arr2D = new int[height][];
            for (int i = 0; i < arr2D.Length; i++)
            {
                arr2D[i] = new int[length];
            }
            for (int row = 0; row < arr2D.Length; row++)
            {
                for (int col = 0; col < arr2D[row].Length; col++)
                {
                    int randomNumber = random.Next(min, max);
                    arr2D[row][col] = randomNumber;
                }
            }
            return arr2D;
        }
        //Print
        public static void PrintArray2D(int[][] arr2D)
        {
            for (int row = 0; row < arr2D.Length; row++)
            {
                for (int col = 0; col < arr2D[row].Length; col++)
                {
                    Console.Write("{0,4}", arr2D[row][col]);
                }
                Console.WriteLine();
            }
        }





        //_________________________________________________________________________________________________________________________________________________
        //funktioniert nicht!!!!!!



        //public static int[] SumArray2D(int[][] arr2D, bool Spalte)
        //{
        //}






        /*

        public static int[][] Matrix2(int width, int height, int upper, int lower)
        {
            int summrow = 0;
            int summcol = 0;

            int[][] arr = new int[height][];
            for (int row = 0; row < height; row++)
            {
                arr[row] = new int[width];
                summrow = 0;
                for (int col = 0; col < width; col++)
                {
                    arr[row][col] = random.Next(upper, lower);
                    summrow += arr[row][col];

                }
                Console.WriteLine("Summe Zeile {1} = {0,3}", summrow, row + 1);

                //summcol += arr[row][col];
                //Console.WriteLine("Summe Zeile {1} = {0,3}", summrow, row+1);

            }
            return arr;
        }




        */
    }
}

