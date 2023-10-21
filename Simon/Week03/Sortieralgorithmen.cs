using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon.Week03
{
    internal class Sortieralgorithmen
    {
        public static Random random = new Random();
        public static void Start()
        {
            //Console.WriteLine("Random Array");
            //int[] rarr = Week02.Array.CreateRArray(0, 100, 10);
            //Console.WriteLine("[{0}]", string.Join(", ", rarr));

            //Console.WriteLine("Bubblesort Ascending");
            //PrintArrnice(BubbleSortasc(rarr));
            //Console.WriteLine("Bubblesort Descending");
            //PrintArrnice(BubbleSortdesc(rarr));

            //Console.WriteLine("Matrix");
            //PrintMatrix(Matrixworking(4, 3, 0, 5));
            


        }
        public static void PrintArrnice(int[] arr)
        {
            Console.WriteLine("[{0}]", string.Join(", ", arr));
        }
        public static void PrintMatrix(int[][] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write("{0,4}", arr[i][j]);
                }
            }
        }
        //Aufgabe Bubblesort mit Zahlen Ascending
        public static int[] BubbleSortasc(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            return arr;
        }
        //Aufgabe Bubblesort mit Zahlen Descending
        public static int[] BubbleSortdesc(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            return arr;
        }
        
        //Aufgabe 2D-Array
        public static int[][] Matrix2(int width, int height, int upper, int lower)
        {
            int summcol = 0;
            int countcol = 0;
            int[][] arr = new int[height][];
            for (int row = 0; row < height; row++)
            {
                arr[row] = new int[width];
                int summrow = 0;

                for (int col = 0; col < width; col++)
                {
                    arr[row][col] = random.Next(upper, lower);
                    summrow += arr[row][col];
                    if (col == 0)
                    {
                        Console.WriteLine("Summe Spalte {1} = {0,3}", summcol, countcol + 1);
                        countcol++;
                    }
                }
                summcol += arr[row].Sum();
                Console.WriteLine("Summe Zeile {1} = {0,3}", summrow, row + 1);

            }
            return arr;
        }

        public static int[][] Matrixworking(int width, int height, int upper, int lower)
        {
            int[][] arr = new int[height][];
            int[] summeSpalten = new int[width];

            for (int row = 0; row < height; row++)
            {
                arr[row] = new int[width];

                for (int col = 0; col < width; col++)
                {
                    arr[row][col] = random.Next(upper, lower);
                    summeSpalten[col] += arr[row][col];
                }

                Console.WriteLine("Summe Zeile {0} = {1,3}", row + 1, ArraySum(arr[row]));
                Console.WriteLine(arr[row]);
            }

            for (int col = 0; col < width; col++)
            {
                Console.WriteLine("Summe Spalte {0} = {1,3}", col + 1, summeSpalten[col]);
            }

            return arr;
        }

        public static int ArraySum(int[] array)
        {
            int sum = 0;
            foreach (int num in array)
            {
                sum += num;
            }
            return sum;
        }
    }

}
