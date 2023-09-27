using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Simon.Week01
{
    public class Methoden___Schleifen
    {                
        public static void Start()
        {
            Console.WriteLine("\nPrint Characters");
            PrintChars('x', 10);

            Console.WriteLine("\nPrint Square");
            Printsquare('x', 10);

            Console.WriteLine("\nPrint Rectangle");
            PrintRect('x'), 10, 3);

            Console.WriteLine("\nPrint Triangle1");
        }

        //Aufgabe Print Characters
        public static void PrintChars(char Symbol, int Zahl)
        {
            for (int i = 0; i < Zahl; i++)
            {
                Console.Write(Symbol);
            }
        }
        //Aufgabe Print Square
        public static void Printsquare(char Symbol, int Zahl)
        {
            for(int i = 0;i < Zahl; i++)
            {
                PrintChars(Symbol, Zahl);
                Console.Write("\n");
            }
        }
        //Aufgabe Print Rectangle
        public static void PrintRect(char Symbol, int Zahl, int Zahl1)
        {
            for(int i = 0; i < Zahl1; i++)
            {
                PrintChars(Symbol, Zahl);
                Console.Write("\n");
            }
            
        }

        //Aufgabe Print Triangle (1)
        public static void PrintTriangleBottomLeft(char Symbol, int Zahl)
        {

            while (i<Zahl)
            {
                Console.WriteLine(Symbol);
            }

        }


    }
}
