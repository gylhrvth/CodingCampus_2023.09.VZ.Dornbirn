using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Martin.Week04
{
    internal class UserInput
    {
        public static void Start()
        {
            //string Name = AskString("Erstellen sie einen Benutzername!");
            //Console.WriteLine("Hallo {0}!",Name);

            //AskNumber("Geben sie eine Nummer ein bitte");

            //RateSpiel("Willkommen beim Ratespiel!");

            //Zeichnen("Willkomen zum Menü");

            Calculator("Willkommen zum Taschenrechner!");

            Array2d();

        }

        public static void Array2d()
        {
            int[][] array2d = new int[3][];

            for(int i = 0; i < array2d.Length; i++)
            {

            }
        }

        //Aufgabe 1: String einlesen
        public static string AskString(string msg)
        {

            Console.WriteLine(msg);

            string Name = Console.ReadLine();

            return Name;

        }

        public static void AskNumber(string msg)
        {

            int antwort = 0;

            while (antwort == 0)
            {

                try
                {

                    Console.WriteLine(msg);

                    antwort = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("ihre zahl ist " + antwort);

                    break;

                }
                catch (FormatException e)
                {
                    Console.WriteLine("Sorry das war keine zahl");
                }

            }
        }

        public static void RateSpiel(string msg)
        {
            Console.WriteLine(msg);

            Console.WriteLine("Was soll das maximum sein zum raten?");

            Int32 max = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Erraten sie die Zahl was ich denke sie liegt zwischen {0} und {1}", max - max + 1, max);

            Random rnd = new Random();


            while (true)
            {
                Int32 guess = 0;
                Int32 randomNumber = rnd.Next(max - max + 1, max);

                while (guess != randomNumber)
                {

                    try
                    {
                        guess = Convert.ToInt32(Console.ReadLine());


                        if (guess < randomNumber)
                        {
                            Console.WriteLine("Die zahl ist zu klein!");
                            Console.WriteLine("Probiers nochmal");
                        }

                        if (guess > randomNumber)
                        {
                            Console.WriteLine("Die zahl ist zu gross!");
                            Console.WriteLine("Probiers nochmal");
                        }

                    }

                    catch (FormatException e)
                    {
                        Console.WriteLine("DU MUSST ZAHLEN EINGEBEN");
                    }

                }

                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine("Herzlichen Glückwunsch du hast es geschafft! \nDie Zahl wäre: " + randomNumber + " gewesen");

                break;

            }
        }

        public static void Zeichnen(string msg)
        {

            bool Wiederholen = true;

            while (Wiederholen)
            {

                Console.WriteLine(msg);

                Console.WriteLine("Was möchten sie zeichnen lassen?");

                Console.WriteLine();
                Console.Write("1)Christbaum");
                Console.WriteLine();
                Console.Write("2)Rhombus");
                Console.WriteLine();
                Console.Write("3)Quader");
                Console.WriteLine();

                int antwort = Convert.ToInt32(Console.ReadLine());

                switch(antwort)
                {
                    case 1:
                    CreateName(1);
                        break;

                    case 2:
                        CreateName(2);
                        break;

                    case 3:
                        CreateName(3);
                        break;
                }

                static void CreateName(int antwort)
                {
                    if(antwort == 1)
                    {

                        Console.WriteLine("Wie groß soll der Christbaum sein?");
                        int Size = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Welches Zeichen soll verwendet werden?");
                        Char symbol = Convert.ToChar(Console.ReadLine());

                        Week01.PrintCharacters.PrintTriangle(symbol, Size);

                    }
                    else if(antwort == 2)
                    {
                        Console.WriteLine("Wie groß soll der Rhombus sein?");
                        int Size = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Welches Zeichen soll verwendet werden?");
                        Char symbol = Convert.ToChar(Console.ReadLine());

                        Week01.PrintCharacters.PrintRhombus(symbol, Size);
                    }

                    else if (antwort == 3)
                    {
                        Console.WriteLine("Wie groß soll der Quader sein?");
                        int Size = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Welches Zeichen soll verwendet werden?");
                        Char symbol = Convert.ToChar(Console.ReadLine());

                        Week01.PrintCharacters.PrintEmptySquare(symbol, Size);
                    }
                }

                Console.WriteLine("Willst du nochmal etwas cooles zeichen? Y/N");

                string Nochmal = Console.ReadLine().ToUpper();

                if(Nochmal == "Y")
                {
                    //mach weiter
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Aufwiedersehen!");
                    Wiederholen = false;
                    break;
                }
            }
        }

        public static void Calculator(string msg)
        {
            int result = 0;
            string antwort;
            do
            {
                Console.WriteLine(msg);

                Console.WriteLine("Gieb die erste Zahl ein:");
                float FirstNumber = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("Gieb die zweite Zahl ein:");
                float SecondNumber = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("Wähle bitte mit den Operator aus (+,-,*,^,/");
                Char symbol = Convert.ToChar(Console.ReadLine());

          

          

                switch (symbol)
                {
                    case '+':
                        Console.WriteLine("Result: " + ((FirstNumber + SecondNumber)));
                        break;

                    case '-':
                        Console.WriteLine("Result: " + ((FirstNumber - SecondNumber)));
                        break;

                    case '*':
                        Console.WriteLine("Result: " + ((FirstNumber * SecondNumber)));
                        break;

                    case '^':
                        Console.WriteLine("Result: " + (Math.Pow(FirstNumber, SecondNumber)));
                        break;

                    case '/':
                        Console.WriteLine("Result: " + ((FirstNumber / SecondNumber)));
                        break;

                }
                Console.WriteLine("Willst du nochmal etwas ausrechnen? Y/N");
                antwort = Console.ReadLine();
            } 
            while (antwort.ToUpper() == "Y");


        }
    }
}
