using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timo.Week04
{
    internal class Array2D
    {
        public static Random random = new Random(123);
        public static void Start()
        {
            Console.WriteLine("Aufgabe 11: 2D Array, SumRow, SumCol");
            int[][] arr = Arr2DRandom(5, 5, 10, 100);
            PrintArray2D(arr);
            Console.WriteLine();
            Console.WriteLine("Sum row: " + SumRowArr2D(arr, 0));
            Console.WriteLine("Sum col: " + SumColArr2D(arr, 1));

            Console.WriteLine("==================================================================");


            Console.WriteLine("Aufgabe 12: Pascal Dreieck");
            PrintPascalDreieck(CreatePascal(10, 10));
        }


        //---------------------------------------------------------------------------------------------------------------------

        //Aufgabe 11: 2D-Array
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
                    Console.Write(arr2D[row][col] + " ");
                }
                Console.WriteLine();
            }
        }
        //Summe Zeile Arr2D
        public static int SumRowArr2D(int[][] arr2D, int rowIndex)
        {
            int sum = 0;
            for (int i = 0; i < arr2D[rowIndex].Length; i++)
            {
                sum = sum + arr2D[rowIndex][i];
            }
            return sum;
        }
        //Summe Spalte Arr2d
        public static int SumColArr2D(int[][] arr2D, int colIndex)
        {
            int sum = 0;
            for (int i = 0; i < arr2D[colIndex].Length; i++)
            {
                sum = sum + arr2D[colIndex][i];
            }
            return sum;
        }


        //Aufgabe 12: Pascal Dreieck
        public static int[][] CreatePascal(int row, int col)
        {
            int[][] arr = new int[row][];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new int[col];
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (i == 0 || j == 0)
                    {
                        arr[i][j] = 1;
                    }
                    else
                    {
                        arr[i][j] = arr[i - 1][j] + arr[i][j - 1];
                    }
                }
            }
            return arr;
        }
        //PrintPascal
        public static void PrintPascalDreieck(int[][] arr2D)
        {
            for (int i = 0; i < arr2D.Length; i++)
            {
                for (int j = 0; j < arr2D[i].Length; j++)
                {
                    Console.Write("{0,7}", arr2D[i][j]);
                }
                Console.WriteLine();
            }
        }

        public static string[][] CreateEmptyArray(int rows, int cols)
        {
            string[][] arr2D = new string[rows][];
            for (int i = 0; i < arr2D.Length; i++)
            {
                arr2D[i] = new string[cols];
            }
            return arr2D;
        }
    }
}
