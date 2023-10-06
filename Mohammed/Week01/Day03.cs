using System;
namespace Mohammed.Week01
{
    public class Day03
    {
        private static int i;

        public Day03()
        {
        }

        public static void Start()
        {
            //printChars
            Console.WriteLine("Writing line of characters:");
            printChars("x", 10);
            Console.WriteLine();

            //printSquare
            Console.WriteLine("Writing line of Square:");
            printSquare("n", 10);
            Console.WriteLine();

            //printRect
            Console.WriteLine("Writing line of Rectangle:");
            printRect("i", 10, 3);
            Console.WriteLine();

            //PrintTriangleBottomLeft
            Console.WriteLine("Writing some line of trianleBottomLeft:");
            printTriangleBottomLeft("d", 4);
            Console.WriteLine();

            //printTriangleTopRight
            Console.WriteLine("Writing some a:");
            printTriangleTopLeft("a", 5);
            Console.WriteLine();

            //printTriangleTopRight
            Console.WriteLine("von oben nach unten richte seite:");
            printTriangleTopRight("c", 5);
            Console.WriteLine();

            //printEmptySquare
            Console.WriteLine("viereck:");
            printEmptySquare("ß", 10);
            Console.WriteLine();

            //printEmptySquare
            Console.WriteLine("printEmpatySquare");
            printEmptySquare2("i", 3);
            Console.WriteLine();

            //printSlash
            Console.WriteLine("printSlash");
            printSlash("a", 3);
            Console.WriteLine();

            //printSlash 2
            Console.WriteLine("printSlash soll von links weg gehen");
            printSlash2("d", 9);
            Console.WriteLine();

            //printTriangleLine
            Console.WriteLine(" printTriangleLine ");
            printTriangleLine("d1", 5, 4);
            Console.WriteLine();

            //printTriangle
            Console.WriteLine("es soll ein Dreieck raus kommen");
            printTriangle("v", 3);
            Console.WriteLine();

            //printTriangle2
            Console.WriteLine("die gleche würde aber als test durch gefüht");
            printTriangle2("s", 6);
            Console.WriteLine();

            //printRhombus
            //Console.WriteLine("Die Größe solldabei die Höhe des Rhombus sein!");
            //printRhombus("i", 7);
            //Console.WriteLine();

        }



        public static void printChars(string symbol, int count)
        {
            for (int x = 0; x < count; x++)
            {
                Console.Write(symbol);


            }

        }

        public static void printSquare(string symbol, int count)
        {
            for (int n = 0; n < count; n++)
            {
                printChars(symbol, count);
                Console.WriteLine();

            }
        }

        public static void printRect(string symbol, int column, int rows)
        {
            for (int i = 0; i < rows; i++)
            {
                printChars(symbol, column);
                Console.WriteLine();
            }
        }

        public static void printTriangleBottomLeft(string symbol, int rows)
        {
            for (int d = 0; d <= rows; d++)
            {
                printChars(symbol, d);
                Console.WriteLine();

            }
        }

        public static void printTriangleTopLeft(string symbol, int rows)
        {
            //for (int a = 0; a > rows; a++)
            for (int a = rows; a > 0; a--)
            {
                //printChars(symbol, rows-a);
                printChars(symbol, a);
                Console.WriteLine();
            }
        }

        public static void printTriangleTopRight(string symbol, int rows)
        {
            for (int c = 0; c < rows; c++)
            {
                printChars(symbol, c);
                Console.WriteLine();
            }
        }

        public static void printEmptySquare(string symbol, int rows)
        {

            printChars(symbol, rows);
            Console.WriteLine();


            for (int e = 0; e < rows - 2; e++)
            {
                Console.Write(symbol);

                printChars(" ", rows - 2);

                Console.WriteLine(symbol);

            }

            printChars(symbol, rows);
        }


        public static void printEmptySquare2(string character, int width)
        {
            for (int i = 0; i < width; i++)
            {
                if (i == 0 || i == width - 1)
                {
                    printChars(character, width);
                    Console.WriteLine();
                }
                else
                {
                    printChars(character, 1);
                    printChars(" ", width - 2);
                    printChars(character, 1);
                    Console.WriteLine();
                }
            }
        }


        public static void printSlash(string symbol, int rows)
        {
            for (int a = 0; a < rows; a++)
            {
                printChars(" ", a);
                printChars(symbol, 1);


                Console.WriteLine();


            }
        }

        public static void printSlash2(string symbol, int rows)
        {
            for (int d = 0; d < rows; d++)
            {
                printChars(" ", rows - d);
                printChars(symbol, -d);


                Console.WriteLine(symbol);
            }
        }


        public static void printTriangleLine(string letter, int lenPrefix, int lenMid)
        {
            for (int d1 = 0; d1 <= lenMid; d1++)
            {
                printChars(" ", lenMid - d1); // Mit - && + kann ich die richtung ändern...
                printChars("", lenMid);      // Das macht nicht viel unterschied..
                Console.WriteLine(letter);
            }
        }


        /*public static void printTriangle(string letter, int count)
        {
            for (int x = 0; x <= count; x++)
            {
                printChars(" ", count + x);
                printChars("", count);
                Console.WriteLine(letter);
            }
        }*/

        public static void printTriangle(string letter, int count)
        {
            for (int v = 0; v < count; v++)
            {
                for (int j = 0; j < count - v - 1; j++)
                {
                    Console.Write(" ");
                }


                for (int k = 0; k < 2 * v + 1; k++)
                {
                    Console.Write(count);
                }

                Console.WriteLine();
            }
        }

        public static void printTriangle2(string letter, int size)
        {
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size * 2 - 1; col++)
                {
                    if (row + size - 1 == col || row + col == size - 1 || row == size - 1) 
                    {
                        Console.Write(letter);
                    }
                    else
                    {
                        Console.Write(". ");
                    }


                }
            }
        }








        //printRhombus in week02!!
    }
}
