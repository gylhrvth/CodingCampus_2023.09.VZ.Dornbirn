using System;
using System.Linq.Expressions;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static Sven.Week01.Methoden;


namespace Sven.Week04
{
    internal class UserInputUebungen
    {
        public static void Start()
        {
            Console.WriteLine("String Read:");
            StringRead();
            Console.WriteLine();

            Console.WriteLine("String Read2:");
            StringRead2();
            Console.WriteLine();

            Console.WriteLine("Guess Game:");
            GuessGame();
            Console.WriteLine();

            Console.WriteLine("Menu:");
            Menu("Willkommen im Menü!", "Was möchten Sie Zeichnen?", "Wie groß soll die Zeichnung sein?", "Welches Symbol soll verwendet werden?");
            Console.WriteLine();

        }


        public static string StringRead()
        {
            string name;

            Console.WriteLine("Bitte gib deinen Namen ein: ");

            name = Console.ReadLine();

            Console.WriteLine("Dein Name ist: " + name);

            return name;

        }

        public static int StringRead2()
        {

            Console.WriteLine("Bitte gib dein Alter ein: ");

            while (true)
            {
                try
                {
                    string input = Console.ReadLine();
                    int output = Convert.ToInt32(input);
                    return output;

                }
                catch
                {
                    Console.WriteLine("Bitte nur Zahlen eingeben!");
                }
            }

        }

        public static void GuessGame()
        {

            Random random = new Random();
            bool playAgain = true;
            int min = 1;
            int max = 100;
            int guess;
            int number;
            string response;

            while (playAgain)
            {
                guess = 0;
                response = "";
                number = random.Next(min, max + 1);

                while (guess != number)
                {
                    try
                    {
                        Console.WriteLine("Guess a number between " + min + " - " + max + " : ");
                        guess = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Guess: " + guess);

                        if (guess > number)
                        {
                            Console.WriteLine(guess + " is to high!");
                        }
                        else if (guess < number)
                        {
                            Console.WriteLine(guess + " is to low!");
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Try again!");

                    }


                }
                Console.WriteLine("Number: " + number);
                Console.WriteLine("You win!");

                Console.WriteLine("Would you like to play again (Y/N): ");
                response = Console.ReadLine();
                response = response.ToUpper();

                if (response == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
            }

        }

        public static void Menu(string greet, string askdraw, string asksize, string asksymbol)
        {

            string draw;
            int size;
            string symbol;

            bool drawagain = true;

            while (drawagain)
            {
                try
                {
                    Console.WriteLine(greet);
                    Console.WriteLine(" Was möchten Sie Zeichnen?");
                    Console.WriteLine("1) Christbaum\r\n2) Quader\r\n3) Rhombus");
                    Console.WriteLine(askdraw);
                    draw = Console.ReadLine();
                    Console.WriteLine(">>>" + draw);
                    Console.WriteLine(asksize);
                    size = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(">>>" + size);
                    Console.WriteLine(asksymbol);
                    symbol = Console.ReadLine();

                    if (draw == "1")
                    {

                    }
                    else if (draw == "2")
                    {

                    }
                    else if (draw == "3")
                    {

                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine();
                }
            }

        }

    }
}
