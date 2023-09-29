using System;
namespace Fabienne.Week01
{
    public class Printcharacters
    {
        public static void Start()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            PrintChars('x', 10, true);
            Console.WriteLine();

            PrintChars2('x', 10);
            Console.WriteLine();

            PrintRect('x', 10, 3);
            Console.WriteLine();

            PrintTriangleBottomLeft('x', 4);
            Console.WriteLine();

            PrintTriangleTopLeft('x', 5);
            Console.WriteLine();

            PrintTriangleTopRight('x', 5);
            Console.WriteLine();

            PrintTriangleBottomRight('x', 5);
            Console.WriteLine();

            PrintEmptySquare('x', 10);
            Console.WriteLine();

            PrintEmptySquareA('A', 3);
            Console.WriteLine();

            PrintSlash('x', 3, false);
            Console.WriteLine();

            PrintSlash2('y', 4, false);
            Console.WriteLine();

            PrintTriangle5('x', 2);
            Console.WriteLine();

            PrintTriangle5('x', 5);
            Console.WriteLine();

            PrintTriangle5('x', 1);
            Console.WriteLine();

            PrintRhombus('x', 4);
            Console.WriteLine();

            PrintX('x', 4);
            Console.WriteLine();

            PrintChristmastree(9); 
            Console.WriteLine();

            
           /* bool toggle = true;
            int i = 0;
            Console.Write("\u001b[31m");
            while(true)
            {
                if(toggle)
                {
                    i++;
                }
                else
                {
                    i--;
                }

                if(i == 30 || i == 0)
                {
                    toggle = !toggle;
                }
            
             PrintTriangle5('x', 5); //i
            
                Thread.Sleep(100);
                Console.Clear();
            }

            Console.Write("\u001b[0m"); */

           
        }

        //print chars

        
        public static void PrintChars(char x, int anzahl, bool newline)
        {
  

            for (int i = 0; i < anzahl; i++)
            {
                Console.Write(x);
            }
            if (newline)
            {
                Console.WriteLine();
            }
        }

        //print square

        public static void PrintChars2(char x, int anzahl)
        {
            Console.WriteLine("PrintChars2 (\'" + x + "\', " + anzahl + ")");

            for (int j = 0; j < anzahl; j++)
            {
                for (int i = 1; i < anzahl; i++)
                {
                    Console.Write(x);
                }

                Console.WriteLine(x);
            }
        }

        //print rectangle

        public static void PrintRect(char x, int anzahl, int row)
        {
            Console.WriteLine("PrintRect (\'" + x + "\', " + anzahl + ")");

            for (int j = 0; j < row; j++)
            {
                for (int i = 1; i < anzahl; i++)
                {
                    Console.Write(x);
                }

                Console.WriteLine(x);
            }
        }

        //print triangle

        public static void PrintTriangleBottomLeft(char x, int anzahl)
        {
            Console.WriteLine("PrintTriangleBottomLeft (\'" + x + "\', " + anzahl + ")");

            for (int j = 0; j < anzahl; j++)
            {
                for (int i = 0; i < j; i++)
                {
                    Console.Write(x);
                }

                Console.WriteLine(x);
            }
        }

        //print triangle 2

        public static void PrintTriangleTopLeft(char x, int anzahl)
        {
            Console.WriteLine("PrintTriangleTopLeft (\'" + x + "\', " + anzahl + ")");

            for (int j = 0; j < anzahl; j++)
            {
                for (int i = anzahl - 1; i > j; i--)
                {
                    Console.Write(x);
                }

                Console.WriteLine(x);
            }
        }

        //print triangle 3

        public static void PrintTriangleTopRight(char x, int anzahl)
        {
            Console.WriteLine("PrintTriangleTopRight (\'" + x + "\', " + anzahl + ")");

            for (int j = 0; j < anzahl; j++)
            {
                PrintChars(' ', j, false);
                PrintChars(x, anzahl - j, true); 
            }
        }

        //print triangle 4

        public static void PrintTriangleBottomRight(char x, int anzahl)
        {
            Console.WriteLine("PrintTriangleBottomRight (\'" + x + "\', " + anzahl + ")");

            for (int i = 0; i < anzahl; i++)
            {
                PrintChars(' ', anzahl - i - 1, false);
                PrintChars(x, i + 1, true);
            }
        }

        //print empty square

        public static void PrintEmptySquare(char x, int anzahl)
        {
            Console.WriteLine("PrintRmptySquare (\'" + x + "\', " + anzahl + ")");

            PrintChars(x, anzahl, true);

            for (int a = 0; a < anzahl-2; a++)
            {
                Console.Write(x);

                PrintChars(' ', anzahl - 2, false);

                Console.WriteLine(x);
            }

            PrintChars(x, anzahl, true);
  
        }

        //print empty square

        public static void PrintEmptySquareA(char A, int anzahl)
        {
            Console.WriteLine("PrintEmptySquare (\'" + A + "\', " + anzahl + ")");

            PrintChars(A, anzahl, true);

            for (int a = 0; a < anzahl - 2; a++)
            {
                Console.Write(A);

                PrintChars(' ', anzahl - 2, false);

                Console.WriteLine(A);
            }

            PrintChars(A, anzahl, true);
        }

        //print slash

        public static void PrintSlash(char x, int anzahl, bool newline)
        {
            Console.WriteLine("PrintSlash (\'" + x + "\', " + anzahl + ")");

            for (int j = 0; j < anzahl; j++)
            {
                PrintChars(' ', j, false);
                PrintChars(x, anzahl - 2, true);              
            }
        }

        // print slash 2

        public static void PrintSlash2(char y, int anzahl, bool newline)
        {
            Console.WriteLine("PrintSlash2 (\'" + y + "\', " + anzahl + ")");

            for (int i = 0; i < anzahl; i++)
            {
                PrintChars(' ', anzahl - i - 1, false);
                PrintChars(y, anzahl - 3, true);
            }
        }

        //print triangle 5 !!!!!

        public static void PrintTriangle5(char x, int anzahl)
        {
            Console.WriteLine("PrintTriangle5 (\'" + x + "\', " + anzahl + ")");

            if (anzahl <= 0)
            {
                return;
            }
             
            if (anzahl == 1)
            {
                Console.WriteLine(x);
                return;
            }

            PrintChars(' ', anzahl, false);
            Console.WriteLine(x);

            for (int i = 1; i < anzahl; i++)
            {
                PrintChars(' ', anzahl - i, false);
                Console.Write(x);

                PrintChars(' ', i * 2 - 1, false);
                Console.WriteLine(x);
            }

            PrintChars(x, anzahl * 2 + 1, true);
        }

        //print rhombus

        public static void PrintRhombus(char x, int anzahl)
        {
            Console.WriteLine("PrintRhombus (\'" + x + "\', " + anzahl + ")");

            PrintChars(' ', anzahl, false);
            Console.WriteLine(x);

            for (int i = 1; i < anzahl - 1; i++)
            {
                PrintChars(' ', anzahl - i, false);
                Console.Write(x);

                PrintChars(' ', i * 2 - 1, false);
                Console.WriteLine(x);
            }

            for (int j = 1; j < anzahl; j++)
            {
                PrintChars(' ', j, false);
                Console.Write(x);

                PrintChars(' ', ((anzahl - j) * 2) - 1, false);
                Console.WriteLine(x);
            }

            PrintChars(' ', anzahl, false);
            Console.WriteLine(x);
        }

        //print x

        public static void PrintX(char x, int anzahl)
        {
            Console.WriteLine("PrintX (\'" + x + "\', " + anzahl + ")");

            for (int j = 3; j < anzahl; j++)
            {
                PrintChars(' ', j, false);
                Console.Write(x);

                PrintChars(' ', ((anzahl - j) * 2) - 1, false);
                Console.WriteLine(x);
            }

            PrintChars(' ', anzahl, false);
            Console.WriteLine(x);

            for (int i =1; i < anzahl - 2; i++)
            {
                PrintChars(' ', anzahl - i, false);
                Console.Write(x);

                PrintChars(' ', i * 2 - 1, false);
                Console.WriteLine(x);
            }

        }

        //print christmas tree

        public static void PrintChristmastree(int anzahl)
        { 
            Console.WriteLine("PrintChristmastree (" + anzahl + ")");

            Console.ForegroundColor = ConsoleColor.DarkGreen;

            if (anzahl <= 0)
            {
                return;
            }
           
            
            PrintChars(' ', anzahl, false);
            Console.WriteLine("*");

            for (int i = 1; i < anzahl; i++)
            {
                PrintChars(' ', anzahl - i, false);
                Console.Write("*");

                PrintChars('*', i * 2 - 1, false);
                Console.WriteLine("*");
            }
            
            PrintChars('*', anzahl * 2 + 1, true);

            Console.ForegroundColor = ConsoleColor.DarkRed;

            for (int j = 0; j <= anzahl; j++)
            {
                PrintChars('O', 1, false);
                PrintChars(' ', 1, false);
            }

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkGray;

            for (int i = 0; i < 2; ++i)
            {
                PrintChars(' ', anzahl - 3, false);
                PrintChars('+', anzahl - 2, false);
                Console.WriteLine();
            }
        }
    }
}
