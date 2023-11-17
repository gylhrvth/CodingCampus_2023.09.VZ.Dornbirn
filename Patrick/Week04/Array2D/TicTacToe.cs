using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;



namespace Patrick.Week04.Array2D
{   
    internal class TicTacToe
    {         
        public static void Start()
        {
            PrintArray(Playground());

        }

        public static void PrintArray(int[][] array2D)
        {
            for (int i = 0; i < array2D.Length; i++)
            {
                for (int j = 0; j < array2D[i].Length; j++)
                {
                    Console.Write(array2D[i][j]);
                }
                Console.WriteLine();
            }

        }

        public static int[][] Playground()
        {
            int[][] array2D = new int[3][];

            for (int i = 0; i < array2D.Length; i++)
            {
                array2D[i] = new int[3];

                for (int j = 0; j < array2D.Length; j++)
                {
                    array2D[i][j] = 0;
                }
            }

            return array2D;
        }

        //public static int[][] Player1Player2(int[][] array2D)
        //{

        //    for (int i = 0; i < array2D.Length; i++)
        //    {
        //        Playground();
        //        int input1 = Convert.ToInt32(Console.ReadLine());

        //    }

        //}


        public static void MaxWert(int[] array)
        {
            int max = 0;
            for(int i = 0; i < array.Length;i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            Console.WriteLine(max);

        }
    }
}
