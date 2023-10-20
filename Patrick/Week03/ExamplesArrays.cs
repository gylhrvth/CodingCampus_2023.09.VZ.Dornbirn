using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week03
{
    internal class ExamplesArrays
    {
        public static Random random = new Random();

        public static void start()
        {
            // AUFGABE 1
            PrintArray(CreateArray(10));
            PrintArray(CreateArray2(10));
            Console.WriteLine("====================================================");
            Console.WriteLine("====================================================");


            //AUFGABE 2
            int[] arrayUp = CreateArray(10);
            int[] arrayCopy = MakeACopy(arrayUp);
            Console.WriteLine("This is the original Array: ");
            Console.WriteLine("[{0}]", string.Join(", ", arrayUp));
            Console.WriteLine("This is the copy Array: ");
            Console.WriteLine("[{0}]", string.Join(", ", arrayCopy));
            arrayUp[0] = 200;
            Console.WriteLine("change Array on Index 0");
            Console.WriteLine("[{0}]", string.Join(", ", arrayUp));
            Console.WriteLine("This is the copy of the Array: ");
            Console.WriteLine("[{0}]", string.Join(", ", arrayCopy));
            Console.WriteLine("====================================================");
            Console.WriteLine("====================================================");


            //AUFGABE 3
            int[] array = RandomNumberArray(0, 101, 10);
            PrintArrayForEach(array);                                                           //Gib es mit Hilfe einer Foreach Schleife aus
            PrintArrayFor(array);                                                               //Gib es mit Hilfe einer For Schleife aus
            Console.WriteLine("[{0}]", string.Join(", ", array[1], array[4], array[9]));        //Gib den 2. 5. und 10. Wert des Arrays aus
            PrintArrayEverySec(array);                                                          //Gib jeden 2. Wert des Arrays mit hilfe einer Schleife aus
            Console.WriteLine("====================================================");
            Console.WriteLine("====================================================");


            //AUFGABE 4
            int[] array1 = RandomNumberCrazyRange(-50, 51, 10);
            PrintArrayFor(array1);                                                              // Ich nehme hier eine ForSchleife da der Consolenoutput schöner ist
            Console.WriteLine("====================================================");
            Console.WriteLine("====================================================");


            //AUFGABE 5
            PrintArrayBigger30(array);                                                          //Erstelle eine Funktion die < 30 printed
            Console.WriteLine("====================================================");
            Console.WriteLine("====================================================");


            //AUFGABE 6     
            Console.WriteLine("The result of my Array is:  " + RandomNumberArraySumme(array));  //Erstelle eine Funktion, die die Summer der Werte zurückgibt
            Console.WriteLine("====================================================");
            Console.WriteLine("====================================================");


            //AUFGABE 7
            PrintArray(array);
            Console.Write("The smallest number of the Array is:  ");
            Console.WriteLine(RandomNumberArrayMin(array));                                     //Erstelle eine Methode für das Minimum
            Console.Write("The biggest number of the Array is:  ");
            Console.WriteLine(RandomNumberArrayMax(array));                                     //Erstelle eine Methode für das Maximum
            Console.Write("The Average of the Array is:  ");
            Console.WriteLine(RandomNumberArrayAvg(array));                                     //Erstelle eine Methode die Den Durchschnitt des Arrays berechnet
            Console.Write("The smallest number of the Array is on Index:  ");
            Console.WriteLine(RandomNumberMinIndex(array));                                     //Erstelle eine Methode, die den Index des Minimums zurückgibt
            Console.Write("The biggest number of the Array is on Index:  ");
            Console.WriteLine(RandomNumberMaxIndex(array));                                     //Erstelle eine Methode, die den Index des Maximums zurückgibt
            Console.WriteLine("====================================================");
            Console.WriteLine("====================================================");


            //AUFGABE 8 2D-Array


            Console.WriteLine("====================================================");
            Console.WriteLine("====================================================");
        }


        public static int[] CreateArray(int size)
        {
            int[] array = new int[size];

            for (int x = 0; x < array.Length; x++)
            {
                array[x] = x + 1;
            }
            return array;
        }

        public static int[] CreateArray2(int size)
        {
            int[] array = new int[size];

            for (int x = 0; x < array.Length; x++)
            {
                array[x] = size - x;
            }
            return array;
        }

        public static void PrintArray(int[] array)
        {
            Console.WriteLine("[{0}]", string.Join(", ", array));

        }

        public static int[] MakeACopy(int[] array)
        {
            int[] arrayCopy = new int[array.Length];

            for (int x = 0; x < array.Length; x++)
            {
                arrayCopy[x] = array[x];
            }
            return arrayCopy;
        }

        public static int[] RandomNumberArray(int low, int high, int size)
        {
            int[] array = new int[size];

            for (int x = 0; x < array.Length; x++)
            {
                int randomNumber = random.Next(low, high);
                array[x] = randomNumber;
            }
            return array;
        }

        public static void PrintArrayForEach(int[] array)
        {
            Console.Write("[");
            foreach (int x in array)
            {
                Console.Write(x + ", ");
            }
            Console.WriteLine("]");
        }

        public static void PrintArrayFor(int[] array)
        {
            Console.Write("[");
            for (int x = 0; x < array.Length; x++)
            {
                if (x == array.Length - 1)
                {
                    Console
                        .Write(array[x]);
                }
                else
                {
                    Console.Write(array[x] + ", ");
                }
            }
            Console.WriteLine("]");
        }
        public static void PrintArrayEverySec(int[] array)
        {
            Console.Write("[");
            for (int x = 0; x < array.Length; x += 2)
            {
                if (x == 8)
                {
                    Console.Write(array[x]);
                }
                else
                {
                    Console.Write(array[x] + ", ");
                }
            }
            Console.WriteLine("]");
        }

        public static int[] RandomNumberCrazyRange(int low, int high, int size)
        {
            int[] array1 = new int[size];

            for (int x = 0; x < array1.Length; x++)
            {
                int randomNumber = random.Next(low, high);
                array1[x] = randomNumber;
            }
            return array1;
        }

        public static void PrintArrayBigger30(int[] array)
        {
            Console.Write("[");
            for (int x = 0; x < array.Length; x++)
            {
                if (array[x] > 30)
                {
                    if (x == array.Length - 1)
                    {
                        Console.Write(array[x]);
                    }
                    else
                    {
                        Console.Write(array[x] + ", ");
                    }
                }
                else
                {
                    if (x == array.Length - 1)
                    {
                        Console.Write("XX");
                    }
                    else
                    {
                        Console.Write("XX, ");
                    }
                }
            }
            Console.WriteLine("]");
        }

        public static int RandomNumberArraySumme(int[] array)
        {
            int result = 0;

            for (int x = 0; x < array.Length; x++)
            {
                result += array[x];
            }
            return result;
        }

        public static int RandomNumberArrayMin(int[] array)
        {
            int min = Int32.MaxValue;
            int howManyMin = 0;
            for (int x = 0; x < array.Length; x++)
            {
                if (array[x] < min)
                {
                    min = array[x];
                }
            }

            return min;
        }

        public static int RandomNumberArrayMax(int[] array)
        {
            int max = Int32.MinValue;
            for (int x = 0; x < array.Length; x++)
            {
                if (array[x] > max)
                {
                    max = array[x];
                }
            }
            return max;
        }

        public static double RandomNumberArrayAvg(int[] array)
        {
            double summe = 0;
            for (int x = 0; x < array.Length; x++)
            {
                summe += array[x];
            }
            double avg = summe / array.Length;


            return avg;
        }

        public static int RandomNumberMinIndex(int[] array)
        {
            int min = Int32.MaxValue;
            int minIndex = 0;

            for (int x = 0; x < array.Length; x++)
            {
                if (array[x] < min)
                {
                    min = array[x];
                    minIndex = x;
                }
            }
            return minIndex;
        }

        public static int RandomNumberMaxIndex(int[] array)
        {
            int max = Int32.MinValue;
            int maxIndex = 0;
            for (int x = 0; x < array.Length; x++)
            {
                if (array[x] > max)
                {
                    max = array[x];
                    maxIndex = x;
                }
            }
            return maxIndex;
        }

    }
}
