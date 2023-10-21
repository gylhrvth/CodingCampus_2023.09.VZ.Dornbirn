using System;
using System.IO.Pipes;
using System.Net.Cache;
using System.Runtime.InteropServices.Marshalling;
using System.Xml.Serialization;

namespace Fabienne.Week04
{
    internal class ConsoleInput
    {
        public static void Start()
        {
            //String();
            //Int("Enter number: ");
            //GuessingGame();
            Menue();

        }
        public static void PrintChars(string x, int size, bool newline)
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write(x);
            }
            if (newline)
            {
                Console.WriteLine();
            }
        }
        public static string String() 
        {
            Console.Write("Gimme wodr: ");
            string Name = Console.ReadLine();

            return Name;
        }
        public static int ReadIntFromConsole(string msg, int min, int max)
        {
            int Zahl = Int32.MinValue;
            while (Zahl == Int32.MinValue)
            {
                Console.Write(msg);

                try
                {
                    Zahl = Convert.ToInt32(Console.ReadLine());
                    if (Zahl < min || Zahl > max)
                    {
                        Console.WriteLine("This number ist not allowed. ");
                        Zahl = Int32.MinValue;
                    }
                    
                }
                catch (FormatException)
                {
                    Console.WriteLine("This is not a valid number. ");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("This is toooooo big. ");
                }
            }
            return Zahl;
        }
        public static void GuessingGame()
        {
            Random random = new Random();
            int num = random.Next(100);
            int guess = 0;
            int score = 0;

            while (guess != num)
            {
                score++;

                guess = ReadIntFromConsole("Enter number between 1-100: ", 1, 100);


                if (guess == num)
                {
                    Console.WriteLine("You won!");
                    Console.WriteLine("You took " + score + " tries");
                }

                else if (guess > num)
                {
                    Console.WriteLine(guess + " is too high");
                }

                else
                {
                    Console.WriteLine(guess + " is too low");
                }
            }
        }
        public static void PrintRombus(int size, string sign)
        {
            PrintChars(" ", size, false);
            Console.WriteLine(sign);

            for (int i = 1; i < size - 1; i++)
            {
                PrintChars(" ", size - i, false);
                Console.Write(sign);

                PrintChars(" ", i * 2 - 1, false);
                Console.WriteLine(sign);
            }

            for (int j = 1; j < size; j++)
            {
                PrintChars(" ", j, false);
                Console.Write(sign);

                PrintChars(" ", ((size - j) * 2) - 1, false);
                Console.WriteLine(sign);
            }

            PrintChars(" ", size, false);
            Console.WriteLine(sign);
        }
        public static void PrintQuader(int size, string sign)
        {
            for (int j = 0; j < size; j++)
            {
                for (int i = 1; i < size; i++)
                {
                    Console.Write(sign);
                }

                Console.WriteLine(sign);
            }
        }
        public static void PrintChristmastree(int size, string sign)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            if (size <= 0)
            {
                return;
            }

            PrintChars(" ", size, false);
            Console.WriteLine(sign);

            for (int i = 1; i < size; i++)
            {
                PrintChars(" ", size - i, false);
                Console.Write(sign);

                PrintChars(sign, i * 2 - 1, false);
                Console.WriteLine(sign);
            }

            PrintChars(sign, size * 2 + 1, true);
            Console.ForegroundColor = ConsoleColor.DarkRed;

            for (int j = 0; j <= size; j++)
            {
                PrintChars("O", 1, false);
                PrintChars(" ", 1, false);
            }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkGray;

            for (int i = 0; i < 2; ++i)
            {
                PrintChars(" ", size - 3, false);
                PrintChars("+", size - 2, false);
                Console.WriteLine();
            }

            Console.ResetColor();
        }
        public static void Menue()
        {
            int size = 0;
            string sign;

            Console.WriteLine("Welcome in my Menue!");

            bool doAgain = true;
            while (doAgain)
            {
                Console.WriteLine("What do you wish to be printed?");
                Console.WriteLine("1. Christmastree");
                Console.WriteLine("2. Quader");
                Console.WriteLine("3. Rhombus");

                int answer = ReadIntFromConsole("Please choose: ", 1, 3);
                    if (answer == 1)    //christmastree
                    {
                        size = ReadIntFromConsole("How big should the Christmastree be? ", 1, 100);
                        Console.WriteLine("Which sign should be used? ");
                        sign = Console.ReadLine();
                        Console.WriteLine("Christmastree (" + size + ")");
                        PrintQuader(size, sign);
                    }
                    else if (answer == 2) //quader 
                    {                                                                             
                        size = ReadIntFromConsole("How big should the Quader be? ", 1, 100);
                        Console.WriteLine("Which sign should be used? ");
                        sign = Console.ReadLine();
                        Console.WriteLine("Quader (\'" + sign + "\', " + size + ")");
                        PrintQuader(size, sign);                                                                            
                    }
                    else //rhombus 
                    {
                        size = ReadIntFromConsole("How big should the Rhombus be? ", 1, 100);
                        Console.WriteLine("Which sign should be used? ");
                        sign = Console.ReadLine();
                        Console.WriteLine("PrintRhombus (\'" + sign + "\', " + size + ")");
                        PrintRombus(size, sign);
                    }
                string tryAgain = "";

                while (tryAgain != "y" && tryAgain != "n")
                {
                    Console.WriteLine("Would you like to draw something else as well?(y/n) ");
                    tryAgain = Console.ReadLine();
                }
                if (tryAgain == "y")
                {
                    doAgain = true;
                }
                else
                {
                    Console.WriteLine("Good bye!");
                    doAgain = false;
                }
            }
        }    
        public static void Calculator()
        {

        }
    }
}
