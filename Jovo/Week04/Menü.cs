using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Jovo.Week01.Methoden;


namespace Jovo.Week04
{
    internal class Menü
    {
        public static void Start()
        {

            ReadNumberMenue("Welcome", "Was möchten Sie zeichnen", "Christbaum", "Quader", "Rhombus", "Welche größe", "Welche Zeichen");

            


        }


        public static int ReadNumber(string msg)
        {
            while (true)
            {

                try
                {
                    Console.WriteLine(msg);
                    string input = Console.ReadLine();
                    int myNumber = Convert.ToInt32(input);
                    return myNumber;
                }
                catch
                {
                    Console.WriteLine("Bitte such dir eins der 3 möglichkeiten aus");
                }
            }
        }


      public static String ReadSymbol(string msg)
        {
            while (true)
            {
                try
                {
                    Console.Write(msg);
                    string input = Console.ReadLine();
                    return input;
                }
                catch
                {
                    Console.WriteLine("Gibt eine Zahl ein");

                }
            }
        }


        static void ReadNumberMenue(String stage1, String questionDrawing, String drawing1, String drawing2, String drawing3, String asksize, String asksymbol)
        {
            bool end = false;
            while (!end)
            {
                Console.WriteLine(stage1);
                Console.WriteLine("1 für = " + drawing1);
                Console.WriteLine("2 für = " + drawing2);
                Console.WriteLine("3 für = " + drawing3);
                Console.WriteLine();

                int myNumber = ReadNumber(questionDrawing);
                int size = ReadNumber(asksize);
                string symbol = ReadSymbol(asksymbol);

                if (myNumber == 1)
                {
                    PrintChristmasTree(size, symbol);
                }
                else if (myNumber == 2)
                {
                    PrintEmptySquare(symbol, size);
                }
                else 
                {
                    PrintRhombus(symbol, size);
                }
                Console.WriteLine();
                Console.WriteLine("1 für  Ja");
                Console.WriteLine("2 für Nein");
                int again = ReadNumber("Soll ich dir nochetwas zeichnen?");

                if (again != 1)
                {
                    end = true;
                }
            }
        }



    }
}
