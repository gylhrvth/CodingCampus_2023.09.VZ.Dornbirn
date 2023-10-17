using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week03
{
    internal class UebungMakeACopy
    {
        public static Random random = new Random();

        public static void start()
        {
            //AUFGABE 1
            //printArray(createArrayIncrease(10));
            //Console.WriteLine();
            //printArray(createArrayDecrease(10));
            //Console.WriteLine();
            //Console.WriteLine("-----------------------");


            // AUFGABE 2
            // AUFGABE 2
            // AUFGABE 2
            // AUFGABE 2
            int[] array = createArrayIncrease(20);
            Console.WriteLine("Array mit aufsteigenden Zahlen");
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("-----------------------");


            int[] arrayCopy = makeACopy(array);
            Console.WriteLine("Erstelle eine Kopie vom 1. Array");
            foreach (int i in arrayCopy)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("-----------------------");


            array[0] = 200;

            Console.WriteLine("Den Arraywert an der 1. Stelle abgeändert");
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("-----------------------");

            Console.WriteLine("Kopiertes Array nach der Änderung des Originals");
            foreach (int i in arrayCopy)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("-----------------------");


            //AUFGABE 3
            //AUFGABE 3
            //AUFGABE 3
            //AUFGABE 3
            //int[] array1 = randomNumberArray(0, 101, 10);

            //Console.WriteLine("Gib es mit Hilfe einer foreach Schleife aus");
            //printArray(array1);
            //Console.WriteLine();

            //Console.WriteLine("Gib es mit Hilfe einer for Schleife aus");
            //printArray(array1);
            //Console.WriteLine();

            //Console.WriteLine("Gib den 2., 5. und 10. Wert des Arrays aus");
            //Console.WriteLine("[{0}]", string.Join(", ", array1[1], array1[4], array1[9]));
            //Console.WriteLine();

            //Console.WriteLine("Gib jeden 2. Wert des int[] mit Hilfe einer Schleife aus");
            //PrintEverySecondEntry(array1);


            //AUFGABE 4
            //AUFGABE 4
            //AUFGABE 4
            //AUFGABE 4
            //int[] array2 = randomNumberArrayCrazyRange(-50, 51, 10);
            //printArray(array2);

            //AUFGABE 5
            //AUFGABE 5

            //RandomNumberArrayZählen(1, 100, 10);
            //printArray(array3);

            //AUFGABE 6
            //RandomNumberArraySumme(1, 101, 10);

            //AUFGABE 7
            //RandomNumberMin(randomNumberArray(0, 101, 100));
            //RandomNumberMax(randomNumberArray(0, 101, 100));
            //RandomNumberAvg(randomNumberArray(0, 101, 5));

            //AUFGABE 9 BUBBLESORT
            printArray(BubbleSortAscending(randomNumberArray(0, 101, 10)));


        }

        public static void PrintEverySecondEntry(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {

                if (i % 2 == 1)
                {
                    Console.Write(array[i] + " ");
                }
            }
            Console.WriteLine();
        }


        public static int[] createArrayIncrease(int count)
        {
            int[] array = new int[count];

            for (int x = 0; x < count; x++)
            {
                array[x] = x + 1;
                //Console.Write(array[x] + " ");
            }
            return array;
        }

        public static int[] createArrayDecrease(int count)
        {
            int[] array = new int[count];

            for (int x = 0; x < array.Length; x++)
            {
                array[x] = count - x;
            }
            return array;
        }

        public static int[] printArray(int[] array)
        {
            foreach (int x in array)
            {
                Console.Write(x + " ");
            }

            return array;
        }

        public static int[] printArrayFor(int[] array)
        {
            for (int x = 0; x < array.Length; x++)
            {
                Console.Write(array[x] + " ");
            }
            return array;
        }

        public static int[] makeACopy(int[] original)
        {
            int[] copy = new int[original.Length];

            for (int x = 0; x < original.Length; x++)
            {
                copy[x] = original[x];
                //Console.WriteLine(copy[x]);
            }

            return copy;
        }

        public static int[] randomNumberArray(int low, int up, int count)
        {
            int[] array = new int[count];

            for (int x = 0; x < count; x++)
            {
                int randomNumber = random.Next(low, up);
                array[x] = randomNumber;
                //Console.Write(array[x] + "  ");
            }
            return array;

        }

        public static int[] randomNumberArrayEverySecond(int low, int up, int count)
        {
            int[] array = new int[count];

            for (int x = 0; x < array.Length; x++)
            {
                if (x % 2 == 1)
                {
                    Console.Write(array[x]);
                }
            }

            return array;
        }

        public static int[] randomNumberArrayCrazyRange(int low, int up, int count)
        {
            int[] array = new int[count];

            for (int x = 0; x < count; x++)
            {
                int randomNumber = random.Next(low, up);
                array[x] = randomNumber;
                //Console.Write(array[x] + "  ");
            }
            return array;
        }

        public static int[] RandomNumberArrayZählen(int low, int up, int count)
        {
            int[] array = new int[count];

            for (int x = 0; x < count; x++)
            {
                int randomNumber = random.Next(low, up);
                array[x] = randomNumber;

                if (randomNumber > 30)
                {
                    Console.Write(randomNumber + " ");
                }
                else
                {
                    Console.Write("XX ");
                }
            }
            Console.WriteLine();
            return array;
        }

        public static int[] RandomNumberArraySumme(int low, int up, int count)
        {
            int[] array = new int[count];
            int result = 0;

            for (int x = 0; x < array.Length; x++)
            {
                int randomNumber = random.Next(low, up);
                result += randomNumber;
                Console.Write(randomNumber + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Die Summe der random Zahlen ist = " + result);

            return array;
        }

        public static int RandomNumberMin(int[] array)
        {
            printArrayFor(array);
            //Console.WriteLine("  ....   ");
            int min = Int32.MaxValue;                                           // größt möglichste Zahl für den Datentyp int
            int howManyMin = 0;
            //int minNew = 0;

            for (int x = 0; x < array.Length; x++)
            {
                if (array[x] < min)
                {
                    //Console.WriteLine($"min ist aktuell = {min}");
                    min = array[x];

                    //Console.WriteLine($"neues min = {min}");
                    //howManyMin = 0;
                }
                //if (min == array[x])
                //{
                //    minNew = array[x];                                      // Wie viele minimale Zahlen sind vorhanden --> mit nur einer  For-Schleife
                //    howManyMin++;
                //}
            }
            for (int x = 0; x < array.Length; x++)                        // Wie viele minimale Zahlen sind vorhanden --> mit einer seperaten For-Schleife
            {
                if (array[x] == min)
                {
                    ++howManyMin;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Die Zahl {min} wurde {howManyMin} mal ausgegeben");
            return min;
        }

        public static int RandomNumberMax(int[] array)
        {
            printArrayFor(array);

            int max = Int32.MinValue;
            int howManyMax = 0;
            int maxNew = 0;
            Console.WriteLine();
            for (int x = 0; x < array.Length; x++)
            {
                if (array[x] > max)
                {
                    Console.WriteLine($"max ist aktuell = {max}");
                    max = array[x];
                    Console.WriteLine($"neues max = {max}");
                    howManyMax = 0;
                }

                if (max == array[x])
                {
                    maxNew = array[x];                                  // Wie viele Maximale Zahlen sind vorhanden --> in nur einer For-Schleife
                    howManyMax++;
                }
            }
            //for (int x = 0; x < array.Length; x++)
            //{
            //    if (array[x] == max)                                  // Wie viele Maximale Zahlen sind vorhanden --> mit einer seperaten For-Schleife
            //    {
            //        ++howManyMax;
            //    }
            //}
            Console.WriteLine($"Die Zahl {max} wurde {howManyMax} mal ausgegeben");

            return max;
        }

        public static double RandomNumberAvg(int[] array)
        {
            printArrayFor(array);

            double summe = 0;

            for (int x = 0; x < array.Length; x++)
            {
                summe += array[x];
            }

            double avg = summe / array.Length;
            Console.WriteLine();
            Console.WriteLine($"mein Average ist {avg}");

            return avg;
        }

        public static int[] BubbleSortAscending(int[] array)
        {
            int temporaryMemory = 0;

            for (int x = 0; x < array.Length; x++)
            {
                for (int y = 0; y < array.Length - 1; y++)
                {
                    if (array[y] > array[y + 1])
                    {
                        temporaryMemory = array[y];
                        array[y] = array[y + 1];
                        array[y + 1] = temporaryMemory;
                    }
                }
            }         
            return array;
        }


    }
}
