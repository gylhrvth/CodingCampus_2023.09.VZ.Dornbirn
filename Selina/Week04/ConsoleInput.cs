using Selina.Week01;
using Selina.Week04.Aufgabe;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Selina.Week04
{
    internal class ConsoleInput
    {
        public static  Random randomNumber = new Random();
        public static void Start()
        {
            int timer = 0;
            int guessNumber = 0;

           // Aufgabe 1:
            Output("String einlesen", ConsoleColor.Blue);
            string input = ReadText("Bitte gib einen Text ein:");
            Console.WriteLine($"Du hast diesen Text eingeben: {input}");
            Console.WriteLine("\n----------------------------------------------------------");


            //Aufgabe 2:
            Output("Zahl einlesen", ConsoleColor.Cyan);
            int number1 = ReadNumber("Gib eine Zahl ein:  ", "Du musst eine Zahl eingeben!  ");
            Console.Write($"Du hast diese Zahl eingeben: {number1}");
            Console.WriteLine("\n----------------------------------------------------------");

            //Aufagbe 3:
            Output("Willkommen beim super coolen Zahlen Ratespiel!", ConsoleColor.Magenta);
            Ratespiel(guessNumber, timer);

            //Aufgabe 4:
            Output("Willkommen bei meinen Aufgaben ", ConsoleColor.Magenta);
            do
            {
                int number = ReadNumber("Was möchten Sie zeichnen?\n1) Christbaum\n2) Quader\n3)Rhombus\nBitte wählen Sie nun?\n>>>", "Du musst eine Zahl eingeben!");
                if (number == 1)
                {
                    Christbaum.PrintChristmastree();
                }
                if (number == 2)
                {
                    Quader.PrintEmptySquare1();
                }
                if (number == 3)
                {
                    Rhombus.PrintRhombus();
                }
                Console.WriteLine("Möchten Sie noch was zeichen? (j/n)");


            }while()
           


        }
        public static void Ratespiel(int guessNumber, int timer)
        {
            int number = randomNumber.Next(1, 101);

            do
            {
                Console.Write("\nErrate die Zahl zwischen 0 und 100!\nGib die Zahl nun ein: \n>>>");
                guessNumber = Convert.ToInt32(Console.ReadLine());

                if (guessNumber > number)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\nGuess: {guessNumber}\nDie Zahl ist zu hoch!");
                    Console.ResetColor();
                }
                if (guessNumber < number)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\nGuess: {guessNumber}\nDie Zahl ist zu niedrig!");
                    Console.ResetColor();
                }
                timer++;
            } while (guessNumber != number);
            
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine($"Du hast gewonnen!!! Guesses: {timer} ");
            Console.ResetColor();
        }
        public static string Output(string output, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine($"\n\nAufgabe: {output}\n");
            Console.ResetColor();

            return output;
        }
        public static int ReadNumber(string prompt, string onError)
        {
            Console.Write(prompt);
            while (true)
            {
                try
                {
                    int ourNumber = Convert.ToInt32(Console.ReadLine());
                    return ourNumber;
                }
                catch (Exception exc)
                {
                    Console.Error.Write(onError);
                }
            }
        }
        public static string ReadText(string text)
        {
            string line = "";
            bool firstTry = true;
            while (line.CompareTo("") == 0)
            {
                if (!firstTry)
                {
                    Console.WriteLine("Bitte nochmal wiederholen!");
                }
                Console.Write(text);
                line = Console.ReadLine();
                line ??= "";
                line = line.Trim();
                firstTry = false;
            }
            return line;
        }
    }
}