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
            int[] rarr = Week02.Array.CreateRArray(0, 100, 10);
            Console.WriteLine("[{0}]", string.Join(", ", rarr));
            BubbleSort(rarr);
            Week02.Array.PrintArray(BubbleSort(rarr));
            PrintArrnice(BubbleSort(rarr));
            //PrintArrnice2(Matrix(4, 6, 0, 101));
            PrintArrnice3(Matrix2(4, 3, 0, 5));
        }
        public static void PrintArrnice(int[] arr)
        {
            Console.WriteLine("[{0}]", string.Join(", ", arr));
        }
        public static void PrintArrnice2(int[,] arr)
        {
            Console.WriteLine("[{0}]", string.Join(", ", arr));
        }
        public static void PrintArrnice3(int[][] arr)
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
        //Aufgabe Bubblesort mit Zahlen
        public static int[] BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
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
        //Aufgabe 2D-Array
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
                    
                    Console.WriteLine("Summe Spalte {1} = {0,3}", summcol, col + 1);
                }
                summcol += arr[row][col];
                Console.WriteLine("Summe Zeile {1} = {0,3}", summrow, row+1);
                
            }
            return arr;
        }
        ////Aufgabe 2D-Array Summe pro Zeile
        //public static void PrintSumm(int[][] arr)
        //{
        //    int a = 0;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        a = a + arr[i];
        //    }
        //    Console.WriteLine("Summe: {0}", a);
        //}


    }

}
