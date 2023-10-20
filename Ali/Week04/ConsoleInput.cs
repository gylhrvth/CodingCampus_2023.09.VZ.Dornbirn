using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Ali.Week01;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static Ali.Week01.Methoden;

namespace Ali.Week04
{
    internal class ConsoleInput
    {
        public static void Start()
        {

            //Console.WriteLine("Aufgabe 1 String einlesen");
            //Console.WriteLine();

            //string name = ReadString("Wie lautet ihr Name? ");
            //Console.WriteLine("Hallo " + name);
            //Console.WriteLine();

            //Console.WriteLine("Aufgabe: Zahl einlesen");
            //Console.WriteLine();

            //int readNumber = ReadNumb("Geben Sie eine Zahl an:", "Keine gültige Zahl");
            //Console.WriteLine("Gegebene Nummer ist " + readNumber);
            //Console.WriteLine();

            //Console.WriteLine("Aufgabe Ratespiel");
            //Console.WriteLine();
            //Console.WriteLine("Willkommen beim super coolen Zahlen Ratespiel!");
            //Console.WriteLine();
            //RateSpiel();
            //Console.WriteLine();

            Console.WriteLine("Aufgabe Menü");
            Console.WriteLine();
            Menu();









        }
        public static string ReadString(string msg)
        {
            Console.WriteLine(msg);
            string output = Console.ReadLine();
            return output;
        }
        static int ReadNumb(string prompt, string error)
        {
            Console.WriteLine(prompt);

            while (true)
            {
                try
                {
                    string input = Console.ReadLine();

                    int ourNumber = Convert.ToInt32(input);

                    return ourNumber;
                }
                catch
                {

                    Console.Error.WriteLine(error);
                }
            }
        }
        public static void RateSpiel()
        {
            int num = new Random().Next(0, 101);
            int guess = 0;
            int tries = 0;

            while (num != guess)
            {
                try
                {
                    Console.WriteLine("Gib eine Nummer zwischen 1 und 100 ein!");
                    guess = Convert.ToInt32(Console.ReadLine());
                    tries++;

                    if (guess > 100 || guess < 1)

                    {
                        Console.WriteLine("Ich habe gesagt nur Zahlen zwischen 1 und 100!");
                    }
                    else if (guess == num)
                    {
                        Console.WriteLine("Glückspilz");
                    }
                    else if (guess < num)
                    {
                        Console.WriteLine("Deine Zahl ist zu niedrig!!");
                    }
                    else if (guess > num)
                    {

                        Console.WriteLine("Deine Zahl ist zu hoch!!");
                    }


                }
                catch
                {
                    Console.WriteLine("Bist du dumm oder geistig eingeschränkt? Nur Zahlen!!!!!");
                }


            }
        }
        public static void Menu()
        {
            int eingabe = 0;
            int size = 0;
            bool restart = false;
            Console.WriteLine("Willkommen bei meinen Aufgaben!");

            while (restart == false)
            {
                Console.WriteLine("Was du möchten zeichnen?");
                Console.WriteLine(" 1. Square \n 2. Empty Square \n 3. Trinangle");
                Console.Write("Bitte wählen sie aus");

                eingabe = ReadNumb("", "Du kannst nur Zahlen von 1 - 3 eingeben!");
                size = ReadNumb("Wie groß soll das Konstrukt sein?", "Du kannst nur Zahlen eingeben!");
                string symbol = ReadString("Welches Zeichen soll verwendet werden? Du kannst nur zeichen eingeben!");
                if (eingabe == 1)
                {
                    Methoden.printSquare(symbol, size);
                }

                else if (eingabe == 2)
                {
                    Methoden.printEmptySquare(symbol, size);
                }

                else if (eingabe == 3)
                {
                    Methoden.printTriangleTopRight(symbol, size);
                }
                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine("Möchten sie noch etwas zeichen? (j / n)");
                string restartJorN = Console.ReadLine();

                if (restartJorN == "j")
                {
                    restart = false;
                }

                if (restartJorN == "n")
                {
                    restart = true;
                }

                Console.WriteLine();
            }
        }












    }
}






























