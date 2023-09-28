using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Selina.Week01
{
    internal class Methoden
    {
        //Aufgabe: Print Characters und Print Square und Print Rectangel

            public static void Start()
            {
          
                PrintSquare();
                PrintRectangle();
                PrintTrinangel();
                PrintTrinangel2();
                PrintTrinangel3();
            }

            public static void PrintSquare()
            {
                Console.WriteLine("\nWie viel Zeilen möchtest du ausgeben?");
                int chars = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\nWie viel Spalten möchtest du ausgeben?");
                int square = Convert.ToInt32(Console.ReadLine());

                for (int i = 1; i <= square; i++)
                {
                    for (int y = 1; y < chars; y++)
                    {
                        Console.Write("x");
                    }

                   Console.WriteLine("x");
                }
            }

            public static void PrintRectangle()
            {
                Console.WriteLine("\nWelche Breite und Länge soll Ihr Viereck haben?");
                string test = Console.ReadLine();
                String[] eingabe = test.Split(' ');

                int width = Convert.ToInt32(eingabe[0]);
                int length= Convert.ToInt32(eingabe[1]);

                for (int i = 1; i <= width; i++)
                {
                    for (int y = 1; y < length; y++)
                    {
                        Console.Write("x");
                    }

                    Console.WriteLine("x");
                }
            }

            public static void PrintTrinangel()
            {
                Console.WriteLine("\nWie Groß soll Ihr Dreieck sein?");
                int trinangel= Convert.ToInt32(Console.ReadLine());
                int number = 0;

                for (int i = 1; i <= trinangel; i++)
                {
                   if (i <= trinangel)
                   {
                        for (int y = 1; y <= number; y++)
                        {
                            Console.Write("x");
                        }
                        ++number;

                   }

                    Console.WriteLine("x");
                }
            }

            public static void PrintTrinangel2()
            {
                Console.WriteLine("\nWie Groß soll Ihr Dreieck sein?");
                int trinangel = Convert.ToInt32(Console.ReadLine());
    
                for (int j = 0; j < trinangel; j++)
                {
                   for (int i = trinangel - 1; i > j; i--)
                   {
                      Console.Write("x");
                   }
                  
                    Console.WriteLine("x");
                }
            }

            public static void PrintTrinangel3()
            {
                Console.WriteLine("\nWie Groß soll Ihr Dreieck sein?");
                int trinangel = Convert.ToInt32(Console.ReadLine());
                
            }



    }
}
