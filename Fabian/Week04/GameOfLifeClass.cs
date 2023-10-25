using System.Text;

namespace Fabian.Week04
{
    public class GameOfLifeClass
    {
        public static readonly Random random = new();

        public static void Start()
        {
            GameOfLife();
        }

        public static void GameOfLife()
        {
            int[,] matrix = new int[70, 100];

            /*for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = 0;
                }
            }
            // glider
            matrix[0, 1] = 1;
            matrix[1, 2] = 1;
            matrix[2, 0] = 1;
            matrix[2, 1] = 1;
            matrix[2, 2] = 1;*/



            // fill array with random nums between 0 - 1
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(0, 2);
                }
            }

            while (true)
            {
                matrix = ChangeMatrix(matrix);

                PrintMatrix(matrix);
                try
                {
                    Thread.Sleep(100);
                }
                catch (ThreadInterruptedException) { }


            }
        }
        public static int[,] ChangeMatrix(int[,] matrix)
        {
            int[,] changedMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {                                    
                    int alive = CheckAliveNeighbors(matrix, i, j);

                    if (matrix[i, j] == 1)
                    {
                        // rule 2, 3, 4
                        if (alive < 2 || alive > 3)
                        {
                            changedMatrix[i, j] = 0;
                        }
                        else
                        {
                            changedMatrix[i, j] = 1;
                        }
                    }
                    else
                    {
                        //rule 1
                        if (alive == 3)
                        {
                            changedMatrix[i, j] = 1;
                        }
                    }

                  
                }
            }
            return changedMatrix;
        }

        public static int CheckAliveNeighbors(int[,] matrix, int x, int y)
        {
            int alive = 0;

            int iStart = Math.Max(0, x - 1);
            int iEnd = Math.Min(x + 2, matrix.GetLength(0));
            int jStart = Math.Max(0, y - 1);
            int jEnd = Math.Min(y + 2, matrix.GetLength(1));

            for (int i = iStart; i < iEnd; i++)
            {
                for (int j = jStart; j < jEnd; j++)
                {
                    if (i != x || j != y)
                    {
                        alive += matrix[i, j];
                    }
                }
            }
            return alive;
        }

        public static void PrintMatrix(int[,] matrix)
        {
            StringBuilder sb = new();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        sb.Append("  ");
                    }
                    else
                    { 
                        /*ConsoleColor randomColor = (ConsoleColor)random.Next(1, 15); // random color without black(0)
                        Console.ForegroundColor = randomColor;*/

                        sb.Append((char)9632 + " ");
                    }
                }
                sb.AppendLine();
            }
            Console.SetCursorPosition(0, 0);
            Console.Write(sb.ToString());
        }
    }
}