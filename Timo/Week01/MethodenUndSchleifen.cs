using System;
using System.Drawing;

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
            PrintRectangle('x', 21, 10);

            Console.WriteLine("\n4.Aufgabe:");
            PrintTriangleBottomLeft('x', 5);

            Console.WriteLine("\n5.Aufgabe:");
            PrintTriangleTopLeft('x', 5);

            Console.WriteLine("\n6.Aufgabe:");
            PrintTriangleTopRight('x', 5);

            Console.WriteLine("\n7.Aufgabe:");
            PrintTriangleBottomRight('x', 5);


            Console.WriteLine("\n8.Aufgabe:");
            PrintEmptySquare('x', 15);

            Console.WriteLine("\n9.Aufgabe - true:");
            PrintSlash('x', 15, true);

            Console.WriteLine("\n9.Aufgabe - false:");
            PrintSlash('x', 15, false);

            Console.WriteLine("\n10.Aufgabe - 1x:");
            PrintPyramid('x', 1);

            Console.WriteLine("\n10.Aufgabe - mehr x:");
            PrintPyramid('x', 10);
            
            Console.WriteLine("\n11.Aufgabe:");
            PrintRhombus('x', 7);
            
            Console.WriteLine("\n12.Aufgabe:");
            PrintX('x', 7);
            
            Console.WriteLine("\n13.Aufgabe:");
            PrintChristmasTree(50);

            Console.WriteLine("\n14.Aufgabe:");
            PrintCirclePythagoras(10);

            Console.WriteLine("\n15.Aufgabe:");
            PrintCircleSinCos(10);
            
        }


        //Aufgabe1
        public static void PrintChars(char symbol, int zahl)
        {
            for (int x = 0; x < zahl; x++)
            {
                Console.Write(symbol);
            }
        }


        public static void PrintString(string symbol, int zahl)
        {
            for (int x = 0; x < zahl; x++)
            {
                Console.Write(symbol);
            }
        }


        //Aufgabe2
        public static void PrintSquare(char symbol, int zahl)
        {
            for (int y = 0; y < zahl; y++)
            {
                PrintChars(symbol, zahl);
                Console.Write("\n");
            }
        }


        //Aufgabe3
        public static void PrintRectangle(char symbol, int zahl, int hoehe)
        {
            for (int y = 0; y < hoehe; y++)
            {
                PrintChars(symbol, zahl);
                Console.Write("\n");
            }
        }


        //Aufgabe 4 Version 2
        public static void PrintTriangleBottomLeft(char symbol, int zahl)
        {
            for (int i = 0; i < zahl; i++)
            {
                for (int j = 0; j < zahl; j++)
                {
                    if (j <= i)
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


        //Aufgabe5 Version 2
        public static void PrintTriangleTopLeft(char symbol, int zahl)
        {
            for (int i = 0; i < zahl; i++)
            {
                for (int j = 0; j < zahl; j++)
                {
                    if (j <= zahl - 1 - i)
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


        //Aufgabe6 Version 3
        public static void PrintTriangleTopRight(char symbol, int zahl)
        {
            for (int i = 0; i < zahl; i++)
            {
                for (int j = 0; j < zahl; j++)
                {
                    if (j >= i)
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
        

        //Aufgabe7 Version2
        public static void PrintTriangleBottomRight(char symbol, int zahl)
        {
            for (int i = 0; i < zahl; i++)
            {
                for (int j = 0; j < zahl; j++)
                {
                    if (j >= zahl - 1 - i)
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

        
        //Aufgabe8
        public static void PrintEmptySquare(char symbol, int zahl)
        {
            for (int i = 0; i < zahl; i++)
            {
                if (i == 0 || i == zahl - 1)
                {
                    PrintChars(symbol, zahl);
                    Console.WriteLine();
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


        //Aufgabe 10 Version2
        public static void PrintPyramid(char symbol, int zahl)
        {
            for (int height = 0; height < zahl; height++)
            {
                for (int with = 0; with < zahl * 2 - 1; with++)
                {
                    if (with == height + zahl - 1 || with == zahl - height - 1 || height == zahl - 1)
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
        

        //Aufgabe11 Version 2
        public static void PrintRhombus(char symbol, int zahl)
        {
            for (int height = 0; height<zahl; height++)
            {
                for(int with = 0;with < zahl; with++)
                {
                    if(with == height + zahl/2 || with == zahl / 2 - height|| with + zahl - 1 == height + zahl / 2|| with - zahl + 1 == zahl / 2 - height)
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


        //Aufgabe 12 Version 2
        public static void PrintX(char symbol, int zahl)
        {
            for (int height = 0; height < zahl; height++)
            {
                for (int with = 0; with < zahl; with++)
                {
                    if (with == height    ||with  == zahl - height -1 )
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


        //Aufgabe13
        public static void PrintChristmasTree(int zahl)
        {
            PrintChars(' ', zahl - 1);
            Console.WriteLine('*');
            int spacedifferent = 1;
            for (int i = 1; i < zahl - 1; i++)
            {
                int characters = zahl - i;
                PrintChars(' ', characters - 1);
                Console.Write('*');
                for (int a = spacedifferent; a > 0; a--)
                {
                    Console.Write('*');
                }
                Console.Write('*');
                spacedifferent = spacedifferent + 2;
                Console.WriteLine();
            }
            PrintChars('*', (zahl * 2) - 1);
            Console.WriteLine();
            PrintString("0 ", zahl);
            Console.WriteLine();
            int b = 0;
            while (b < 2)
            {
                PrintChars(' ', (zahl * 2) / 3);
                PrintChars('+', (zahl * 2) / 3);
                Console.WriteLine();
                b++;

            }
        }


        //Aufgabe14
        public static void PrintCirclePythagoras(int radius)
        {
            for (int i = 1; i < radius * 2; i++)
            {
                for (int j = 1; j < radius * 2; j++)
                {
                    if ((j - radius) * (j - radius) + (i - radius) * (i - radius) <= radius * radius)
                    {
                        Console.Write("i");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }


        //Aufgabe15
        //TODO Sinus und Cosinus
        public static void PrintCircleSinCos(int radius)
        {
            for (int i = radius; i > -radius * 2; radius--)
            {
                for (int j = radius; j > -radius * 2; radius--)
                {

                }
                Console.WriteLine();
            }
        }


        /*//Aufgabe4 Version 1
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
                x++;cvcvyxc
            }
        }

        //Aufgabe5 Version 1
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

        //Aufgabe6
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
        }

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

        //Aufgabe7 Version 1
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

        //Aufgabe10
      public static void PrintPyramid(char symbol, int zahl)
      {
          if (zahl == 1)
          {
              PrintChars(symbol, zahl);
              Console.WriteLine();
          }
          else
          {
              PrintChars(' ', zahl - 1);
              Console.WriteLine(symbol);
              int spacedifferent = 1;
              for (int i = 1; i < zahl - 1; i++)
              {
                  int spaces = i;
                  int characters = zahl - i;
                  PrintChars(' ', characters - 1);
                  Console.Write(symbol);
                  for (int a = spacedifferent; a > 0; a--)
                  {
                      Console.Write(' ');
                  }
                  Console.Write(symbol);
                  spacedifferent = spacedifferent + 2;
                  Console.WriteLine();
              }
              PrintChars(symbol, (zahl * 2) - 1);
              Console.WriteLine();
          }
      }

        //Aufgabe11.1
        public static void PrintRhombus(char symbol, int zahl)
        {
            PrintChars(' ', zahl / 2);
            Console.WriteLine(symbol);
            int spacedifferent = 1;
            for (int i = 1; i < ((zahl / 2) + 1); i++)
            {
                int characters = zahl / 2 + 1 - i;
                PrintChars(' ', characters - 1);
                Console.Write(symbol);
                for (int a = spacedifferent; a > 0; a--)
                {
                    Console.Write(' ');
                }
                Console.Write(symbol);
                spacedifferent = spacedifferent + 2;
                Console.WriteLine();
            }
            int space2 = spacedifferent - 4;
            for (int i = 1; i < ((zahl - 1) / 2); i++)
            {
                int characters = zahl / 2 + 1 - i;
                PrintChars(' ', i);
                Console.Write(symbol);
                for (int a = space2; a > 0; a--)
                {
                    Console.Write(' ');
                }
                Console.Write(symbol);
                space2 = space2 - 2;
                Console.WriteLine();
            }
            PrintChars(' ', zahl / 2);
            Console.WriteLine(symbol);
        }

        //Aufgabe12
        public static void PrintX(char symbol, int zahl)
        {
            int spacedifferent = zahl;
            int space2 = spacedifferent - 2;
            for (int i = 0; i < (zahl / 2); i++)
            {
                int characters = zahl / 2 + 1 - i;
                PrintChars(' ', i);
                Console.Write(symbol);
                for (int a = space2; a > 0; a--)
                {
                    Console.Write(' ');
                }
                Console.Write(symbol);
                space2 = space2 - 2;
                Console.WriteLine();
            }
            PrintChars(' ', zahl / 2);
            Console.WriteLine(symbol);
            int b = 1;
            for (int i = 1; i < ((zahl / 2) + 1); i++)
            {
                int characters = zahl / 2 + 1 - i;
                PrintChars(' ', characters - 1);
                Console.Write(symbol);
                for (int a = b; a > 0; a--)
                {
                    Console.Write(' ');
                }
                Console.Write(symbol);
                b = b + 2;
                Console.WriteLine();
            }
        }
        */
    }
}