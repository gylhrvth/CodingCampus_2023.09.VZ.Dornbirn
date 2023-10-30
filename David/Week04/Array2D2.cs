using System;
using System.Reflection.Metadata.Ecma335;

namespace David.Week04
{
    public class Array2D2
    {
        public Array2D2()
        {
        }

        public static void Start()
        {
            Console.WriteLine("Bitte gib eine Wert zwischen 1-10 ein!");
            int UserIn = Convert.ToInt32(Console.ReadLine());

            int[][] arr =  CreateArray2D(UserIn);
            FillArray(arr);
            ArrayPrint(arr);

        }

        public static int[][] CreateArray2D(int size)
        {
            int[][] arr2D = new int[size][];

            for (int i = 0; i < arr2D.Length; i++)
            {
                arr2D[i] = new int[size];
            }
            return arr2D;
        }
        public static int[][] FillArray(int[][] arrP)
        {
            for (int i = 0; i < arrP.Length; i++)
            {
                for (int j = 0; j < arrP.Length; j++)
                {
                    arrP[i][j] = i + j;
                }
            }
            return arrP;
        }                                                                           
        public static void ArrayPrint(int[][] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    Console.Write(arr[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}

