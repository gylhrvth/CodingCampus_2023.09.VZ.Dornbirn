using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Michael.Week10_maybe.WaveCollapseAlgorithm
{
    internal class Main
    {
        public static void Start()
        {

            Random rnd = new Random();

            Console.WriteLine("height");
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine("width");
            int width = int.Parse(Console.ReadLine());

            Tile[,] field = new Tile[height, width];


            // filling field with tiles
            for (int row = 0; row < height; row++)
            {
                for (int col = 0; col < width; col++)
                {
                    field[row, col] = new Tile();
                }
            }


            // connecting neighbors
            for (int row = 0; row < height; row++)
            {
                for (int col = 0; col < width; col++)
                {
                    try
                    {
                        field[row, col].AddNeighbor(field[row + 1, col], Direction.Down);
                    }
                    catch { }

                    try
                    {
                        field[row, col].AddNeighbor(field[row - 1, col], Direction.Up);
                    }
                    catch { }

                    try
                    {
                        field[row, col].AddNeighbor(field[row, col + 1], Direction.Right);
                    }
                    catch { }

                    try
                    {
                        field[row, col].AddNeighbor(field[row, col - 1], Direction.Left);
                    }
                    catch { }
                }
            }

            bool stillUnclear = true;
            while (stillUnclear)
            {
                stillUnclear = false;


                // collapse lowest entropy node
                Tile currentTile = GetLowestEntropy();
                currentTile.Collapse();

                Console.SetCursorPosition(0, 0);
                PrintField();

                // updating all tiles
                bool stillUpdating = true;
                while (stillUpdating)
                {
                    stillUpdating = false;
                    for (int row = 0; row < height; row++)
                    {
                        for (int col = 0; col < width; col++)
                        {
                            Tile tile = field[row, col];
                            stillUpdating = stillUpdating || tile.AdjustProbSpace();
                        }
                    }
                }



                //tests if everything is collapsed
                for (int row = 0; row < height; row++)
                {
                    for (int col = 0; col < width; col++)
                    {
                        if (field[row, col].GetProbSpace().Count != 1)
                        {
                            stillUnclear = true;
                        }
                    }
                }
            }

            Console.ReadLine();





            void PrintField()
            {
                for (int row = 0; row < height; row++)
                {
                    for (int col = 0; col < width; col++)
                    {
                        Console.Write(field[row, col]);
                    }
                    Console.WriteLine();
                }
            }

            Tile GetLowestEntropy()
            {
                List<Tile> currentMins = new List<Tile>();

                for (int row = 0; row < height; row++)
                {
                    for (int col = 0; col < width; col++)
                    {
                        if (field[row, col].Collapsed == false)
                        {
                            currentMins = new List<Tile> { field[row, col] };
                            break;
                        }
                    }
                    if (currentMins.Count != 0) break;
                }

                for (int row = 0; row < height; row++)
                {
                    for (int col = 0; col < width; col++)
                    {
                        if (field[row, col].GetProbSpace().Count < currentMins[0].GetProbSpace().Count && field[row, col].Collapsed == false)
                        {
                            currentMins.Clear();
                            currentMins.Add(field[row, col]);
                        }
                        else if (field[row, col].GetProbSpace().Count == currentMins[0].GetProbSpace().Count && field[row, col].Collapsed == false)
                        {
                            currentMins.Add(field[row, col]);
                        }
                    }
                }

                return currentMins[rnd.Next(currentMins.Count)];
            }
        }
    }
}
