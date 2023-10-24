using Selina.Week04.Ausagbe;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selina.Week04.Pascal_Dreieck
{
    internal class Pascal_Dreieck
    {
        public static void Start()
        {
            int size = CreateArray.ReadNumber("Geben Sie die Größe des Arrays ein:", "Sie müssen eine Zahl eingeben!");

            //Aufagbe 10:
            Ausgabe.Output("Aufgabe: Pascal Dreieck\n", ConsoleColor.DarkCyan);
            int[,] trinangel = GeneratePascalTriangle(size);
            PrintPascalTriangle(trinangel);
            Console.WriteLine("\n----------------------------------------------------------");


            //Aufagbe 14:
            Ausgabe.Output("Formular Generieren (Anwendung von Pascal Dreieck) \n", ConsoleColor.Cyan);
            int[][] pascalsTriangle = PascalTrinangel(size);
            PrintPascalsTriangle(pascalsTriangle);

        }

        //Aufagbe 10: Aufgabe: Pascal Dreieck 
        public static int[,] GeneratePascalTriangle(int size)
        {
            int[,] trinangel = new int[size, size];
            for (int i = 0; i < trinangel.GetLength(0); i++)
            {
                trinangel[i, 0] = 1;
                for (int j = 0; j < trinangel.GetLength(1); j++)
                {
                    if (i == 0 || j == 0)
                    {
                        trinangel[0, j] = 1;
                    }
                    else
                    {
                        int sum = trinangel[i, j - 1] + trinangel[i - 1, j];
                        trinangel[i, j] = sum;
                    }
                }
            }
            return trinangel;
        }
        public static void PrintPascalTriangle(int[,] triangle)
        {
            for (int i = 0; i < triangle.GetLength(0); i++)
            {
                for (int j = 0; j < triangle.GetLength(1); j++)
                {
                    Console.Write($"{triangle[i, j],-10}");
                }
                Console.WriteLine();
            }
        }

        //Aufagbe 14: Formular Generieren
        public static int[][] PascalTrinangel(int size)
        {
            int[][] triangle = new int[size][];

            for (int i = 0; i < size; i++)
            {
                triangle[i] = new int[i + 1];
                triangle[i][0] = 1;

                for (int j = 1; j < i; j++)
                {
                    triangle[i][j] = triangle[i - 1][j - 1] + triangle[i - 1][j];
                }

                triangle[i][i] = 1;
            }

            return triangle;

        }
        static void PrintPascalsTriangle(int[][] triangle)
        {
            int n = triangle.Length;

            for (int i = 0; i < n; i++)
            {
                int spaces = n - i - 1;
                for (int k = 0; k < spaces; k++)
                {
                    Console.Write("  ");
                }

                for (int j = 0; j <= i; j++)
                {
                    Console.Write($"{triangle[i][j]}   ");
                }

                Console.WriteLine();
            }
        }
    }
}