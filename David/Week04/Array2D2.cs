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

            int[][] arr =  Array2D(UserIn);
            ArrayPrint(arr);

        }

        public static int[][] Array2D(int size)
        {
            int[][] arrayOuter = new int[size][];

            for (int i = 0; i < arrayOuter.Length; i++)
            {
                int[] arrayInner = new int[size];

                for (int j = 0; j < arrayInner.Length; j++)
                {
                    arrayInner[j] = i;
                }
            }
            return arrayOuter;
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

