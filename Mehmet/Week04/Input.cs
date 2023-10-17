using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mehmet.Week04
{
    internal class Input
    {
        public static void Start()
        {

            //String input = Console.ReadLine();
            //Console.WriteLine("your input is: " + input);


            //int input = Console.Read();
            //Console.WriteLine("your input is: " + input);


            //int readNumber = ReadNumbner("Enter a Numero:", " EROR 404 : Try again : ");



            //ReadRandomNumber("Lass uns ein Spiel spielen ö_ö", "tippe eine Zahl ein :_[", " Versuchs doch mit einem Zahl: ", "höher: ", "runter: ", "Richtig !!!", "Min?", "Max?");

            //ReadNumberMenue("Ola Willkomen!", "was soll ich dir zeichnen?", "Christbaum", "Quader", "Rhombus", "Wie groß soll es sein?", "und welches Symbol soll es haben?");

            Calculator();

        }

        public static Random rand = new Random();

        public static int ReadNumber(string msg)
        {
            while (true)
                try
                {
                    Console.Write(msg);
                    string input = Console.ReadLine();
                    int myNumber = Convert.ToInt32(input);
                    return myNumber;
                }
                catch
                {
                    Console.WriteLine("Hust -Zahl- Hust");
                }
        }

        public static String ReadSymbol(string msg)
        {
            while (true)
                try
                {
                    Console.Write(msg);
                    string input = Console.ReadLine();
                    return input;
                }
                catch
                {
                    Console.WriteLine("Hust -Symbol- Hust");
                }
        }

         



        
        static int ReadNumbner(String stage1, String error)
        {
            Console.WriteLine(stage1);
            while (true)
            {
                try
                {
                    String input = Console.ReadLine();
                    int myNumber = Convert.ToInt32(input);
                    return myNumber;
                }
                catch
                {
                    Console.Error.WriteLine(error);
                }
            }
        }


        static void ReadRandomNumber(String stage1, String stage2, String error, String higher, String lower, String correct, String askmin, String askmax)
        {

            bool end = false;
            Console.WriteLine(stage1);          
            int min = ReadNumber(askmin);
            int max = ReadNumber(askmax);
            int random = rand.Next(min, max);
            int answer = random;

            while (!end)
            {
                int myNumber = ReadNumber(stage2);
                if (answer < myNumber)
                {
                    Console.WriteLine();
                    Console.WriteLine(lower);
                    Console.WriteLine("<--" + myNumber);
                    Console.WriteLine();
                    if (myNumber > max)
                    {
                        Console.WriteLine("Achtung max: " + max);
                    }
                }
                else if (answer > myNumber)
                {
                    Console.WriteLine();
                    Console.WriteLine(higher);
                    Console.WriteLine(myNumber + "-->");
                    Console.WriteLine();
                    if (myNumber < min)
                    {
                        Console.WriteLine("Achtung min: " + min);
                    }
                }
                else if (answer == myNumber)
                {
                    Console.WriteLine();
                    Console.WriteLine(answer + " " + correct);
                    Console.WriteLine();
                    end = true;
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
                    Mehmet.Week02.BooleanExamples.PrintChristmasTree(size, symbol);
                }
                else if (myNumber == 2)
                {
                    Mehmet.Week01.Rechnen.PrintEmptySquare(symbol, size);
                }
                else
                {
                    Mehmet.Week02.BooleanExamples.PrintRhombus(symbol, size);
                }
                Console.WriteLine();
                Console.WriteLine("1 für  Ja");
                Console.WriteLine("2 für Nein");
                int again = ReadNumber("Sollen wir nochmal?");

                if (again != 1)
                {
                    end = true;
                }
            }
        }


        public static void Calculator()
        {
            while (true)
            {

                float num1 = ReadNumber("Gib ein Zahl ein");
                float num2 = ReadNumber("Gib das 2. Zahl ein");
                float num2new = num2;
                
                Console.WriteLine("1 für +");
                Console.WriteLine("2 für -");
                Console.WriteLine("3 für *");
                Console.WriteLine("4 für /");
                Console.WriteLine("5 für ^");

                int num3 = ReadNumber("Suche dir deinen Operator aus");

                if (num3 == '+')
                {
                    Console.WriteLine($"{num1}" + " + " + $"{num2}" + " = " + (num1+num2));
                }
                else if(num3 == 2)
                {
                    Console.WriteLine($"{num1}" + " - " + $"{num2}" + " = " + (num1 - num2));
                }
                else if (num3 == 3)
                {
                    Console.WriteLine($"{num1}" + " * " + $"{num2}" + " = " + (num1 * num2));
                }
                else if( num3 == 4) 
                {
                    Console.WriteLine($"{num1}" + " / " + $"{num2}" + " = " + (num1 / num2));
                }
                else
                {
                    for (float i = 0; i < num2; i++)
                    {
                        num2new *= 10;
                    }
                    
                    Console.WriteLine($"{num1}" + " ^ " + $"10^{num2}" + " = " + (num1 * num2new));
                }

            }
        }






    }
}
