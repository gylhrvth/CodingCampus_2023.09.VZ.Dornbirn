using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jovo.Week04
{
    internal class PascalDreieck
    {




        public static void Start()
        {
            int[][] arr = PascalDreieck1(10, 10);
            PrintPascalDreieck(arr);

           
        }

        public static int[][] PascalDreieck1(int Rowvalue, int Colvalue)
        {
            int[][] arr2D = new int[Rowvalue][];


            for (int x = 0; x < arr2D.Length; x++)
            {
                arr2D[x] = new int[Colvalue];
            }

            for (int i = 0; i < Rowvalue; i++)
            {
                for (int j = 0; j < Colvalue; j++)
                {

                    if (i == 0 || j == 0)
                    {
                        arr2D[i][j] = 1;
                    }
                    else
                    {
                        arr2D[i][j] = arr2D[i - 1][j] + arr2D[i][j - 1];
                    }
                }
            }
            
            string stringline = Convert.ToString(arr2D[Rowvalue - 1][Colvalue - 1]);
           //Console.WriteLine("Unsere größte Zahl ist: " + stringline);
            //Console.WriteLine("Die Länge dieser Zahl ist: " + stringline.Length);
           
            return arr2D;
           
        }



       

        public static void PrintPascalDreieck(int[][] arr2D)
        {

            foreach (int[] RowElement in arr2D)
            {
                foreach (int ColElement in RowElement)
                {
                    Console.Write($"{ColElement,8}");
                }
                Console.WriteLine();
            }
        }
    }
}

