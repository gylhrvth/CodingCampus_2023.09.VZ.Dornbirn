using System;
namespace Timo.Week01
{
    public class MethodenUndSchleifen
    {
      
        public static void Start()
        {
            Console.WriteLine("\n1.Aufgabe:");
            printChars('x', 5);

            Console.WriteLine("\n2.Aufgabe:");
            printSquare('x', 5);

            Console.WriteLine("\n3.Aufgabe:");
            printRectangle('x', 5, 8);
        }

        //Aufgabe1
        public static void printChars(char Symbol, int Zahl)
        {
            for (int x = 0; x < Zahl; x++)
            {
                Console.Write(Symbol);
            }
            return;
        }
        //Aufgabe2
        public static void printSquare(char Symbol, int Zahl)
        {
            for (int y = 0;  y < Zahl; y++)
            {
                printChars( Symbol, Zahl);
                Console.Write("\n");
            }
            return;
        }
        //Aufgabe3
        public static void printRectangle(char Symbol, int Zahl, int Höhe)
        {
            for (int y = 0; y < Höhe; y++)
            {
                printChars(Symbol, Zahl);
                Console.Write("\n");
            }
            return;
        }
    }
}