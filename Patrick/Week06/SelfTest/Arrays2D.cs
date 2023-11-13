using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week06.SelfTest
{
    internal class Arrays2D
    {
        public static void Start()
        {
            int[][] arr = FillArray(CreateArray(10,10));
            PrintArray(arr);

        }

        public static int[][] CreateArray(int sizeX, int sizeY)
        {
            int[][] array = new int[sizeX][];

            for(int i = 0; i < 10; i++)
            {                
                    array[i] = new int[sizeY];                          
            }
            return array;
        }

        public static int[][] FillArray(int[][] arr)
        {
            int value = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = 0; j < arr.Length; j++)
                {
                    arr[i][j] = value++;
                }             
            }
            return arr;
        }

        public static void PrintArray(int[][] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = 0; j < arr.Length; j++)
                {
                    Console.Write($"{arr[i][j], -5}");
                }
                Console.WriteLine();
            }
        }

    }
}
