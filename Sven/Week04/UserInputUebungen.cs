using System;
using System.Linq.Expressions;
using static System.Runtime.InteropServices.JavaScript.JSType;


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

        }


        public static string StringRead()
        {
            System.String name;

            Console.WriteLine("Bitte gib deinen Namen ein: ");

            name = Console.ReadLine();

            Console.WriteLine("Dein Name ist: " + name);

            return name;

        }

        public static int StringRead2()
        {

            Console.WriteLine("Bitte gib deine alter ein: ");

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
                        
                    }
                   

                }
                Console.WriteLine("Number: " + number);
                Console.WriteLine("YOU WIN!");

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

    }
}
