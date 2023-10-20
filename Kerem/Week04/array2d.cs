using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Kerem.Week04
{
    internal class array2d
    {
        public static Random generator = new Random();
        public static void Start()
        {
            int[][] arr2d = Create2darray(3, 5);
            print2darray(arr2d);

            int[] sumrow = SumbyRow(arr2d);
            Console.WriteLine(string.Join(" " , sumrow));

            int[] sumcol = SumbyCol(arr2d);
            Console.WriteLine(string.Join(" ", sumcol));



        }
        public static int[][] Create2darray(int rows, int cols)
        {
            int[][] arr = new int[rows][];
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = new int[cols];
                for(int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = generator.Next(0, 100);
                }
            }
            return arr;
        }
        public static void print2darray(int[][] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = 0;j < arr[i].Length; j++)
                {
                    Console.Write("{0,4}" , arr[i][j]);
                }
                Console.WriteLine();
            }
        }
        public static int[] SumbyRow(int[][] arr)
        {
            if(arr.Length == 0)
            {
                return new int[] { };
            }

            int[] result = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    result[i] += arr[i][j];
                }
               
            }
            return result;
        }
        public static int[] SumbyCol(int[][] arr)
        {
            int[] result = new int[arr[0].Length];
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    result[j] += arr[i][j];
                }

            }
            return result;
        }






    }
}
