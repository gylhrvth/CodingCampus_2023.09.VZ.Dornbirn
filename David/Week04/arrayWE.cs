using System;
using System.Data;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using David.Week04;

namespace David.Week04
{
    public class arrayWE
    {
        public arrayWE()
        {
        }

        public static void Start()
        {
            int[][] arr = Array2D(4, 10);
            int[][] print = PrintArray(arr);

            NextArr2D(5, 7);

            NextArray(5, 7);

        }


        public static int[][] Array2D(int size, int size2)
        {
            int[][] arrayD2 = new int[size][];

            for (int i = 0; i < arrayD2.Length; i++)
            {
                arrayD2[i] = new int[size2];
            }

            for (int i = 0; i < arrayD2.Length; i++)
            {
                for (int j = 0; j < arrayD2[i].Length; j++)
                {
                    arrayD2[i][j] = j;
                    Console.Write(arrayD2[i][j] + " ");
                }
                Console.WriteLine();
            }
            return arrayD2;

        }

        public static int[][] PrintArray(int[][] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine();
            }
            return arr;
        }

        public static void NextArr2D(int row, int col)
        {
            //reservieren
            int[][] newarr = new int[row][];

            for (int i = 0; i < newarr.Length; i++)
            {
                newarr[i] = new int[col];
            }
            //befüllen befüllen

            for (int i = 0; i < newarr.Length; i++)
            {
                for (int j = 0; j < newarr[i].Length; j++)
                {
                    newarr[i][j] = j;
                }
            }
            // in console drucken

            for (int i = 0; i < newarr.Length; i++)
            {
                for (int j = 0; j < newarr[i].Length; j++)
                {
                    Console.Write(newarr[i][j] + " ");
                }
                Console.WriteLine();
            }




        }
        public static void NextArray(int eins, int zwei)
        {
            int[][] davidArr = new int[eins][];

            for (int i = 0; i < davidArr.Length; i++)
            {
                davidArr[i] = new int[zwei];
            }


            for (int i = 0; i < davidArr.Length; i++)
            {
                for (int j = 0; j < davidArr[i].Length; j++)
                {
                    davidArr[i][j] = i;
                }
            }

            for (int i = 0; i < davidArr.Length; i++)
            {
                for (int j = 0; j < davidArr[i].Length; j++)
                {
                    Console.Write(davidArr[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
        public static void ArrayNEW()
        {
            int[][] array2D = new int[5][];

            for (int i = 0; i < array2D.Length; i++)
            {
                array2D[i] = new int[10]; 
            }


            for (int i = 0; i < array2D.Length; i++)
            {
                for (int j = 0; j < array2D[i].Length; j++)
                {
                    array2D[i][j] = i;
                    Console.Write(array2D[i][j]);
                }
            }
            Console.WriteLine();
        }

    }
}

