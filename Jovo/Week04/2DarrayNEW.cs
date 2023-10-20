using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Jovo.Week04
{
    internal class _2DArrayNew
    {

        public static void Start()
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
            

           




            for (int row = 0; row < arr2d.Length; row++)
            {
                int sumrow1 = 0;

                //int[] currentRow = arr2d[row];

                for (int col = 0; col < arr2d[row].Length; col++)
                {
                    sumrow1 += arr2d[row][col]; //currentRow[col];
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


            Console.WriteLine("=    =    =    =    =");

            for (int row = 0; row < arr2d[0].Length; ++row)
            {
                int sum = 0;

                for (int col = 0; col < arr2d.Length; col++)
                {

                    sum += arr2d[col][row];

                }
                
                Console.Write(sum + "  ");
            }


        }
    }
}
