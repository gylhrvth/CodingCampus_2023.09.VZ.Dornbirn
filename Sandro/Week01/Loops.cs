using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandro.Week01
{
    internal class Loops
    {
        public static void Start() {
            Console.WriteLine("Aufgabe Print Characters");
            PrintChars("x", 10);
            Console.WriteLine();
            Console.WriteLine("Aufgabe Print Square");
            PrintSpuare("x", 10);
            Console.WriteLine();
            Console.WriteLine("Aufgabe Print Square");
            PrintRectangle("x", 10, 3);
            Console.WriteLine();
            Console.WriteLine("Aufgabe Print Triangle (1)");
            PrintTriangle1("x", 5);
            Console.WriteLine();
            Console.WriteLine("Aufgabe Print Triangle (2)");
            PrintTriangle2("x", 5);
            Console.WriteLine();
            Console.WriteLine("Aufgabe Print Triangle (3)");
            PrintTriangle3("x", 5);
            Console.WriteLine();
            Console.WriteLine("Aufgabe Print Triangle (4)");
            PrintTriangle4("x", 5);
            Console.WriteLine();
            Console.WriteLine("Aufgabe Print EmptySquare (1)");
            PrintEmptySquare1("x", 10);
            Console.WriteLine();
            Console.WriteLine("Aufgabe Print EmptySquare (2)");
            PrintEmptySquare2("x", 10);
            Console.WriteLine();
            Console.WriteLine("Aufgabe Print Slash");
            PrintSlash("x", 3, false);
            Console.WriteLine();
            Console.WriteLine("Aufgabe Print Pyramid");
            PrintPyramid("x", 3);
            Console.WriteLine();
            Console.WriteLine("Aufgabe Print Rhombus");
            PrintRhombus("x", 20);
            Console.WriteLine();
            Console.WriteLine("Aufgabe Print X");
            PrintX("x", 5);
            Console.WriteLine();
            Console.WriteLine("Aufgabe Print ChristmasTree");
            PrintChristmasTree(16);
            Console.WriteLine();
            Console.WriteLine("Aufgabe Print CirclePythagoras");
            PrintCirclePythagoras("X", 22);
            Console.WriteLine();


        }

        static void PrintChars(String Text, int length)
        {
            for (int i = 0; i <= length; i++)
            {
                Console.Write(Text);
            }
            Console.WriteLine();
        }

        static void PrintSpuare(String Text, int size)
        {
            for (int i = 0; i <= size; i++)
            {
                for (int j = 0; j <= size; j++)
                {
                    Console.Write(Text);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void PrintRectangle(String Text, int Width, int Height)
        {
            for (int i = 0; i <= Height; i++)
            {
                for (int j = 0; j <= Width; j++)
                {
                    Console.Write(Text);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void PrintTriangle1(String Text, int Size)
        {
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(Text);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void PrintTriangle2(String Text, int Size)
        {
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < (Size - i); j++)
                {
                    Console.Write(Text);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void PrintTriangle3(String Text, int Size)
        {
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    if (i <= j)
                    {
                        Console.Write(Text);
                    }
                    else
                    {
                        Console.Write(".");
                    }

                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void PrintTriangle4(String Text, int Size)
        {
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    if (i + j >= Size - 1)
                    {
                        Console.Write(Text);
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

        static void PrintEmptySquare1(String Text, int Size)
        {
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    if (i == 0)
                    {
                        Console.Write(Text);
                    }
                    else if (j == 0)
                    {
                        Console.Write(Text);
                    }
                    else if (i == Size - 1)
                    {
                        Console.Write(Text);
                    }
                    else if (j == Size - 1)
                    {
                        Console.Write(Text);
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


        static void PrintEmptySquare2(String Text, int Size)
        {
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    if (i == 0)
                    {
                        Console.Write("1");
                    }
                    else if (j == 0)
                    {
                        Console.Write("2");
                    }
                    else if (i == Size - 1)
                    {
                        Console.Write("3");
                    }
                    else if (j == Size - 1)
                    {
                        Console.Write("4");
                    }
                    else if (i == 1)
                    {
                        Console.Write("5");
                    }
                    else if (j == 1)
                    {
                        Console.Write("6");
                    }
                    else if (i == Size - 1 - 1)
                    {
                        Console.Write("7");
                    }
                    else if (j == Size - 1 - 1)
                    {
                        Console.Write("8");
                    }
                    else
                    {
                        Console.Write("0");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void PrintSlash(String Text, int Size, bool Backslash)
        {
            if (Backslash == true)
            {
                for (int i = 0; i < Size; i++)
                {
                    for (int j = 0; j < Size; j++)
                    {
                        if (i == j)
                        {
                            Console.Write(Text);
                        }
                        else
                        {
                            Console.Write('.');
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            else
            {
                for (int i = 0; i < Size; i++)
                {
                    for (int j = 0; j < Size; j++)
                    {
                        if (i + j == Size - 1)
                        {
                            Console.Write(Text);
                        }
                        else
                        {
                            Console.Write(".");
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

        }

        static void PrintPyramid(String text, int Size)
        {
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < 2 * Size - 1; j++)
                {
                    if (i + j == Size - 1 || j == Size + i - 1 || i == Size - 1)
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
        }

        static void PrintRhombus(String text, int Size)
        {
            Size = Size / 2 + Size % 2;
            for (int i = 0; i < 2 * Size - 1; i++)
            {
                for (int j = 0; j < 2 * Size - 1; j++)
                {
                    if (i + j == Size - 1 || j == Size + i - 1 || j == i - Size + 1 || i + j == 3 * (Size - 1))
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

        static void PrintX(String text, int Size)
        {
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    if (i == j || i + j == Size - 1)
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

        static void PrintChristmasTree(int Height)
        {
            int TreeLeave = 1;
            int Spaces = Height - 1;
            for (int i = 0; i < Height; i++)
            {
                PrintSpaces(Spaces, " ");
                PrintTree(TreeLeave, "*");

                TreeLeave = TreeLeave + 2;
                Spaces = Spaces - 1;
            }
            PrintBottomLeaves("O ", Height);

            int WoodenTrunk = Height / 2;
            int TreeWidth = Height * 2 - 1;
            int TrunkHeight = Height / 3 - 1;
            int TrunkSpaces = TreeWidth / 2 - WoodenTrunk / 2;

            for (int i = 0; i < TrunkHeight; i++)
            {
                PrintSpaces(TrunkSpaces, " ");
                PrintTree(WoodenTrunk, "+");
            }


        }

        static void PrintSpaces(int Spaces, String text)
        {
            for (int i = 0; i < Spaces; i++)
            {
                Console.Write(text);
            }
        }

        static void PrintTree(int Tree, String text)
        {
            PrintSpaces(Tree, text);
            Console.WriteLine();
        }

        static void PrintBottomLeaves(String text, int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                Console.Write(text);
            }
            Console.WriteLine();
        }

        static void PrintCirclePythagoras(String Text, int Radius)
        {
            for (int i = -Radius; i <= Radius; i++)
            {
                for (int j = -Radius; j <= Radius; j++)
                {
                    if ((i * i) + (j * j) <= Radius * Radius)
                    {
                        Console.Write(Text);
                    }
                    else
                    {
                        Console.Write(".");
                    }

                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

    }
}
