using Selina.Week04.Ausagbe;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selina.Week04._2D_Array
{
    internal class _2DArray
    {

        public static void Start()
        {
            Random rand = new Random();

            int size = CreateArray.ReadNumber("Geben Sie die Größe des Arrays ein:", "Sie müssen eine Zahl eingeben!");

            //Aufagbe 9:
            Ausgabe.Output("Aufgabe: 2D-Array\n", ConsoleColor.DarkMagenta);
            int[,] randomArray2D = CreateRandomArray2D(size, 0, 101, rand);     //macht Array2D mit random Zahlen von 0 bis 100
            OutputForUser2D(randomArray2D);     //Output für User
            Console.WriteLine();
            Summe2D(randomArray2D); //Output Summe für User
            Console.WriteLine("\n----------------------------------------------------------");
        }

        public static int Summe2D(int[,] randomArray)
        {
            int sum = 0;
            int count = 0;

            for (int row = 0; row < randomArray.GetLength(0); row++)
            {
                for (int col = 0; col < randomArray.GetLength(1); col++)
                {
                    sum = sum + randomArray[row, col];
                }

                Console.WriteLine($"Summe der Reihe {count}:\x1B[4m{sum}\x1B[0m");
                sum = 0;
                count++;
            }
            return sum;
        }
        public static void OutputForUser2D(int[,] randomArray)
        {
            for (int row = 0; row < randomArray.GetLength(0); row++)
            {
                for (int col = 0; col < randomArray.GetLength(1); col++)
                {
                    Console.Write($"{randomArray[row, col],-4}   ");
                }
                Console.WriteLine();
            }
        }
        public static void OutputForUser2D(int[][] randomArray)
        {
            for (int row = 0; row < randomArray.GetLength(0); row++)
            {
                for (int col = 0; col < randomArray.GetLength(1); col++)
                {
                    Console.Write($"{randomArray[row][col],-4}   ");
                }
                Console.WriteLine();
            }
        }
        public static int[,] CreateRandomArray2D(int size, int from, int to, Random rand)
        {
            int[,] randomArray = new int[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    randomArray[i, j] = rand.Next(from, to);
                }
            }
            return randomArray;


            //andere Variante:

            //public static int[][] CreateRandom2DArray2(int height, int width)
            //{
            //    int[][] arr = new int[height][];

            //    for(int row=0; row<height; row++)
            //    {
            //        arr[row] = new int[width];
            //    }

            //    for(int row=0; row<arr.Length;row++)
            //    {
            //        for(int col = 0; col < arr[row].Length; col++) {
            //            arr[row][col] = 123;
            //        }
            //    }
            //    return arr;
            //}
        }
    }
}
