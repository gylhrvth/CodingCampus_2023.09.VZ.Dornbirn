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
            for (int y = 0;  y < zahl; y++)
            {
                PrintChars( symbol, zahl);
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
                while ((y-1) < x) 
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
        //Aufgabe6
        public static void PrintTriangleTopRight(char symbol, int zahl)
        {
            int x = zahl;
            
            int a = 0;
            //int z = a;
            while (x > 0)
            {
                int z = a;
                int y = 0;
                while (zahl-z < (zahl)) 
                {
                    Console.Write(" ");
                    z--;
                    //y++;
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
    }
}