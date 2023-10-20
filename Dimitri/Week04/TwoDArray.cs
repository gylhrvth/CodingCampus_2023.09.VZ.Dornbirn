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

        public static int[][] Array2dRandom(int row)
        {
            int[][] array = new int[row][];

            Random random = new Random();

            for(int i = 0; i < array[row].Length; i++)
            {
                array[row][i] = random.Next(0, 101);
            }

            return array;
        }

        public static void PrintArray2d(int[][] array)
        {

            foreach(int[] row in array)
            {
                Console.Write(row + " ");
            }
            Console.WriteLine();
        }
    }

}
