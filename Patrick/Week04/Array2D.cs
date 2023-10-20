using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week04
{
    internal class Array2D
    {
        public static void Start()
        {

            PrintArray(CreateEmpty2DArray(3, 4));

        }

        public static int[][] CreateEmpty2DArray(int sizeX, int sizeY)
        {

            int[][] array2D = new int[sizeX][];

            for (int x = 0; x < array2D.Length; x++)
            {
                array2D[x] = new int[sizeY];

            }
            return array2D;
        }

        public static void PrintArray(int[][] array)
        {
            foreach(int[] element in array)
            {
                
                foreach (int element2 in element)
                {
                    Console.Write(element2 + " ");
                }
                Console.WriteLine();
            }

        }

       // public static int[][] Random2DArray()

    }
}
