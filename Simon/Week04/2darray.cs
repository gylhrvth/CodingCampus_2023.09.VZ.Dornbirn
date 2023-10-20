using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon.Week04
{
    internal class _2darray
    {
        public static Random random = new Random();
        public static void Start()
        {
            Console.WriteLine("Matrix neu");
            int[][] arr2d = Twodarr(10, 4, 0, 101);
            Print2darr(arr2d);

            int[] sumrow = Sumrow(arr2d);
            Console.WriteLine(string.Join(" ", sumrow));

            int[] sumCol = Sumcol(arr2d);
            Console.WriteLine(string.Join(" ", sumCol));

            Print2darr(CalcPascalarr(5, 7));

        }
        //print Funktion für 2D Array
        public static void Print2darr(int[][] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write("{0,4}", arr[i][j]);
                }
                Console.WriteLine();
            }
        }
        //2D Array
        public static int[][] Twodarr(int row, int col, int lower, int upper)
        {
            int[][] arr = new int[row][];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new int[col];
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = random.Next(lower, upper);
                }
            }
            return arr;
        }
        // Summe der Zeilen berechnen
        public static int[] Sumrow(int[][] arr)
        {
            int[] result = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    result[i] += arr[i][j];
                }
            }
            return result;
        }
        // Summe der Spalten berechnen
        public static int[] Sumcol(int[][] arr)
        {
            if (arr.Length == 0)
            {
                return new int[] { };
            }
            int[] result = new int[arr[0].Length];
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    result[j] += arr[i][j];
                }
            }
            return result;
        }
        // PascalDreieck
        public static int[][] CalcPascalarr(int row, int col)
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
                        arr[i][j] = arr[i - 1][j] + arr[i][j-1];
                    }
                }
            }
            return arr;
        }
    }
}
