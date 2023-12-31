﻿namespace Gheorghe.Week01
{
    internal class Testen
    {
        public static void Start()
        {
            // Square("x", 10);
            // Rectangle("*", 3, 10);
            // PrintTriangle("x", 4);
            // PrintTriangle2("*", 5);
            // PrintTriangle3("x", 5);

            // TriangleBotomRight("*", 10);
            // EmptySquare("x", 10);
            //Square2("A", 3);
            // Slash("x", 3);
            // ForwardSlash("x", 7);
            // PrintPyramid("x", 8);
            //PrintRhombus("x", 7);
            // PrintX("x", 7);
            // ChristmasTree(16);
            PrintCirclePythagoras("*", 10);

        }
        public static void Square(string symbol, int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();

            }

        }


        public static void Rectangle(string symbol, int height, int width)
        {
            for (int row = 0; row < height; row++)
            {
                for (int col = 1; col < width; col++)
                {
                    Console.Write(symbol);

                }
                Console.WriteLine();
            }

        }

        public static void PrintTriangle(string symbol, int height)
        {
            for (int row = 0; row < height; row++)
            {
                for (int col = 0; col <= row; col++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }

        }

        public static void PrintChars(string symbol, int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write(symbol);
            }
        }

        public static void PrintTriangle2(string symbol, int rows)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = rows; j > i; j--)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();

            }
        }

        public static void PrintTriangle3(string symbol, int rows)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");

                }

                for (int k = rows; k > i; k--)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();

            }
        }

        public static void TriangleBotomRight(string symbol, int rows)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = rows - 1; j > i; j--)
                {
                    Console.Write(" ");
                }

                for (int m = -1; m < i; m++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
        }

        public static void EmptySquare(string symbol, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write(symbol);

            }
            Console.WriteLine();

            for (int zeile = 0; zeile < count; zeile++)
            {
                for (int spalte = 0; spalte < count; spalte++)
                {
                    if (spalte == 0 || spalte == count - 1)
                    {
                        Console.Write(symbol);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            for (int i = 0; i < count; i++)
            {
                Console.Write(symbol);
            }
            Console.WriteLine();
            Console.WriteLine("------------");
            Console.WriteLine("------------");
        }




        public static void Square2(string symbol, int count)
        {
            for (int y = 0; y < count; y++)
            {
                Console.WriteLine();

                for (int x = 0; x < count; x++)
                {

                    {
                        if (x == 0 || x == count - 1)
                        {
                            Console.Write(symbol);
                        }
                        else if (y == 0 || y == count - 1)
                        {
                            Console.Write(symbol);
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }


            }
        }


        public static void Slash(string symbol, int count)
        {
            for (int i = 0; i < count; i++)
            {
                for (int x = 0; x < count; x++)
                {
                    if (i == 0 && x == 0)
                    {
                        Console.Write(symbol);
                    }
                    else if (i == count - 2 && x == count - 2)
                    {
                        Console.Write(symbol);
                    }
                    else if (i == count - 1 && x == count - 1)
                    {
                        Console.Write(symbol);
                    }
                    else
                    {
                        Console.Write("0");
                    }
                }
                Console.WriteLine();
            }

        }

        public static void ForwardSlash(string symbol, int count)
        {
            for (int i = 0; i < count; i++)
            {
                for (int x = 0; x < count; x++)
                {
                    if (i == count - 1 - x)
                    {
                        Console.Write("x");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine();
            }
        }



        public static void PrintPyramid(String character, int height)
        {
            if (height == 1)
            {
                Console.WriteLine(character);
                return;
            }
            else if (height <= 0)
            {
                return;
            }

            PrintChars(" ", height - 1);
            Console.WriteLine(character);
            for (int i = 1; i < height - 1; i++)
            {
                PrintChars(" ", height - i - 1);
                Console.Write(character);
                PrintChars(" ", i * 2 - 1);
                Console.WriteLine(character);
            }
            PrintChars(character, height * 2 - 1);
        }


        public static void PrintRhombus(string symbol, int size)
        {
            for (int i = 0; i < 2 * size - 1; i++)
            {
                for (int j = 0; j < 2 * size - 1; j++)
                {
                    if (i + j == size - 1)
                    {
                        Console.Write(symbol);
                    }
                    else if (i + size - 1 == j)
                    {
                        Console.Write(symbol);
                    }
                    else if (i == j + size - 1)
                    {
                        Console.Write(symbol);
                    }
                    else if (i + j == 3 * size - 3)
                    {
                        Console.Write(symbol);
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine();

            }

        }

        public static void PrintX(string symbol, int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i == j || i + j == size - 1)
                    {
                        Console.Write(symbol);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        public static void ChristmasTree(int height)
        {
            int TreeLeaves = 1;
            int Spaces = height - 1;
            for (int i = 0; i < height; i++)
            {
                PrintSpaces(Spaces, " ");
                PrintTree(TreeLeaves, "*");

                TreeLeaves = TreeLeaves + 2;
                Spaces = Spaces - 1;
            }


            PrintBottomLeaves("0 ", height);

            int WoodenTrunk = height / 2;
            int TreeWidth = height * 2 - 1;
            int TrunkHeight = height / 3 - 1;
            int TrunkSpaces = TreeWidth / 2 - WoodenTrunk / 2;


            for (int i = 0; i < TrunkHeight; i++)
            {
                PrintSpaces(TrunkSpaces, " ");
                PrintTree(WoodenTrunk, "+ ");
            }

        }

        static void PrintSpaces(int space, string text)
        {
            for (int i = 0; i < space; i++)
            {
                Console.Write(text);
            }
        }

        static void PrintTree(int tree, string text)
        {
            PrintSpaces(tree, text);
            Console.WriteLine();
        }


        static void PrintBottomLeaves(string text, int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                Console.Write(text);
            }
            Console.WriteLine();
        }

        static void PrintCirclePythagoras(string text, int Radius)
        {
            for (int i = -Radius; i <= Radius; i++)
            {
                for (int j = -Radius; j <= Radius; j++)
                {
                    if ((i * i) + (j * j) <= Radius * Radius)
                    {
                        Console.Write(text);
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

    }

}
























