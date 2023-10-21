namespace Fabian.Week04
{
    public class GameOfLifeClass
    {
        public static void Start()
        {
            GameOfLife();
        }

        public static void GameOfLife()
        {
            Random random = new();

            int[,] matrix = new int[40, 40];

           /*for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = 0;
                }
            }
            matrix[0, 1] = 1;
            matrix[1, 2] = 1;
            matrix[2, 0] = 1;
            matrix[2, 1] = 1;
            matrix[2, 2] = 1;*/



            
            //fill matrix with random nums between 0 - 1
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(0, 2);
                }
            }

            PrintMatrix(matrix);
            while (true)
            {
                matrix = ChangeMatrix(matrix);

                try
                {
                    Thread.Sleep(100);
                }
                catch (ThreadInterruptedException) { }

                Console.Clear();
                PrintMatrix(matrix);
            }
        }

        public static int[,] ChangeMatrix(int[,] matrix)
        {
            int[,] changedMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    int alive = CountAliveNeighbors(matrix, i, j);

                    if (matrix[i, j] == 1)
                    {
                        // rule 2, 4
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
                        // rule 1
                        if (alive == 3)
                        {
                            changedMatrix[i, j] = 1;
                        }
                    }
                }
            }
            return changedMatrix;
        }

        public static int CountAliveNeighbors(int[,] matrix, int x, int y)
        {
            int alive = 0;
            int iStart = Int32.Max(0, x - 1);
            int iEnd = Int32.Min(x + 2, matrix.GetLength(0));

            int jStart = Int32.Max(0, y - 1);
            int jEnd = Int32.Min(y + 2, matrix.GetLength(1));


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

        public static int[,] PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    Console.Write((char)9632 + " ");
                }
                Console.WriteLine();
            }

            return matrix;
        }


    }


}
