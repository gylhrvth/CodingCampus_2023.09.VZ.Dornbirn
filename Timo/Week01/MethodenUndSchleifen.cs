using System;
namespace Timo.Week01
{
    public class MethodenUndSchleifen
    {

        public static void Start()
        {
            Console.WriteLine("\n1.Aufgabe:");
            PrintChars('x', 5);

            Console.WriteLine("\n2.Aufgabe:");
            PrintSquare('x', 5);

            Console.WriteLine("\n3.Aufgabe:");
            PrintRectangle('x', 5, 8);

            Console.WriteLine("\n4.Aufgabe:");
            PrintTriangleBottomLeft('x', 5);

            Console.WriteLine("\n5.Aufgabe");
            PrintTriangleTopLeft('x', 5);

            Console.WriteLine("\n6.Aufgabe");
            PrintTriangleTopRight('x', 5);

            Console.WriteLine("\n7.Aufgabe");
            PrintTriangleBottomRight('x', 5);

            Console.WriteLine("\n8.Aufgabe");
            PrintEmptySquare('x', 6);

            Console.WriteLine("\n9.Aufgabe - true");
            PrintSlash('x', 5, true);

            Console.WriteLine("\n9.Aufgabe - false");
            PrintSlash('x', 5, false);

            Console.WriteLine("\n10.Aufgabe - 1x");
            PrintTriangle('x', 1);

            Console.WriteLine("\n10.Aufgabe - mehr x");
            PrintTriangle('x', 30);

            Console.WriteLine("\n11.Aufgabe");
            PrintRhombus('x', 7);



            int h = 7;
            Console.WriteLine((h / 2));
        }

        //Aufgabe1
        public static void PrintChars(char symbol, int zahl)
        {
            for (int x = 0; x < zahl; x++)
            {
                Console.Write(symbol);
            }
            return;
        }
        //Aufgabe2
        public static void PrintSquare(char symbol, int zahl)
        {
            for (int y = 0; y < zahl; y++)
            {
                PrintChars(symbol, zahl);
                Console.Write("\n");
            }
            return;
        }
        //Aufgabe3
        public static void PrintRectangle(char symbol, int zahl, int hoehe)
        {
            for (int y = 0; y < hoehe; y++)
            {
                PrintChars(symbol, zahl);
                Console.Write("\n");
            }
            return;
        }
        //Aufgabe4
        public static void PrintTriangleBottomLeft(char symbol, int zahl)
        {
            int x = 0;
            while (x < zahl)
            {
                int y = 0;
                while ((y - 1) < x)
                {
                    Console.Write(symbol);
                    y++;
                }
                Console.Write("\n");
                x++;
            }
        }
        //Aufgabe5
        public static void PrintTriangleTopLeft(char symbol, int zahl)
        {
            int x = zahl;
            while (x > 0)
            {
                int y = 0;
                while (y < x)
                {
                    Console.Write(symbol);
                    y++;
                }
                Console.Write("\n");
                x--;
            }
        }
        /*//Aufgabe6
        public static void PrintTriangleTopRight(char symbol, int zahl)
        {
            int x = zahl;
            int a = 0; 
            while (x > 0)
            {
                int z = a;
                int y = 0;
                while (zahl-z < (zahl)) 
                {
                    Console.Write(" ");
                    z--;
                }
                while (y < x)
                {
                    Console.Write(symbol);
                    y++;
                }
                Console.Write("\n");
                a++;
                x--;
            }
        }*/
        //Aufgabe6.2
        public static void PrintTriangleTopRight(char symbol, int zahl)
        {
            for (int i = 0; i < zahl; i++)
            {
                int spaces = i;
                int characters = zahl - i;
                PrintChars(' ', spaces);
                PrintChars(symbol, characters);
                Console.WriteLine();
            }

        }
        //Aufgabe7
        public static void PrintTriangleBottomRight(char symbol, int zahl)
        {

            for (int i = 0; i < zahl; i++)
            {
                int spaces = i;
                int characters = zahl - i;
                PrintChars(' ', characters - 1);
                PrintChars(symbol, i + 1);
                Console.WriteLine();
            }
        }
        //Aufgabe8
        public static void PrintEmptySquare(char symbol, int zahl)
        {
            for (int i = 0; i < zahl; i++)
            {
                if (i == 0 || i == zahl - 1)
                {
                    PrintChars(symbol, zahl);
                    Console.Write("\n");
                }
                else
                {
                    {
                        Console.Write(symbol);
                        PrintChars(' ', zahl - 2);
                        Console.Write(symbol);
                        Console.WriteLine();

                    }
                }
            }
        }
        //Aufgabe9
        public static void PrintSlash(char symbol, int zahl, bool backslash)
        {
            if (backslash)
            {
                for (int i = 0; i < zahl; i++)
                {
                    int spaces = i;
                    int characters = zahl - i;
                    PrintChars(' ', spaces);
                    Console.Write(symbol);
                    Console.WriteLine();
                }
            }
            else
            {
                for (int i = 0; i < zahl; i++)
                {
                    int spaces = i;
                    int characters = zahl - i;
                    PrintChars(' ', characters - 1);
                    Console.Write(symbol);
                    Console.WriteLine();
                }
            }
        }
        //Aufgabe10
        public static void PrintTriangle(char symbol, int zahl)
        {
            if (zahl == 1)
            {
                PrintChars(symbol, zahl);
            }
            else
            {
                PrintChars('.', zahl - 1);
                Console.WriteLine(symbol);
                int spacedifferent = 1;
                for (int i = 1; i < zahl - 1; i++)
                {
                    int spaces = i;
                    int characters = zahl - i;
                    PrintChars('.', characters - 1);
                    Console.Write(symbol);
                    for (int a = spacedifferent; a > 0; a--)
                    {
                        Console.Write('.');
                    }
                    Console.Write(symbol);
                    spacedifferent = spacedifferent + 2;
                    Console.WriteLine();
                }
                PrintChars(symbol, (zahl * 2) - 1);
            }
        }
        //Aufgabe11.1
        public static void PrintRhombus(char symbol, int zahl)
        {
            PrintChars('.', zahl / 2);
            Console.WriteLine(symbol);
            int spacedifferent = 1;
            for (int i = 1; i < ((zahl / 2) + 1); i++)
            {
                int spaces = i;
                int characters = zahl / 2 + 1 - i;
                PrintChars('.', characters - 1);
                Console.Write(symbol);
                for (int a = spacedifferent; a > 0; a--)
                {
                    Console.Write('.');
                }
                Console.Write(symbol);
                spacedifferent = spacedifferent + 2;
                Console.WriteLine();
            }
            int space2 = spacedifferent-4;
            for (int i = 1; i < ((zahl -1)/ 2); i++)
            {
                int spaces = i;
                int characters = zahl / 2 + 1 - i;
                PrintChars('.', i);
                Console.Write(symbol);
                for (int a = space2; a > 0; a--)
                {
                    Console.Write('.');
                }
                Console.Write(symbol);
                space2 = space2 - 2;
                Console.WriteLine();
            }
            PrintChars('.', zahl/2);
            Console.WriteLine(symbol);
        }
    }
}