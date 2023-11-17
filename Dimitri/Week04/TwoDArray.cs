using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dimitri.Week03.Array;
using static Dimitri.Week03.ConsoleInput;
using static Dimitri.Week04.ConsoleInputPart2;

namespace Dimitri.Week04
{
    internal class TwoDArray
    {
        public static void Main()
        {
            //PrintArray2d(Array2dRandom(2));
            //PrintArray2d(Array2dRandom(5, 5));
            //int[][] a = Array2dRandom(5, 5);
            //PrintArray2d(a);
            //Console.WriteLine();
            //SumArray2D(a); //, true);
            //Console.WriteLine();
            //int[] sumRow = SumRow(a);
            //Console.WriteLine(string.Join(" ", sumRow));
            //Console.WriteLine();
            //int[] sumCol = SumCol(a);
            //Console.WriteLine(string.Join(" ", sumCol));
            int[][] arr = PascalTriangle(10);
            PrintPascalTriangle(arr);
            Console.WriteLine();
            PrintArray(BinomialFormula(), "+");


        }


        public static int[][] Array2dRandom(int numRow, int numCol)
        {
            int[][] array = new int[numRow][];

            Random random = new Random();

            for (int i = 0; i < numRow; i++)
            {
                array[i] = new int[numCol];
            }

            for (int j = 0; j < numRow; j++)
            {


                for (int k = 0; k < numCol; k++)
                {
                    array[j][k] = random.Next(0, 101);
                }
            }

            return array;

        }

        public static void PrintArray2d(int[][] array)
        {

            for (int row = 0; row < array.Length; row++)
            {
                for (int col = 0; col < array[row].Length; col++)
                {
                    Console.Write("{0} ", array[row][col]);
                }
                Console.WriteLine();
            }
        }

        public static void SumArray2D(int[][] array)
        {

            Console.WriteLine("You wanna have the sum of rows or columns? (r/c)");
            string input = AskYN(StringRead(), "r", "c");

            bool sumRow = false;
            if (input.CompareTo("r") == 0)
            {
                sumRow = true;
            }

            Console.WriteLine();

            if (sumRow)
            {

                for (int i = 0; i < array.Length; i++)
                {
                    int sum = 0;
                    for (int j = 0; j < array[i].Length; j++)
                    {
                        sum += array[i][j];

                    }
                    Console.WriteLine("Sum of {0}. row is {1}.", i + 1, sum);
                }
            }
            else if (!sumRow)
            {
                int index = 0;

                while (index < array[0].Length)
                {
                    int sum = 0;
                    for (int i = 0; i < array.Length; i++)
                    {
                        sum += array[i][index];
                    }

                    Console.WriteLine("Sum of {0}. column is {1}.", index + 1, sum);
                    index++;

                }
            }

        }

        public static int[] SumRow(int[][] array)
        {
            int[] sum = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {

                for (int j = 0; j < array[i].Length; j++)
                {
                    sum[i] += array[i][j];

                }
                ;
            }

            return sum;
        }

        public static int[] SumCol(int[][] array)

        {
            if (array.Length == 0)
            {
                return new int[] { };
            }

            int[] sum = new int[array[0].Length];
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    sum[j] += array[i][j];
                }
            }
            return sum;
        }

        public static int[][] PascalTriangle(int input)
        {
            int[][] array = new int[input][];

            for (int i = 0; i < input; i++)
            {
                array[i] = new int[input];
            }

            // fill everything with ones

            for (int j = 0; j < input; j++)
            {
                for (int k = 0; k < input; k++)
                {
                    array[j][k] = 1;
                }
            }

            for (int j = 1; j < input; j++)
            {

                for (int k = 1; k < input; k++)
                {
                    array[j][k] = array[j - 1][k] + array[j][k - 1];
                }
            }

            return array;

        }

        public static void PrintPascalTriangle(int[][] array)
        {
            for (int row = 0; row < array.Length; row++)
            {
                for (int col = 0; col < array[row].Length; col++)
                {
                    Console.Write("{0,5} ", array[row][col]);
                }
                Console.WriteLine();
            }
        }

        public static string[] BinomialFormula()
        {
            int input = IntRead("What binomial formula do you want?", "Input is not an integer, please try again integer:");
            string[] formula = new string[input];

            Console.WriteLine(string.Join(" ", formula));

            int[][] pascalTriangle = PascalTriangle(input);

            for (int i = 0; i <= input; i++)
            {
                for (int j = input; j <= 0; j++)
                {
                    //int intFormulaPart0 = pascalTriangle[i][j];
                    //string stringFormulaPart0 = Convert.ToString(intFormulaPart0);
                    //formula[i] = BuildString(intFormulaPart0, intFormulaPart0...)
                }
            }

            return formula;
        }

        public static void PrintArray(string[] arr, string delimiter)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (i < arr.Length - 1)
                {
                    Console.Write("{0}{1} ", arr[i], delimiter);
                }
                else
                {
                    Console.Write(arr[i]);
                }
            }
            Console.WriteLine();
            /* For some reason this only returns a 0 if you have an array with only one element */
        }

        //    public static void BuildBinomialString(???)
        //    {
        //        for blabla until ende ++ {
        //            string + string + string .Compare()...
        //        }
        //    }
    }
}
