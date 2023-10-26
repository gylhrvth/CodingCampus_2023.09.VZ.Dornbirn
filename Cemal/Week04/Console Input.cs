using Cemal.Week01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Cemal.Week04
{
    internal class ConsoleInput
    {
        public static Random random = new Random();

        public static void StartInput()
        {
            string error = ("Gib nur Zahlen ein!");

            //// Name eingeben
            //string userinput = Einlesen("Wie heißt du?");
            //Console.WriteLine("Wilkommen " + userinput);
            //Console.WriteLine();

            //Alter eingeben
            //int userinputnumber = Zahleinlesen("Wie alt bist du?", error);
            //Console.WriteLine("Du bist " + userinputnumber + "Jahre alt.");
            //Console.WriteLine();

            //////Ratespiel
            ////Console.WriteLine();
            ////Ratespiel(error);
            ////Console.WriteLine();

            ////Menü
            Console.WriteLine();
            Menü();

            //Taschenrechner
            //Taschenrechner();
            //Console.WriteLine();
        }

        public static string Einlesen(string prompt, string error)
        {
            Console.WriteLine(prompt);
            while (true)
            {
                try
                {
                    string userinput = Console.ReadLine();
                    return userinput;
                }
                catch (Exception)
                {
                    Console.WriteLine(error);
                }
            }
        }

        public static int Zahleinlesen(string prompt, string error)
        {
            Console.WriteLine(prompt);
            while (true)
            {
                try
                {
                    int userinput = int.Parse(Console.ReadLine());
                    return userinput;
                }
                catch (FormatException)
                {
                    Console.WriteLine(error);
                }
            }
        }

        public static void Ratespiel(string error)
        {

            Console.WriteLine("Wilkommen beim super coolen Zahlen Ratespiel!");
            Console.WriteLine("Errate die Zahl zwischen 0 und 100!");
            Console.WriteLine("Jetzt gib eine Zahl ein: ");

            int randomnumber = random.Next(101);
            int eingabe = 0;
            int counter = 0;

            while (eingabe != randomnumber)
            {
                eingabe = Zahleinlesen("", "Gib nur Zahlen ein!");
                counter++;

                if (eingabe == randomnumber)
                {
                    Console.WriteLine("Hurraaa! Du hast die Zahl {0} erraten!", randomnumber);
                    Console.WriteLine("Du hast {0} versuche gebraucht!", counter);
                }

                else if (eingabe <= randomnumber)
                {
                    Console.WriteLine("Die Zahl ist zu niedrig!");
                }

                else if (eingabe > randomnumber)
                {
                    Console.WriteLine("Die Zahl ist zu hoch!");
                }
            }
            Console.ReadKey();
        }



        public static void Menü()
        {
            int eingabe = 0;
            int groese = 0;
            bool restart = false;
            string[] name = { "", "Square", "Empty Square", "Triangle", "Christbaum" };
            Console.WriteLine("Willkommen bei meinen Aufgaben!");

            while (restart == false)
            {
                Console.WriteLine("Was möchten sie zeichnen?");
                for (int i = 1; i < name.Length; ++i)
                {
                    Console.WriteLine(" {0}. {1}", i, name[i]);
                }

                Console.Write("Bitte wählen sie aus");

                while(eingabe == name.Length)
                {
                eingabe = Zahleinlesen("", "Du kannst nur Zahlen von 1 - 3 eingeben!");
                string prompt = string.Format("Wie groß soll der {0} sein?", name[eingabe]);
                groese = Zahleinlesen(prompt, "Du kannst nur Zahlen eingeben!");
                }                

                string symbol = Einlesen("Welches Zeichen soll verwendet werden?", "Du kannst nur zeichen eingeben!");

                if (eingabe == 1)
                {
                    Methoden_Schleifen.PrintSquare(symbol, groese);
                }

                else if (eingabe == 2)
                {
                    Methoden_Schleifen.PrintEmptySquare(symbol, groese);
                }

                else if (eingabe == 3)
                {
                    Methoden_Schleifen.PrintTrinangle3(symbol, groese);
                }
                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine("Möchten sie noch etwas zeichen? (j / n)");
                string restartJorN = Console.ReadLine();

                if (restartJorN == "n")
                {
                    restart = true;
                }

                Console.WriteLine();
            }
        }



        public static void Taschenrechner()
        {
            Console.WriteLine();
        }


    }
}

