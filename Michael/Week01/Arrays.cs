using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Michael.Week01
{
    public class Arrays
    {

        public static Random rnd = new Random();


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

            Console.WriteLine("normal array:");

            writeIntArray(myArray);

            Console.WriteLine("\n\nreversed array:");

            writeIntArray(myArrayReversed);
        }


        public static int[] ascendingArray(int length)
        {
            int[] array = new int[length];

            for (int i = 0; i < length; i++)
            {
                array[i] = i + 1;
            }
            return array;
        }


        public static int[] descendingArray(int length)
        {
            int[] array = new int[length];

            for (int i = 0; i < length; i++)
            {
                array[i] = length - i;
            }
            return array;
        }


        public static void writeIntArray(int[] array/*, int space = 3*/)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i],/*space*/3}" + " ");
            }
            Console.WriteLine();
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


        public static int randomNumberArraySumme(int[] array)
        {
            int sum = 0;

            foreach (int number in array)
            {
                sum += number;
            }

            return sum;
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


        public static int ArrayMaxIndex(int[] array, int start = 0, int end = -1)
        {
            if (end == -1)
            {
                end = array.Length;
            }

            int max = array[0];
            int index = 0;

            for (int i = start; i < end; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    index = i;
                }
            }
            return index;
        }


        public static int ArrayMinIndex(int[] array, int start = 0)
        {
            return ArrayMinIndex(array, start, array.Length);
        }


        public static int ArrayMinIndex(int[] array, int start, int end)
        {
            int min = array[start];
            int index = start;

            for (int i = start; i < end; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    index = i;
                }
            }
            return index;
        }


        public static int[] createRandomArray(int size, int minRange, int maxRange)
        {
            int[] randomIntegers = new int[size];

            for (int i = 0; i < randomIntegers.Length; i++)
            {
                randomIntegers[i] = rnd.Next(minRange, maxRange + 1);
            }

            return randomIntegers;
        }


        public static int[] bubbleSortAscending(int[] array)
        {
            bool hadToSwap = true;

            while (hadToSwap)
            {
                hadToSwap = false; 

                for(int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        int first = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = first;
                        hadToSwap = true;
                    }
                }
            }
            return array;
        }


        public static int[] bubbleSortDescending(int[] array)
        {
            bool hadToSwap = true;
            int first = 0;

            while (hadToSwap)
            {
                hadToSwap = false;

                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] < array[i + 1])
                    {
                        first = array[i];
                        array[i] = array[i+1];
                        array[i + 1] = first;
                        hadToSwap = true;
                    }
                }
            }
            return array;
        }


        public static int[] selectionSortAscending(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int first = array[i];
                int mindex = ArrayMinIndex(array,i);

                array[i] = array[mindex];
                array[mindex] = first;
            }
            return array;
        }


        public static int[] insertionSortAscending(int[] array)
        {
            for (int i = 2; i < array.Length; i++)
            {
                int j = i;
                while ( (j > 0) && (array[j - 1] > array[j]))
                {
                    int first = array[j - 1];
                    array[j - 1] = array[j];
                    array[j] = first;

                    j--;
                }
            }
            return array;
        }

        
        public static int[] mergeSortAscending(int[] array)
        {
            if (array.Length == 1)
                return array;

            int middle = array.Length / 2;

            int[] leftArray = splitLeft(array, middle);
            int[] rightArray = splitRight(array, middle);

            leftArray = mergeSortAscending(leftArray);
            rightArray = mergeSortAscending(rightArray);

            return mergeArrays(leftArray, rightArray);
        }
        

        public static int[] splitLeft(int[] array, int index)
        {
            int[] result = new int[index];

            for(int i = 0; i < index; i++)
            {
                result[i] = array[i];
            }

            return result;
        }


        public static int[] splitRight(int[] array, int index)
        {
            int[] result = new int[array.Length - index];

            for (int i = 0; i < array.Length - index; i++)
            {
                result[i] = array[i+index];
            }

            return result;
        }


        public static int[] mergeArrays(int[] array1, int[] array2)
        {
            int[] result = new int[array1.Length + array2.Length];
            int i = 0;
            int j = 0;
            int k = 0;

            while ((k < array1.Length + array2.Length) && (i != array1.Length) && (j != array2.Length))
            {
                if (array1[i] < array2[j])
                {
                    result[k] = array1[i];
                    i++;
                }
                else
                {
                    result[k] = array2[j];
                    j++;
                }

                k++;
            }

            while (i != array1.Length)
            {
                result[k] = array1[i];
                i++;
                k++;
            }

            while (j != array2.Length)
            {
                result[k] = array2[j];
                j++;
                k++;
            }

            return result;
        }


        public static int[] gnomeSortAscending(int[] array)
        {
            int i = 1;

            while(i < array.Length)
            {
                if (array[i] >= array[i - 1])
                {
                    i++;
                }
                else
                {
                    int first = array[i];
                    array[i] = array[i - 1];
                    array[i-1] = first;
                    if (i > 1) i--;
                }
            }
            return array;
        }


        public static void twoDArray(int length)
        {
            int[][] twoDArray = new int[length][];
            
            for (int i = 0; i < length; i++)
            {
                twoDArray[i] = createRandomArray(length, 0, 101);
            }

            foreach (int[] entry in twoDArray)
            {
                writeIntArray(entry);
                Console.WriteLine();
            }

            Console.WriteLine("\nrow sum:");

            foreach (int[] entry in twoDArray)
            {
                int sum = 0;
                foreach (int num in entry)
                {
                    sum += num;
                }
                Console.WriteLine(sum);
            }

            Console.WriteLine("\ncolumn sum");

            for (int i = 0; i < length; i++)
            {
                int sum = 0;
                for (int j = 0; j < length; j++)
                {
                    sum += twoDArray[j][i];
                }
                Console.WriteLine(sum);
            }

        }


        public static void pascalDreieckPrint(int size)
        {
            int[][] coefficients = new int[size][];

            for (int i = 0; i < size; i++)
            {
                coefficients[i] = new int[size];
            }

            for (int i = 0; i< size; i++)
            {
                for (int j = 0; j < size; j ++)
                {
                    try
                    {
                        coefficients[i][j] = coefficients[i][j - 1] + coefficients[i - 1][j];
                    }
                    catch
                    {
                        coefficients[i][j] = 1;
                    }
                }
            }

            for (int i = 0; i < size; i++)
            {
                writeIntArray(coefficients[i]);
                Console.WriteLine();
            }

        }


        public static int pascalDreieckCoefficient(int down, int right)
        {
            int size = down;

            int[][] coefficients = new int[size][];

            for (int i = 0; i < size; i++)
            {
                coefficients[i] = new int[size];
            }

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    try
                    {
                        coefficients[i][j] = coefficients[i][j - 1] + coefficients[i - 1][j];
                    }
                    catch
                    {
                        coefficients[i][j] = 1;
                    }
                }
            }

            return coefficients[down - right][right - 1];

        }


        public static string polynomialFormula(int exponent)
        {
            string returnString = $"(a+b)^{exponent} = ";
            int coefficient = 0;

            for (int i = 0; i <= exponent; i++)
            {
                coefficient = pascalDreieckCoefficient(exponent+1, i+1);

                if (coefficient != 1)
                {
                    returnString += (coefficient + " ");
                }

                if (exponent - i != 0)
                {
                    returnString += "a";

                    if (exponent - i != 1)
                    {
                        returnString += "^" + (exponent - i);
                    }

                    returnString += " ";
                }

                if (i != 0)
                {
                    returnString += "b";

                    if (i != 1)
                    {
                        returnString += "^" + i;
                    }

                    returnString += " ";
                }

                if (i != exponent)
                {
                    returnString += "+ ";
                }
            }

            return returnString;

        }


        public static bool winsTicTacToe(int[,] field)
        {
            if ((field[0,0] == field[1,1] && field[1,1] == field[2,2] && field[1,1] != 0) ||
                (field[2,0] == field[1,1] && field[1,1] == field[0,2] && field[1,1] != 0))
            {
                return true;
            }
            for (int i = 0; i < 3; i++)
            {
                if ((field[i,0] == field[i,1] && field[i,1] == field[i,2] && field[i,0] != 0) ||
                    (field[0,i] == field[1,i] && field[1,i] == field[2,i] && field[0,i] != 0))
                {
                    return true;
                }
            }
            return false;
        }


        public static void printTicTacToe(int[,] field, char player1, char player2)
        {
            for (int y = 0; y < 3; y++)
            {
                for (int x = 0; x < 3; x++)
                {
                    if (field[y,x] == 1)
                    {
                        Console.Write(player1 + " ");
                    }
                    else if (field[y,x] == 2)
                    {
                        Console.Write(player2 + " ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                    
                    if (x < 2)
                    {
                        Console.Write("| ");
                    }
                }

                Console.WriteLine();

                if (y < 2)
                {
                    Console.WriteLine("- + - + - ");
                }
            }
        }


        public static void TicTacToe()
        {
            Random rnd = new Random();

            int[,] playField = new int[3,3] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
            bool repeat = true;
            int choice = 0;

            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine();

                repeat = true;
                while (repeat)
                {
                    Console.WriteLine($"player {(i+1)%2+1}, your turn. pick an empty field.\n");

                    printTicTacToe(playField,'x','o');
                    Console.WriteLine();

                    /*
                    if (i%2 == 1)
                    {
                        choice = ConsoleInputs.IntInput();
                    }
                    else
                    {
                        Thread.Sleep(3000);
                        choice = rnd.Next(1, 10);
                    }
                    */

                    choice = ConsoleInputs.IntInput();


                    Console.Clear();

                    try
                    {
                        if (playField[(choice-1)/3 , (choice-1) % 3] == 0)
                        {
                           Console.Write("understood");
                           playField[(choice-1) / 3, (choice-1) % 3] = (i + 1) % 2 + 1;
                           repeat = false;
                        }
                        else 
                        {
                            Console.WriteLine("this field is already taken");
                        }
                    }
                    catch
                    {
                        Console.WriteLine("field is out of bounds");
                    }

                    if (winsTicTacToe(playField))
                    {
                        Console.WriteLine($"\nCongrats Player {(i + 1) % 2 + 1}, you won!\n");
                        
                        if ((i + 1) % 2 + 1 == 1)
                        {
                            printTicTacToe(playField, 'X', 'o');
                        }
                        else
                        {
                            printTicTacToe(playField, 'x', 'O');
                        }
                        return;
                    }

                }

            }

            Console.Clear();
            Console.WriteLine("\n\n\nno winner, rip");
        }


        public static void printGOLField(int[,] field, int size)
        {

            for (int y = 0; y < size; y++)
            {
                for (int x = 0; x < size; x++)
                {
                    if (field[y,x] == 0)
                    {
                        Console.Write("  ");
                    }
                    else
                    {
                        Console.Write((char)9632 + " ");
                    }
                }
                Console.WriteLine();
            }
        }


        public static int[,] randomBinaryField(int size)
        {
            Random rnd = new Random();
            int[,] field = new int[size, size];

            for (int y = 0; y < size; y++)
            {
                for (int x = 0; x < size; x++)
                {
                    field[y, x] = rnd.Next(2);
                }
                Console.WriteLine();
            }
            return field;
        }


        public static int numberOfLivingNeighbors(int[,] field, int size, int xCoord, int yCoord)
        {
            int livingNeighbors = 0;

            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <=1; j++)
                {
                    try
                    {
                        if ((j != 0 || i != 0) && (field[yCoord + i, xCoord + j] == 1))
                        {
                            livingNeighbors++;
                        }
                        // alternative
                        //if(field[yCoord + i, xCoord + j] == 1)
                    }
                    catch
                    {
                    }
                }
            }
            return livingNeighbors /*-field[yCoord,xCoord]*/;
        }


        public static int[,] nextGenerationOfField(int[,] field, int size)
        {
            int[,] tempField = new int[size,size];

            for (int y = 0; y < size; y++)
            {
                for (int x = 0; x < size; x++)
                {
                    if (field[y, x] == 0 && numberOfLivingNeighbors(field, 20, x, y) == 3)
                    {
                        tempField[y, x] = 1;
                    }
                    else if (field[y, x] == 1 && numberOfLivingNeighbors(field, 20, x, y) < 2)
                    {
                        tempField[y, x] = 0;
                    }
                    else if (field[y, x] == 1 && numberOfLivingNeighbors(field, 20, x, y) > 3)
                    {
                        tempField[y, x] = 0;
                    }
                    else
                    {
                        tempField[y, x] = field[y, x];
                    }
                }
            }
            return tempField;
        }

       
        public static int[,] randomBinaryFieldCorrelated(int size)
        {
            Random rnd = new Random();
            int[,] field = new int[size, size];

            for (int y = 0; y < size; y++)
            {
                for (int x = 0; x < size; x++)
                {
                    field[y, x] = rnd.Next(10);
                    if (field[y,x] != 0)
                    {
                        field[y, x] = 0;
                    }
                    else
                    {
                        field[y, x] = 1;
                    }
                }
                Console.WriteLine();
            }
            return field;
        }


        public static void GameOfLife(int size, double generationsPerSecond = 1)
        {
            int[,] field = randomBinaryFieldCorrelated(size);
            //int[,] field = new int[5, 5] { { 0, 1, 0, 1, 0 }, { 0, 0, 1, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 }, { 0, 0, 0, 0, 0 } };

            while (true)
            {
                Console.Clear();
                printGOLField(field,size);
                field = nextGenerationOfField(field,size);
                Thread.Sleep((int)Math.Floor(1000/generationsPerSecond));
            }
        }


        public static void Start()
        {
            //int i = 30000;
            //for (int i = 1; i < 3000000; i+= 1000)
            {
                int[] array = createRandomArray(i, 0, 100000);
                int[] arrayInput = new int[i];

                
                arrayInput = makeACopyAlt(array);
                var watch = System.Diagnostics.Stopwatch.StartNew();
                bubbleSortAscending(arrayInput);
                watch.Stop();
                Console.WriteLine("bubble:\t\t" + watch.ElapsedMilliseconds + " ms");

                
                Console.WriteLine();


                arrayInput = makeACopyAlt(array);
                watch.Restart();
                selectionSortAscending(arrayInput);
                watch.Stop();
                Console.WriteLine("selection:\t" + watch.ElapsedMilliseconds + " ms");


                Console.WriteLine();


                arrayInput = makeACopyAlt(array);
                watch.Restart();
                insertionSortAscending(arrayInput);
                watch.Stop();
                Console.WriteLine("insertion:\t" + watch.ElapsedMilliseconds + " ms");


                Console.WriteLine();


                arrayInput = makeACopyAlt(array);
                watch.Restart();
                gnomeSortAscending(arrayInput);
                watch.Stop();
                Console.WriteLine("gnome:\t\t" + watch.ElapsedMilliseconds + " ms");


                Console.WriteLine();


                arrayInput = makeACopyAlt(array);
                watch.Restart();
                mergeSortAscending(arrayInput);
                watch.Stop();
                Console.WriteLine("merge:\t\t" + watch.ElapsedMilliseconds + " ms");
            }
        }
    }
}
