using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dimitri.Week03.Array;

namespace Dimitri.Week04
{
    internal class TwoDArray
    {
        public static void Main()
        {
            PrintArray2d(Array2dRandom(2));
        }

        public static int[][] Array2dRandom(int rows)
        {
            int[][] array = new int[rows][];

            Random random = new Random();

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < array[row].Length; col++)
                {
                    array[row][col] = random.Next(10, 100);
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
                    Console.Write(array[row][col] + " ");
                }
                Console.WriteLine();
            }
        }
    }

}
