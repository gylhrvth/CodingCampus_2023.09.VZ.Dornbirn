using System.Buffers.Text;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Selina.Week01
{
    internal class Methoden
    {

        public static void Start()
        {
            //Aufgabe 1:
            //PrintSquare();

            //Aufgabe 2:
            //PrintRectangle();

            //Aufgabe 3:
            //PrintTrinangel();

            //Aufgabe 4:
            //PrintTrinangel2();

            //Aufgabe 5:
            //PrintTrinangel3();

            //Aufgabe 6:
            //PrintTrinangel4();

            //PrintEmptySquare1();

            //Aufagbe 7:
            //PrintEmptySquare2();

            //Aufgabe 8:
            //PrintSlash();

            //Aufgabe 9:
            //PrintTriangle();

            PrintRhombus();
            //PrintX();
            //PrintChristmastree();
        }


        // PrintSquare gibt in der Console x in einer Form von einem Rechteck aus --> funktioniert
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

        //PrintRectangle gibt in der Console x in einer Form von einem Viereck aus --> funktioniert
        public static void PrintRectangle()
        {
            Console.WriteLine("\nWelche Breite und Länge soll Ihr Viereck haben?");
            string test = Console.ReadLine();
            string[] eingabe = test.Split(' ');

            int width = Convert.ToInt32(eingabe[0]);
            int length = Convert.ToInt32(eingabe[1]);

            for (int i = 1; i <= width; i++)
            {
                for (int y = 1; y < length; y++)
                {
                    Console.Write("x");
                }

                Console.WriteLine("x");
            }
        }

        // PrintTrinangel gibt in der Console x in einer Form von einem Dreick aus --> funktioniert
        public static void PrintTrinangel()
        {
            Console.WriteLine("\nWie Groß soll Ihr Dreieck sein?");
            int trinangel = Convert.ToInt32(Console.ReadLine());
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

        //PrintTrinangel2 gibt in der Console x in einer Form von einem Dreick aus --> funktioniert
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

        //PrintTrinangel4 gibt in der Console x in einer Form von einem Dreick aus --> ein Lehrzeichen zu viel!
        public static void PrintTrinangel4()
        {
            Console.WriteLine("\nWie Groß soll Ihr Dreieck sein????");
            int trinangel = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= trinangel; i++)
            {
                for (int y = 0; y < i; y++)
                {
                    Console.Write("x");
                }
                Console.WriteLine();
                for (int y = trinangel; y > i; y--)
                {
                    Console.Write("!");

                }
            }
        }

        //PrintTrinangel3 gibt in der Console x in einer Form von einem Dreick aus --> funktioniert
        public static void PrintTrinangel3()
        {
            Console.WriteLine("\nWie Groß soll Ihr Dreieck sein?");
            int trinangel = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < trinangel; i++)
            {
                for (int y = 0; y < i; y++)
                {
                    Console.Write("!");
                }
                for (int y = trinangel; y > i; y--)
                {
                    Console.Write("x");

                }
                Console.WriteLine();
            }
        }

        //PrintEmptySquare1 gibt in der Console x in einer Form von einem Quader aus --> funktioniert
        public static void PrintEmptySquare1()
        {
            Console.WriteLine("\nWie Groß soll Ihr Quader sein?");
            int square = Convert.ToInt32(Console.ReadLine());


            for (int y = 1; y <= square; y++)
            {
                Console.Write("x");
            }

            Console.WriteLine();

            for (int y = 1; y <= square - 2; y++)
            {
                Console.Write("x");

                for (int i = 1; i <= square - 2; i++)
                {
                    Console.Write(" ");
                }

                Console.WriteLine("x");
            }

            for (int i = 1; i <= square; i++)
            {
                Console.Write("x");
            }

            Console.WriteLine();
        }

        //PrintEmptySquare2 gibt in der Console A in einer Form von einem Quader aus --> funktioniert
        public static void PrintEmptySquare2()
        {
            Console.WriteLine("\nWie Groß soll Ihr Quader sein?");
            int square = Convert.ToInt32(Console.ReadLine());


            for (int y = 1; y <= square; y++)
            {
                Console.Write("A");
            }

            Console.WriteLine();

            for (int y = 1; y <= square - 2; y++)
            {
                Console.Write("A");

                for (int i = 1; i <= square - 2; i++)
                {
                    Console.Write(" ");
                }

                Console.WriteLine("A");
            }

            for (int i = 1; i <= square; i++)
            {
                Console.Write("A");
            }

            Console.WriteLine();
        }

        //PrintSlash gibt in der Consol x in einer Form von einer Diagonale aus --> funktioniert
        public static void PrintSlash()
        {
            Console.WriteLine("\nWie Groß soll Ihre Diagonale sein?");
            int printSlash = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nDiagonale links oder rechts ausgeben?");
            string slashPrint = Convert.ToString(Console.ReadLine());

            int number = 0;

            if (slashPrint == "rechts")
            {
                bool slash = true;

                for (int i = 1; i <= printSlash; i++)
                {
                    for (int y = 1; y <= number; y++)
                    {
                        Console.Write(" ");
                    }
                    number++;

                    Console.WriteLine("x");
                }
            }
            else if (slashPrint == "links")
            {
                bool slash = false;

                for (int j = 0; j < printSlash; j++)
                {
                    for (int i = printSlash - 1; i > j; i--)
                    {
                        Console.Write(" ");
                    }

                    Console.WriteLine("x");
                }
            }
        }

 
        public static void PrintTriangle()
        {
            Console.WriteLine("\nWie Groß soll Ihr Dreieck sein?");
            int triangel = Convert.ToInt32(Console.ReadLine());


            int i, j;

            for (i = 1; i <= triangel; i++)
            {
                for (j = 1; j <= triangel - i; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= (2 * i - 1); j++)
                {
                    if (i < triangel)
                    {
                        if (j == 1 || j == (2 * i - 1))
                        {
                            Console.Write("x");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }

                    else
                    {
                        Console.Write("x");
                    }
                }

                Console.WriteLine("");
            }
        }


        public static void PrintRhombus()
        {
            Console.WriteLine("\nWie Groß soll Ihr Rhombus sein sein?");
            int rhombus = Convert.ToInt32(Console.ReadLine());


            int count;
            count = rhombus - 1;
            for (int k = 1; k <= rhombus; k++)
            {
                for (int i = 1; i <= count; i++)
                {
                    Console.Write(" ");
                }
                count--;
                for (int i = 1; i <= 2 * k - 1; i++)
                {
                    Console.Write("!");

                }
                Console.WriteLine();
            }
            count = 1;
            for (int k = 1; k <= rhombus - 1; k++)
            {
                for (int i = 1; i <= count; i++)
                {
                    Console.Write(" ");
                }
                count++;
                for (int i = 1; i <= 2 * (rhombus - k) - 1; i++)
                {
                    Console.Write("#");
                }

                Console.WriteLine();
            }
        }


        public static void PrintX()
        {
            Console.WriteLine("\nWie Groß soll Ihr X sein sein?");
            int X = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= X; i++)
            {
                for (int j = 1; j <= X; j++)
                {
                    if (j == i || j == X - i + 1)
                    {
                        Console.Write("x");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();

            }

        }
        public static void PrintChristmastree()
        {
            Console.WriteLine("\nWie Groß soll Ihr Christmastree sein sein?");
            int tree = Convert.ToInt32(Console.ReadLine());

            int count = 0;
            count = tree - 1;
            for (int k = 1; k <= tree; k++)
            {
                for (int i = 1; i <= count; i++)
                {
                    Console.Write(" ");
                }
                count--;
                for (int i = 1; i <= 2 * k - 1; i++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }
            for (int i = 0; i < tree; i++)
            {
                Console.Write("O ");
            }
            Console.WriteLine();
            for (int i = 0; i <= (tree / 2); i++)
            {
                Console.Write(" ");
            }
            for (int i = 0; i <= tree / 2; i++)
            {
                Console.Write("+");
            }
            Console.WriteLine();
            for (int i = 0; i <= (tree / 2); i++)
            {
                Console.Write(" ");
            }
            for (int i = 0; i <= tree / 2; i++)
            {
                Console.Write("+");
            }
        }
    }
}






