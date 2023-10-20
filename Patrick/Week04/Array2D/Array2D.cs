using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week04
{
    internal class Array2D
    {
        public static Random random = new Random();

        public static void Start()
        {

            //AUFGABE 1:  Erstelle ein Zwei-Dimension-Array int[][] und befülle es mit Zufallszahlen von 0 bis 100. Nach Eingabe von Anwender gebe zurück die Summe pro Zeile oder pro Spalte.
            int[][] EmptyArray2D = CreateEmpty2DArray(10, 10);
            //int[][] RandomArray2D = FillRandom2DArray(EmptyArray2D, 0, 101);

            //PrintArray(EmptyArray2D);                                                 //Print empty 2DArray
            //PrintArray(RandomArray2D);                                                  //Print Random 2DArray
            //Console.WriteLine("=================");
            //int[] summeRow = SummeArray2DRow(RandomArray2D);
            //Console.Write("Summe Rows = ");
            //Console.WriteLine(string.Join(" ",summeRow));                               //Print Summe Rows

            //int[] summeColumn = SummeArray2DColumn(RandomArray2D);
            //Console.Write("Summe Columns = ");
            //Console.WriteLine(string.Join(" ", summeColumn));                           //Print Summe Column

            //AUFGABE 2: 
            //PrintArray(PascalTriangle(EmptyArray2D));

            int[][] pascal = PascalTriangle(EmptyArray2D,10, 10);
            PrintArray(pascal);

        }

        public static int[][] CreateEmpty2DArray(int sizeX, int sizeY)
        {

            int[][] array2D = new int[sizeX][];

            for (int x = 0; x < array2D.Length; x++)
            {
                array2D[x] = new int[sizeY];

            }
            return array2D;
        }

        public static void PrintArray(int[][] array)
        {
            foreach (int[] element in array)
            {
                foreach (int element2 in element)
                {
                    Console.Write("{0,7}", element2);
                }
                Console.WriteLine();
            }

        }

        public static int[][] FillRandom2DArray(int[][] array2D, int low, int high)
        {
            for (int i = 0; i < array2D.Length; i++)
            {
                for (int j = 0; j < array2D[i].Length; j++)
                {

                    int randomNumber = random.Next(low, high);
                    array2D[i][j] = randomNumber;

                }
            }
            return array2D;

        }

        public static int[][] CreateRandom2DArray(int rows, int columns, int low, int high)
        {
            int[][] array2D = new int[rows][];
            for (int i = 0; i < array2D.Length; i++)
            {
                array2D[i] = new int[columns];
                for (int j = 0; j < array2D[i].Length; j++)
                {
                    int randomNumber = random.Next(low, high);
                    array2D[i][j] = randomNumber;

                }
            }
            return array2D;

        }


        public static int[] SummeArray2DRow(int[][] array2D)
        {
            int [] result = new int[array2D.Length];
            for(int i = 0;i < array2D.Length; i++)
            {
                for (int j = 0; j < array2D[i].Length; j++)
                {
                    result[i] += array2D[i][j];
                }
            }
            return result;

        }

        public static int[] SummeArray2DColumn(int[][] array2D)
        {
            if (array2D.Length == 0)
            {
                return new int[] { };
               
            }

            int[] result = new int[array2D[0].Length];
            for (int i = 0; i < array2D.Length; i++)
            {
                for (int j = 0; j < array2D[i].Length; j++)
                {
                    result[j] += array2D[i][j];
                }
            }
            return result;

        }

        public static int[][] PascalTriangle(int[][] array2D, int row, int col)
        {
            
            Console.WriteLine("How many Rows do you want? ");
            int inputRow = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many Columns do you want?");
            int inputColumn = Convert.ToInt32(Console.ReadLine());

            //CreateEmpty2DArray(inputRow, inputColumn);
            

            for (int i = 0; i < array2D.Length; i++)
            {
                for(int j = 0; j < array2D[i].Length; j++)
                {
                    if (i == 0 ||j == 0)
                    {
                        array2D[i][j] = 1;
                    }
                    else
                    {
                        int result = array2D[i][j - 1] + array2D[i - 1][j];

                        array2D[i][j] = result;
                    }
                }
            }

            return array2D;
            
           
        }



    }
}
