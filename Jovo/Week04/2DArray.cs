using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jovo.Week04
{
    internal class _2DArray
    {
        public static Random rnd = new Random();


        public static void Start()
        {

            int[][] arr2D = CreateArray2DRandom();

            for (int row = 0; row < arr2D.Length; row++)
            {
                
                for (int col = 0; col < arr2D[row].Length; col++)
                {
                    Console.Write(arr2D[row][col] + " ");
                }
                Console.WriteLine();
            }

            //for (int sumr = )
        }


        public static int[][] CreateArray2DRandom()
        {
            Random rnd = new Random();

            int[][] arr2D = new int[10][];

            for (int row = 0; row < arr2D.Length; row++)
            {
                arr2D[row] = new int[5];
            }
            for (int row = 0; row < arr2D.Length; row++)
            {
                for (int col = 0; col < arr2D[row].Length; col++)
                {
                    arr2D[row][col] = rnd.Next(10, 100);
                }
            }

            return arr2D;
        }
    }
}
