using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sven.Week04
{
    internal class Array2D_Uebungen
    {
        

        public static void Start()
        {
            Console.WriteLine("Create 2DArray:");
            int[][] arr2d = Create2DArray(3,5);
            Console.WriteLine();

            //Console.WriteLine("Create 2DArray:");
            //Print2DArray(arr2d);
            //Console.WriteLine();



        }

        public static int [][] Create2DArray( int rows, int columns)
        {

            Random random = new Random();

            int[][] arr2d = new int[7][];
            for (int row = 0; row < arr2d.Length; row++)
            {
                arr2d[row] = new int[5];
            }

            for (int row = 0; row < arr2d.Length; row++)
            {
                for (int col = 0; col < arr2d[row].Length; col++)
                {
                    arr2d[row][col] = random.Next(10, 100);
                }
            }

            for (int row = 0; row < arr2d.Length; row++)
            {
                for (int col = 0; col < arr2d[row].Length; col++)
                {
                    Console.Write(arr2d[row][col] + " ");
                }
                Console.WriteLine();
            }
            return arr2d;
        }
        public static void Print2DArray(int[][] arr2d)
        {


            for (int row = 0; row < arr2d.Length; row++)
            {
                for (int col = 0; col < arr2d[row].Length; col++)
                {
                    Console.Write(arr2d[row][col] + " ");
                }
                Console.WriteLine();

            }
        }

    }
}
