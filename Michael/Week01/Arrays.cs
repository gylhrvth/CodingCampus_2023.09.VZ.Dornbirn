using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Channels;
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


        public static void writeIntArray(int[] array/*, int space = 3*/)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i],/*space*/6}" + " ");
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

                    if (i%2 == 1)
                    {
                        choice = ConsoleInputs.IntInput();
                    }
                    else
                    {
                        Thread.Sleep(3000);
                        choice = rnd.Next(1, 10);
                    }


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

        /*
        public static void printGOLField(int[,] field)
        {
            foreach (int[] row in field)
            {
                foreach (int cell in row)
                {
                    if (cell == 0)
                    {
                        Console.Write("  ");
                    }
                    else
                    {
                        Console.Write((char)9632);
                    }
                }
            }
        }
        */

       
        public static void GameOfLife(int size)
        {
            int[,] field = new int[size, size];
        }
        

        public static void Start()
        {
            int[,] array = new int[2, 2] { { 0, 1 }, { 1, 0 } };
            //printGOLField(array);
        }

    }
}
