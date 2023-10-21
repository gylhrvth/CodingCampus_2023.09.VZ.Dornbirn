using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timo.Week04
{
    internal class Array2D
    {
        public static Random random = new Random();
        public static void Start()
        {
        
        }

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
                    Console.Write("{0,4}", arr2D[row][col]);
                }
                Console.WriteLine();
            }
        }
    }
}
