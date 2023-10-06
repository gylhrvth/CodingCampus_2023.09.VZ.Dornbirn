using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Michael.Week01
{
    internal class Arrays
    {

        public static void NumberArray()
        {
            int size = ConsoleInputs.IntInput("how big should our array be?");

            int[] myArray = new int[size];
            int[] myArrayReversed = new int[size];

            for (int i = 0; i < size; i++)
            {
                myArray[i] = i + 1;
                myArrayReversed[i] = size - i;
            }

            Console.WriteLine("test");

            Console.WriteLine("normal array:");

            writeIntArray(myArray);

            Console.WriteLine("\n\nreversed array:");

            writeIntArray(myArrayReversed);

        }


        public static void writeIntArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }


        public static int[] makeACopy(int[] original)
        {
            return original;
        }


        public static int[] makeACopyAlt(int[] original)
        {
            int[] myArray = new int[original.Length];

            for (int i = 0; i < original.Length; i++)
            {
                myArray[i] = original[i];
            }

            return myArray;

        }

        
        public static void randomArray()
        {
            Random rnd = new Random();
            int[] randomIntegers = new int[40];
            
            for (int i = 0; i < 40; i++)
            {
                randomIntegers[i] = rnd.Next(101);
            }

            foreach (int number in randomIntegers)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine("\n");

            for (int i = 0; i < randomIntegers.Length; i++)
            {
                Console.Write(randomIntegers[i] + " ");
            }

            Console.WriteLine("\n");

            Console.WriteLine(randomIntegers.ToString() + "\n");

            Console.WriteLine(randomIntegers[1] + " " + randomIntegers[4] + " " + randomIntegers[9] + "\n");

            for (int i = 0; i < randomIntegers.Length; i++)
            {
                if (i % 2 == 1)
                Console.Write(randomIntegers[i] + " ");
            }

            Console.WriteLine();

        }


        public static void crazyArray()
        {
            Random rnd = new Random();
            int[] randomIntegers = new int[40];

            for (int i = 0; i < randomIntegers.Length; i++)
            {
                randomIntegers[i] = rnd.Next(-50,51);
            }

            foreach (int number in randomIntegers)
            {
                Console.Write(number + " ");
            }
        }


        public static void randomNumberArrayZaehlen()
        {
            Random rnd = new Random();
            int[] randomIntegers = new int[40];

            for (int i = 0; i < randomIntegers.Length; i++)
            {
                randomIntegers[i] = rnd.Next(101);
            }

            int bigger30 = 0;

            foreach (int number in randomIntegers)
            {
                if (number > 30)
                {
                    bigger30++;
                }
            }

            Console.WriteLine(bigger30);
        }


        public static void randomNumberArraySumme()
        {
            Random rnd = new Random();
            int[] randomIntegers = new int[40];

            for (int i = 0; i < randomIntegers.Length; i++)
            {
                randomIntegers[i] = rnd.Next(-50, 51);
            }

            int sum = 0;

            foreach (int number in randomIntegers)
            {
                sum += number;
            }

            Console.WriteLine(sum);
        }


        public static int randomNumberArrayMax(int size, int minRange, int maxRange)
        {
            Random rnd = new Random();
            int[] randomIntegers = new int[size];

            for (int i = 0; i < randomIntegers.Length; i++)
            {
                randomIntegers[i] = rnd.Next(minRange, maxRange+1);
            }

            int max = randomIntegers[0];

            foreach (int number in randomIntegers)
            {
                if (number > max)
                {
                    max = number;
                }
            }

            return max;
        }


        public static int randomNumberArrayMin(int size, int minRange, int maxRange)
        {
            Random rnd = new Random();
            int[] randomIntegers = new int[size];

            for (int i = 0; i < randomIntegers.Length; i++)
            {
                randomIntegers[i] = rnd.Next(minRange, maxRange + 1);
            }

            int min = randomIntegers[0];

            foreach (int number in randomIntegers)
            {
                if (number < min)
                {
                    min = number;
                }
            }

            return min;
        }


        public static double randomNumberArrayAverage(int size, int minRange, int maxRange)
        {
            Random rnd = new Random();
            int[] randomIntegers = new int[size];

            for (int i = 0; i < randomIntegers.Length; i++)
            {
                randomIntegers[i] = rnd.Next(minRange, maxRange + 1);
            }

            double sum = randomIntegers[0] + 0.0;

            foreach (int number in randomIntegers)
            {
                sum += number;
            }

            return sum / randomIntegers.Length;
        }


        public static int randomNumberArrayMaxIndex(int size, int minRange, int maxRange)
        {
            Random rnd = new Random();
            int[] randomIntegers = new int[size];

            for (int i = 0; i < randomIntegers.Length; i++)
            {
                randomIntegers[i] = rnd.Next(minRange, maxRange + 1);
            }

            int max = randomIntegers[0];
            int index = 0;

            for (int i = 0; i < randomIntegers.Length; i++)
            {
                if (randomIntegers[i] > max)
                {
                    max = randomIntegers[i];
                    index = i;
                }
            }

            Console.WriteLine(randomIntegers[index]);
            return index;
        }



        public static int randomNumberArrayMinIndex(int size, int minRange, int maxRange)
        {
            Random rnd = new Random();
            int[] randomIntegers = new int[size];

            for (int i = 0; i < randomIntegers.Length; i++)
            {
                randomIntegers[i] = rnd.Next(minRange, maxRange + 1);
            }

            int min = randomIntegers[0];
            int index = 0;

            for (int i = 0; i < randomIntegers.Length; i++)
            {
                if (randomIntegers[i] < min)
                {
                    min = randomIntegers[i];
                    index = i;
                }
            }

            Console.WriteLine(randomIntegers[index]);
            return index;
        }


        public static int[] createRandomArray(int size, int minRange, int maxRange)
        {
            Random rnd = new Random();
            int[] randomIntegers = new int[size];

            for (int i = 0; i < randomIntegers.Length; i++)
            {
                randomIntegers[i] = rnd.Next(minRange, maxRange + 1);
            }

            return randomIntegers;
        }



        public static int[] bubbleSortAscending(int[] toSort)
        {
            int[] sortedArray = new int[toSort.Length];

            sortedArray = toSort;
            bool hadToSwap = true;
            int first = 0;

            while (hadToSwap)
            {
                hadToSwap = false; 

                for(int i = 0; i < toSort.Length - 1; i++)
                {
                    if (sortedArray[i] > sortedArray[i + 1])
                    {
                        first = sortedArray[i];
                        sortedArray[i] = sortedArray[i + 1];
                        sortedArray[i + 1] = first;
                        hadToSwap = true;
                    }
                }
            }
            return sortedArray;
        }


        public static int[] bubbleSortDescending(int[] toSort)
        {
            int[] sortedArray = new int[toSort.Length];

            sortedArray = toSort;
            bool hadToSwap = true;
            int first = 0;

            while (hadToSwap)
            {
                hadToSwap = false;

                for (int i = 0; i < toSort.Length - 1; i++)
                {
                    if (sortedArray[i] < sortedArray[i + 1])
                    {
                        first = sortedArray[i];
                        sortedArray[i] = sortedArray[i+1];
                        sortedArray[i + 1] = first;
                        hadToSwap = true;
                    }
                }
            }
            return sortedArray;
        }



        public static void Array()
        {
            Console.WriteLine("random array:");
            int[] testArray = createRandomArray(40, 0, 50);
            writeIntArray(testArray);
            Console.WriteLine("\n\nsorted array:");
            int[] sortedArray = bubbleSortDescending(testArray);
            writeIntArray(sortedArray);
        }

    }
}
