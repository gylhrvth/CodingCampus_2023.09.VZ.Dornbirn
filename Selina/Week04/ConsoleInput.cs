using Selina.Week04.Arrays.Menü;
using Selina.Week04.Aufgabe;

namespace Selina.Week04.ConsoleInput
{
    internal class ConsoleInput
    {
        public static Random randomNumber = new Random();
        public static void Start()
        {
            int timer = 0;
            int guessNumber = 0;
            string repeat;
            string repeatResult = "N";
            float num1 = 0;
            float result = 0;


            //// Aufgabe 1:
            //Output("String einlesen", ConsoleColor.Blue);
            //string input = ReadText("Bitte gib einen Text ein:");
            //Console.WriteLine($"Du hast diesen Text eingeben: {input}");
            //Console.WriteLine("\n----------------------------------------------------------");


            ////Aufgabe 2:
            //Output("Zahl einlesen", ConsoleColor.Cyan);
            //int number1 = ReadNumber("Gib eine Zahl ein:  ", "Du musst eine Zahl eingeben!  ");
            //Console.Write($"Du hast diese Zahl eingeben: {number1}");
            //Console.WriteLine("\n----------------------------------------------------------");

            ////Aufagbe 3:
            //Output("Willkommen beim super coolen Zahlen Ratespiel!", ConsoleColor.Magenta);
            //Ratespiel(guessNumber, timer);

            ////Aufgabe 4:
            //Output("Willkommen bei meinen Aufgaben ", ConsoleColor.Magenta);
            //Menü(); // Programm Aufagbe 4
            //Text(); // Text: Auf Wiedersehen!

            //Aufageb 5:
            Output("Taschenrechner von Selina", ConsoleColor.Cyan);
            OutputUser();

            //Aufgabe 6:
            //for(int i = 0; i <= 5.5; i++)
            //{
            //    for(int j = 0; j <= 8.5; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
        }





        //Aufagbe 3:
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

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Du hast gewonnen!!! Guesses: {timer} ");
            Console.ResetColor();
        }

        //Output und Readnumber/Text für alle Aufgaben
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

        //Aufagbe 4:
        public static void Text()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("A");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("u");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("f ");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("W");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("i");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("e");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("d");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("e");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("r");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("s");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("e");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("h");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("e");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("n!");
            Console.ResetColor();
        }
        public static void Menü()
        {
            string repeat;
            do
            {
                int number = ReadNumber("\nWas möchten Sie zeichnen?\n1) Christbaum\n2) Quader\n3) Rhombus\nBitte wählen Sie nun?\n>>>", "Du musst eine Zahl eingeben!");

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
                else if (number != 1 && number != 2 && number != 3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nDu musst 1,2 oder 3 eingeben!");
                    Console.ResetColor();
                    number = ReadNumber("\nWas möchten Sie zeichnen?\n1) Christbaum\n2) Quader\n3) Rhombus\nBitte wählen Sie nun?\n>>>", "Du musst eine Zahl eingeben!");
                }
                repeat = ReadText("\n\nMöchten Sie noch was zeichen? (j/n)? ");

                if (repeat == "N" || repeat == "n")
                {
                    Console.Clear();
                }
                else if (repeat != "N" && repeat != "n" && repeat != "J" && repeat != "j")
                {
                    repeat = ReadText("Gib j oder n ein!");
                }

            } while (repeat == "j" || repeat == "J");
        }

        //Aufabe 5:
        public static float ReadNumberFloat(string prompt, string onError)
        {
            Console.Write(prompt);
            while (true)
            {
                try
                {
                    float ourNumber = Convert.ToSingle(Console.ReadLine());
                    return ourNumber;
                }
                catch (Exception exc)
                {
                    Console.Error.Write(onError);
                }
            }
        }
        public static float Calculater(float num1, float num2, string type)
        {
            float result = 0;
            float memory = 0;

            switch (type)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Fehler: Division durch Null ist nicht erlaubt.");
                    }
                    break;
                case "^":
                    result = Convert.ToSingle(Math.Pow(num1, num2));
                    break;
                case "MC":
                    Console.Clear();
                    break;
                case "M+":
                    memory = result + result;
                    break;
                case "M-":
                    memory = result;
                    break;
                case "MR":
                    memory = result;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nUngültiger Operator!");
                    Console.ResetColor();
                    type = ReadText("Bitte gib eine Rechnungsart ein: (+,-,*,^,/) ");
                    return Calculater(num1, num2, type);
            }
            return result;
        }
        public static void OutputUser()
        {
            string repeat;
            string repeatResult = "N";
            float num1 = 0;
            float result = 0;

            do
            {
                if (repeatResult == "n" || repeatResult == "N")
                {
                    num1 = ReadNumberFloat("Gib deine erste Zahl ein: ", "Du musst eine Zahl eingeben! ");
                }
                if (repeatResult == "j" || repeatResult == "J")
                {
                    num1 = result;
                }

                string type = ReadText("Bitte gib eine  ein Operator ein: (+,-,*,^,/) ");
                if (type == "MC" || type == "M+" || type == "M-" || type == "MR")
                {
                    type = ReadText("Bitte gib ein weiteren Operator ein: (+,-,*,^,/) ");
                }
                float num2 = ReadNumberFloat("Gib deine erste Zahl ein: ", "Du musst eine Zahl eingeben! ");

                result = Calculater(num1, num2, type);    //Rechnet eingabe von User
                Console.WriteLine($"\nDas Ergebnis ist {result}");    // output Ergebnis

                repeat = ReadText("\nMöchten Sie nochmal rechnen (j/n)? ");   // Wiederholung

                if (repeat == "N" || repeat == "n")
                {
                    Console.Clear();
                }
                else if (repeat != "N" && repeat != "n" && repeat != "J" && repeat != "j")
                {
                    repeat = ReadText("Gib j oder n ein!");
                }
                if (repeat == "J" || repeat == "j")
                {
                    repeatResult = ReadText("Möchten Sie das Ergebnis weiterverwenden? (j/n)");
                    Console.WriteLine();
                }

            } while (repeat == "j" || repeat == "J");

        }


    }
}