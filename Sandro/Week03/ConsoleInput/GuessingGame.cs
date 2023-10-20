using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandro.Week03.ConsoleInput
{
    internal class GuessingGame
    {
        public static Random rand = new Random();
        static string RED = "\x1b[91m";
        static string MAGENTA = "\x1b[95m";
        static string NORMAL = "\x1b[39m";
        static string GREEN = "\x1b[92m";
        static string YELLOW = "\x1b[93m";
        static string BLUE = "\x1b[94m";
        static string CYAN = "\x1b[96m";
        static string GREY = "\x1b[97m";
        static string BOLD = "\x1b[1m";
        static string NOBOLD = "\x1b[22m";
        static string UNDERLINE = "\x1b[4m";
        static string NOUNDERLINE = "\x1b[24m";
        static string REVERSE = "\x1b[7m";
        static string NOREVERSE = "\x1b[27m";

        public static void Start()
        {
            int guessesmax = 10;
            int i = 0;
            int nummer = -1;

            String name = ReadText("Wie ist dein Name?");
            Console.WriteLine($"Willkommen {CYAN}*{name}*{NORMAL} beim super coolen Zahlen Ratespiel ");
            Console.WriteLine($"Du hast nur {CYAN}{guessesmax}{NORMAL} versuche!");
            int randomValue = rand.Next(101);

            while ((i < guessesmax) && (nummer != randomValue))
            {
                nummer = ReadNumber("Was ist deine Nummer", 0, 100);
                if (nummer < randomValue)
                {
                    Console.WriteLine($"Deine Zahl {BLUE}{nummer}{NORMAL} war zu {BLUE}niedrig{NORMAL}");
                    Console.WriteLine($"Noch {CYAN} {guessesmax - 1 - i}{NORMAL} Versuche übrig");
                }
                else if (nummer > randomValue)
                {
                    Console.WriteLine($"Deine Zahl {RED}{nummer}{NORMAL} war zu {RED}hoch{NORMAL}");
                    Console.WriteLine($"Noch {CYAN} {guessesmax - 1 - i}{NORMAL} Versuche übrig");
                }
                ++i;
            }
            if (nummer == randomValue)
            {
                Console.WriteLine("du hast gewonnen!!!");
                Console.WriteLine($"Die Zahl {GREEN}{nummer}{NORMAL} war RICHTIG!");
            }
            else
            {
                Console.WriteLine("Schade ... \nDie richtige Zahl war: " + randomValue);
            }
            Console.WriteLine("Danke fürs Spielen");
        }

        static int ReadNumber(String message, int minValue, int maxValue)
        {
            int value = 0;
            bool numberIsValid = false;

            while (!numberIsValid)
            {
                Console.WriteLine(message);
                try
                {
                    String input = Console.ReadLine();

                    value = Convert.ToInt32(input);
                    if ((value >= minValue) && (value <= maxValue))
                    {
                        numberIsValid = true;
                    }
                    else
                    {
                        Console.WriteLine("Die Zahl muss zwischen " + minValue + " und " + maxValue + " sein ");
                    }

                }
                catch (FormatException exc)
                {
                    //Console.Error.WriteLine(exc.StackTrace);
                    Console.WriteLine("Deine Zahl ist ungültig!!!");
                }

            }
            return value;

        }
        static String ReadText(String message)
        {
            Console.WriteLine(message);

            while (true)
            {
                try
                {
                    String input = Console.ReadLine();

                    string ourText = input;
                    ourText = ourText.Trim();
                    return ourText;
                }
                catch (FormatException exc)
                {
                    //Console.Error.WriteLine(exc.StackTrace);
                    Console.Error.WriteLine(exc);
                }
            }
        }



    }
}
