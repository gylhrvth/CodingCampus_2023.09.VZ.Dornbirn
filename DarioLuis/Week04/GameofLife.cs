using System;
using System.Threading;

namespace DarioLuis.Week04
{


    class GameOfLife
    {
        static int gridSizeX = 30;
        static int gridSizeY = 20;
        static bool[,] grid = new bool[gridSizeX, gridSizeY];
        static bool[,] nextGeneration = new bool[gridSizeX, gridSizeY];

        public static void Main()
        {
            InitializeGrid();
            while (true)
            {
                Console.Clear();
                DisplayGrid();
                CalculateNextGeneration();
                SwapGrids();
                Thread.Sleep(1);
            }
        }

        static void InitializeGrid()
        {
            Random random = new Random();
            for (int x = 0; x < gridSizeX; x++)
            {
                for (int y = 0; y < gridSizeY; y++)
                {
                    grid[x, y] = random.Next(2) == 0;
                }
            }
        }

        static void DisplayGrid()
        {
            for (int y = 0; y < gridSizeY; y++)
            {
                for (int x = 0; x < gridSizeX; x++)
                {
                    Console.Write(grid[x, y] ? "■" : " ");
                }
                Console.WriteLine();
            }
        }

        static void CalculateNextGeneration()
        {
            for (int x = 0; x < gridSizeX; x++)
            {
                for (int y = 0; y < gridSizeY; y++)
                {
                    int aliveNeighbors = CountAliveNeighbors(x, y);

                    if (grid[x, y])
                    {
                        nextGeneration[x, y] = aliveNeighbors == 2 || aliveNeighbors == 3;
                    }
                    else
                    {
                        nextGeneration[x, y] = aliveNeighbors == 3;
                    }
                }
            }
        }

        static int CountAliveNeighbors(int x, int y)
        {
            int count = 0;
            for (int dx = -1; dx <= 1; dx++)
            {
                for (int dy = -1; dy <= 1; dy++)
                {
                    if (dx == 0 && dy == 0)
                        continue;

                    int neighborX = (x + dx + gridSizeX) % gridSizeX;
                    int neighborY = (y + dy + gridSizeY) % gridSizeY;

                    if (grid[neighborX, neighborY])
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        static void SwapGrids()
        {
            for (int x = 0; x < gridSizeX; x++)
            {
                for (int y = 0; y < gridSizeY; y++)
                {
                    grid[x, y] = nextGeneration[x, y];
                }
            }
        }
    }
}
