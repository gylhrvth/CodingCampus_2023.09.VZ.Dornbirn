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
            //Console.WriteLine("String Read:");
            //StringRead();
            //Console.WriteLine();

            //Console.WriteLine("String Read2:");
            //StringRead2();
            //Console.WriteLine();

            //Console.WriteLine("Guess Game:");
            //GuessGame();
            //Console.WriteLine();

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

        //public static int StringRead2()
        //{

        //    Console.WriteLine("Bitte gib dein Alter ein: ");

        //    while (true)
        //    {
        //        try
        //        {
        //            string input = Console.ReadLine();
        //            int output = Convert.ToInt32(input);
        //            return output;

        //        }
        //        catch
        //        {
        //            Console.WriteLine("Bitte nur Zahlen eingeben!");
        //        }
        //    }

        //}

        //public static void GuessGame()
        //{

        //    Random random = new Random();
        //    bool playAgain = true;
        //    int min = 1;
        //    int max = 100;
        //    int guess;
        //    int number;
        //    string response;

        //    while (playAgain)
        //    {
        //        guess = 0;
        //        response = "";
        //        number = random.Next(min, max + 1);

        //        while (guess != number)
        //        {
        //            try
        //            {
        //                Console.WriteLine("Guess a number between " + min + " - " + max + " : ");
        //                guess = Convert.ToInt32(Console.ReadLine());
        //                Console.WriteLine("Guess: " + guess);

        //                if (guess > number)
        //                {
        //                    Console.WriteLine(guess + " is to high!");
        //                }
        //                else if (guess < number)
        //                {
        //                    Console.WriteLine(guess + " is to low!");
        //                }
        //            }
        //            catch
        //            {
        //                Console.WriteLine("Try again!");

        //            }


        //        }
        //        Console.WriteLine("Number: " + number);
        //        Console.WriteLine("You win!");

        //        Console.WriteLine("Would you like to play again (Y/N): ");
        //        response = Console.ReadLine();
        //        response = response.ToUpper();

        //        if (response == "Y")
        //        {
        //            playAgain = true;
        //        }
        //        else
        //        {
        //            playAgain = false;
        //        }
        //    }

        //}

        public static void Menu(string greet, string askdraw, string asksize, string asksymbol)
        {

            string draw;
            int size;
            string symbol;
            string answer;
            bool drawagain = true;

            while (drawagain)
            {

                Console.WriteLine(greet);
                Console.WriteLine(askdraw);
                Console.WriteLine("1) Square\r\n2) Triangle\r\n3) Rhombus");
                while (true)
                {
                    draw = Console.ReadLine();

                    if(draw == "1" || draw == "2" || draw == "3")
                    {
                        break;
                    } else
                    {
                        Console.WriteLine("FALSCHE Auswahl!!!!!!111111");
                    }
                }


                Console.WriteLine(">>>" + draw);
                Console.WriteLine(asksize);
                size = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(">>>" + size);
                Console.WriteLine(asksymbol);
                symbol = Console.ReadLine();

                if (draw == "1")
                {
                    printEmptySquare(symbol, size);
                }
                else if (draw == "2")
                {
                    printTriangle(symbol, size);
                }
                else if (draw == "3")
                {
                    printRhombus(symbol, size);
                }
                else
                {
                    Console.WriteLine("Bitte gib nur gültige Zahlen ein!");
                }


                Console.WriteLine();

                Console.WriteLine("Möchten Sie noch etwas zeichnen? (Y / N)");
                answer = Console.ReadLine();
                answer = answer.ToUpper();

                if (answer == "Y")
                {
                    drawagain = true;
                }
                else if (answer == "N")
                {
                    drawagain = false;
                }


            }
            Console.WriteLine("Auf Wiedersehen!");

        }

    }
}
