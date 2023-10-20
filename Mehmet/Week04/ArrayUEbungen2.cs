using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mehmet.Week04
{
    internal class ArrayUEbungen2
    {

        public static void start()
        {
            Arr2D();





        }

        public static Random rand = new Random();

        public static void Arr2D()
        {
            int[][] arr2d = new int[7][];
            for (int row = 0; row < arr2d.Length; row++)
            {
                arr2d[row] = new int[5];
            }


            for (int row = 0; row < arr2d.Length; row++)
            {
                for (int col = 0; col < arr2d[row].Length; col++)
                {
                    arr2d[row][col] = rand.Next(0, 100);
                }
            }


            //for (int row = 0; row < arr2d.Length; row++)
            //{
            //    for (int col = 0; col < arr2d[row].Length; col++)
            //    {
            //        Console.Write($"{arr2d[row][col],2:00}" + " ");
            //    }
            //    Console.WriteLine();

            //}





            for (int row = 0; row < arr2d.Length; row++)
            {
                int sumrow1 = 0;

                int[] currentRow = arr2d[row];

                for (int col = 0; col < arr2d[row].Length; col++)
                {
                    sumrow1 += currentRow[col];
                }

                for (int col = 0; col < arr2d[row].Length; col++)
                {
                    if (col < arr2d[row].Length - 1)
                    {
                        Console.Write($"{arr2d[row][col],2:00}" + " + ");
                    }
                    else
                    {
                        Console.Write($"{arr2d[row][col],2:00}" + "");
                    }

                }
                Console.WriteLine(" = " + sumrow1);
            }


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();



            for (int col = 0; col < arr2d.Length; col++)
            {
                int sumCol = 0;

                int[] currentCol = arr2d[col];

                for (int row = 0; row < arr2d[col].Length; row++)
                {
                    sumCol += currentCol[col];
                }

                for (int row = 0; row < arr2d[col].Length; row++)
                {
                    if (row < arr2d[col].Length - 1)
                    {
                        Console.Write($"{arr2d[row][col],2:00}" + " + ");
                    }
                    else
                    {
                        Console.Write($"{arr2d[row][col],2:00}" + "");
                    }

                }
                Console.WriteLine(" = " + sumCol);
            }



















        }



    }
}
