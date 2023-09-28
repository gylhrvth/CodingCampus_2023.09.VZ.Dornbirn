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

            //PrintSquare();
            //PrintRectangle();
            //PrintTrinangel();
            //PrintTrinangel2();
            //PrintTrinangel3();
            //PrintTrinangel4();
            //PrintEmptySquare1();
            //PrintEmptySquare2();
            //PrintSlash();
            //PrintTriangle();
            PrintRhombus();
            PrintX();
            PrintChristmastree();
        }

        //public static void PrintSquare()
        //{
        //    Console.WriteLine("\nWie viel Zeilen möchtest du ausgeben?");
        //    int chars = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine("\nWie viel Spalten möchtest du ausgeben?");
        //    int square = Convert.ToInt32(Console.ReadLine());

        //    for (int i = 1; i <= square; i++)
        //    {
        //        for (int y = 1; y < chars; y++)
        //        {
        //            Console.Write("x");
        //        }

        //        Console.WriteLine("x");
        //    }
        //}
        //public static void PrintRectangle()
        //{
        //    Console.WriteLine("\nWelche Breite und Länge soll Ihr Viereck haben?");
        //    string test = Console.ReadLine();
        //    String[] eingabe = test.Split(' ');

        //    int width = Convert.ToInt32(eingabe[0]);
        //    int length = Convert.ToInt32(eingabe[1]);

        //    for (int i = 1; i <= width; i++)
        //    {
        //        for (int y = 1; y < length; y++)
        //        {
        //            Console.Write("x");
        //        }

        //        Console.WriteLine("x");
        //    }
        //}
        //public static void PrintTrinangel()
        //{
        //    Console.WriteLine("\nWie Groß soll Ihr Dreieck sein?");
        //    int trinangel = Convert.ToInt32(Console.ReadLine());
        //    int number = 0;

        //    for (int i = 1; i <= trinangel; i++)
        //    {
        //        if (i <= trinangel)
        //        {
        //            for (int y = 1; y <= number; y++)
        //            {
        //                Console.Write("x");
        //            }
        //            ++number;

        //        }

        //        Console.WriteLine("x");
        //    }
        //}
        //public static void PrintTrinangel2()
        //{
        //    Console.WriteLine("\nWie Groß soll Ihr Dreieck sein?");
        //    int trinangel = Convert.ToInt32(Console.ReadLine());

        //    for (int j = 0; j < trinangel; j++)
        //    {
        //        for (int i = trinangel - 1; i > j; i--)
        //        {
        //            Console.Write("x");
        //        }

        //        Console.WriteLine("x");
        //    }
        //}
        //public static void PrintTrinangel4()
        //{
        //    Console.WriteLine("\nWie Groß soll Ihr Dreieck sein?");
        //    int trinangel = Convert.ToInt32(Console.ReadLine());

        //    for (int i = 0; i <= trinangel; i++)
        //    {
        //        for (int y = 0; y < i; y++)
        //        {
        //            Console.Write("x");

        //        }
        //        Console.WriteLine();
        //        for (int y = trinangel; y > i; y--)
        //        {
        //            Console.Write(" ");

        //        }
        //    }
        //}
        //public static void PrintTrinangel3()
        //{
        //    Console.WriteLine("\nWie Groß soll Ihr Dreieck sein?");
        //    int trinangel = Convert.ToInt32(Console.ReadLine());

        //    for (int i = 0; i <= trinangel; i++)
        //    {
        //        for (int y = trinangel; y > i; y--)
        //        {
        //            Console.Write("x");

        //        }
        //        Console.WriteLine();
        //        for (int y = 0; y <= i; y++)
        //        {
        //            Console.Write(" ");

        //        }
        //    }
        //}
        //public static void PrintEmptySquare1()
        //{
        //    Console.WriteLine("\nWie Groß soll Ihr Quadar sein?");
        //    int square = Convert.ToInt32(Console.ReadLine());


        //    for (int y = 1; y <= square; y++)
        //    {
        //        Console.Write("x");
        //    }

        //    Console.WriteLine();

        //    for (int y = 1; y <= square - 2; y++)
        //    {
        //        Console.Write("x");

        //        for (int i = 1; i <= square - 2; i++)
        //        {
        //            Console.Write(" ");
        //        }

        //        Console.WriteLine("x");
        //    }

        //    for (int i = 1; i <= square; i++)
        //    {
        //        Console.Write("x");
        //    }
        //}
        //public static void PrintEmptySquare2()
        //{
        //    Console.WriteLine("\nWie Groß soll Ihr Quadar sein?");
        //    int square = Convert.ToInt32(Console.ReadLine());


        //    for (int y = 1; y <= square; y++)
        //    {
        //        Console.Write("A");
        //    }

        //    Console.WriteLine();

        //    for (int y = 1; y <= square - 2; y++)
        //    {
        //        Console.Write("A");

        //        for (int i = 1; i <= square - 2; i++)
        //        {
        //            Console.Write(" ");
        //        }

        //        Console.WriteLine("A");
        //    }

        //    for (int i = 1; i <= square; i++)
        //    {
        //        Console.Write("A");
        //    }
        //}
        //public static void PrintSlash()
        //{
        //    Console.WriteLine("\nWie Groß soll Ihre Diadonale sein?");
        //    int printSlash = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine("Diagonale links oder rechts ausgeben?"); 
        //    string slashPrint =Convert.ToString(Console.ReadLine());

        //    int number = 0;

        //    if (slashPrint == "rechts")
        //    {
        //        bool slash = true;

        //        for (int i = 1; i <= printSlash; i++)
        //        {
        //            for (int y = 1; y <= number; y++)
        //            {
        //                Console.Write(" ");
        //            }
        //            number++;

        //            Console.WriteLine("x");
        //        }
        //    }
        //    else if(slashPrint == "links")
        //    {
        //        bool slash = false;

        //        for (int j = 0; j < printSlash; j++)
        //        {
        //            for (int i = printSlash - 1; i > j; i--)
        //            {
        //                Console.Write(" ");
        //            }

        //            Console.WriteLine("x");
        //        }
        //    }
        //}

        //public static void PrintTriangle()
        //{
        //    Console.WriteLine("\nWie Groß soll Ihre Diadonale sein?");
        //    int triangel = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine("");

        //    int  i, j;

        //    for (i = 1; i <= triangel; i++)
        //    {
        //        for (j = 1; j <= triangel - i; j++)
        //        {
        //            Console.Write(" ");
        //        }
        //        for (j = 1; j <= (2 * i - 1); j++)
        //        {
        //            if (i < triangel)
        //            {
        //                if (j == 1 || j == (2 * i - 1))
        //                {
        //                    Console.Write("x");
        //                }
        //                else
        //                {
        //                    Console.Write(" ");
        //                }
        //            }

        //            else
        //            {
        //                Console.Write("x");
        //            }
        //        }

        //        Console.WriteLine("");
        //    }
        //}


        public static void PrintRhombus()
        {
            Console.WriteLine("\nWie Groß soll Ihr Rhombus sein sein?");
            int triangel = Convert.ToInt32(Console.ReadLine());

            int count;
        
            count = triangel - 1;
            for (int k = 1; k <= triangel; k++)
            {
                for (int i = 1; i <= count; i++)
                {
                    Console.Write(" ");
                }
                count--;
                for (int i = 1; i <= 2 * k - 1; i++)
                {
                    Console.Write("x");
                    
                }
                Console.WriteLine();
            }
            count = 1;
            for (int k = 1; k <= triangel - 1; k++)
            {
                for (int i = 1; i <= count; i++)
                {
                    Console.Write(" ");
                }
                count++;
                for (int i = 1; i <= 2 * (triangel - k) - 1; i++)
                {
                    Console.Write("x");
                }

                Console.WriteLine();
            }
        }


        public static void PrintX()
        {
            



        }

        public static void PrintChristmastree()
        {
            Console.WriteLine("\nWie Groß soll Ihr Christmastree sein sein?");
            int triangel = Convert.ToInt32(Console.ReadLine());

            int count = 0;
            count = triangel - 1;
            for (int k = 1; k <= triangel; k++)
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
            for (int i=0; i< triangel; i++)
            {
                Console.Write("O ");
            }
            Console.WriteLine();
            for (int i = 0; i < (triangel/2); i++)
            {
                Console.Write(" ");
            }
            for (int i = 0; i < triangel; i++)
            {
                Console.Write("+");
            }
            Console.WriteLine() ;
            for (int i = 0; i < (triangel / 2); i++)
            {
                Console.Write(" ");
            }
            for (int i = 0; i < triangel; i++)
            {
                Console.Write("+");
            }
        }
    }
}






