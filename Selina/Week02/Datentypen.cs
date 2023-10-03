using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Selina.Week02
{
    internal class Datentypen
    {
        public static void Start()
        {



            //Aufgabe 1:
            int trinangel = 5;
            for (int i = 0; i < trinangel; i++)
            {
                for (int j = 0; j < trinangel; j++)
                {
                    if (i >= j)
                    {
                        Console.Write("X ");
                    }
                    else
                    {
                        Console.Write(". ");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            //Aufagbe 2:
            for (int i = 0; i < trinangel; i++)
            {
                for (int j = 0; j < trinangel; j++)
                {
                    if (i + j <= trinangel - 1)
                    {
                        Console.Write("X ");
                    }
                    else
                    {
                        Console.Write(". ");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            //Aufgabe 3:
            for (int i = 0; i < trinangel; i++)
            {
                for (int j = 0; j < trinangel; j++)
                {
                    if (i <= j)
                    {
                        Console.Write("X ");
                    }
                    else
                    {
                        Console.Write(". ");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            // Aufagbe 4:
            for (int i = 0; i < trinangel; i++)
            {
                for (int j = 0; j < trinangel; j++)
                {
                    if (i + j >= trinangel - 1)
                    {
                        Console.Write("X ");
                    }
                    else
                    {
                        Console.Write(". ");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            //Aufgabe 5:

            for (int i = 0; i < trinangel; i++)
            {
                for (int j = 0; j < trinangel; j++)
                {
                    if (i == 0 || i == trinangel - 1 || j == 0 || j == trinangel - 1)
                    {
                        Console.Write("X ");
                    }
                    else
                    {
                        Console.Write(". ");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            //Aufgabe 6:

            for (int i = 0; i < trinangel; i++)
            {
                for (int j = 0; j < trinangel; j++)
                {
                    if (i == j)
                    {
                        Console.Write("X ");
                    }
                    else
                    {
                        Console.Write(". ");
                    }
                }
                Console.WriteLine();
            }


            Console.WriteLine();

            //Aufgabe 7:

            for (int i = 0; i < trinangel; i++)
            {
                for (int j = 0; j < trinangel; j++)
                {
                    if (i + j < trinangel - 1 || i + j > trinangel - 1)
                    {
                        Console.Write(". ");
                    }
                    else
                    {
                        Console.Write("X ");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            //Aufgabe 8:

            for (int row = 0; row < trinangel; row++)
            {
                for (int cul = 0; cul < trinangel * 2 -1; cul++)
                {
                    if(row + trinangel == cul +1 || row == trinangel - cul -1 || row == trinangel -1)
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
                    Console.WriteLine();
            //Aufgabe 2:
            Calculate();

            //Aufgabe 3:
            
        }

       
        static void Calculate()
        {
            int result = 0;
            for (int number = 20; number <= 50; number++)
            {
                if (number % 2 == 0)
                {
                    Console.Write($"{number} + ");
                    result = result + number;
                }
            }
            Console.WriteLine($" = {result}");
        }
    }
}
    

