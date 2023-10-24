using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hassan.Week03
{
    internal class _2DArray
    {
        public static void Start()
        {
            int[][] zufallsMatrix = GenerateRandomMatrix(3, 4); // Hier wird eine 3x4 Matrix erstellt

            Console.WriteLine("Die Zufallsmatrix:");
            for (int i = 0; i < zufallsMatrix.Length; i++)
            {
                foreach (int zahl in zufallsMatrix[i])
                {
                    Console.Write(zahl + " ");
                }
                Console.WriteLine();
            }


            int[] summenProZeile = GetRowSums(zufallsMatrix);
            int[] summenProSpalte = GetColumnSums(zufallsMatrix);

            Console.WriteLine("Summen pro Zeile:");
            for (int i = 0; i < zufallsMatrix.Length; i++)
            {
                Console.WriteLine("Zeile " + i + ": " + summenProZeile[i]);
            }

            Console.WriteLine("\nSummen pro Spalte:");
            for (int j = 0; j < zufallsMatrix[0].Length; j++)
            {
                Console.WriteLine("Spalte " + j + ": " + summenProSpalte[j]);
            }
        }

        static int[][] GenerateRandomMatrix(int rows, int cols)
        {
            int[][] zufallsMatrix = new int[rows][];

            Random rand = new Random();

            for (int i = 0; i < rows; i++)
            {
                zufallsMatrix[i] = new int[cols];
                for (int j = 0; j < cols; j++)
                {
                    zufallsMatrix[i][j] = rand.Next(101); // Zufallszahl zwischen 0 und 100
                }
            }

            return zufallsMatrix;
        }

        static int[] GetRowSums(int[][] matrix)
        {
            int[] summen = new int[matrix.Length];

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    summen[i] += matrix[i][j];
                }
            }

            return summen;
        }

        static int[] GetColumnSums(int[][] matrix)
        {
            int[] summen = new int[matrix[0].Length];

            for (int j = 0; j < matrix[0].Length; j++)
            {
                for (int i = 0; i < matrix.Length; i++)
                {
                    summen[j] += matrix[i][j];
                }
            }

            return summen;
        }
    }
}
