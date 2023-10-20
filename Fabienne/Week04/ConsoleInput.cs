using System;
using System.Net.Cache;
using System.Runtime.InteropServices.Marshalling;

namespace Fabienne.Week04
{
    internal class ConsoleInput
    {
        public static void Start()
        {
            //String();
            //Console.WriteLine();
            //Int("Enter number: ");
            //Console.WriteLine();
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
        public static int Int(string msg)
        {
            int Zahl = Int32.MinValue;
            while (Zahl == Int32.MinValue)
            {
                Console.Write(msg);

                try
                {
                    Zahl = Convert.ToInt32(Console.ReadLine());
                    
                }
                catch (FormatException)
                {
                    Console.WriteLine("No no this numbre");
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

                guess = Int("Enter number between 1-100: ");


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
        public static void Menue()
        {
            int answer = 0;

            int size = 0;

            string sign;

            Console.WriteLine("Welcome in my Menue!");
            Console.WriteLine("What do you wish to be printed?");
            Console.WriteLine("1. Christmastree");
            Console.WriteLine("2. Quader");
            Console.WriteLine("3. Rhombus");
            Console.WriteLine("Please choose! (Must be a number)");

            while (answer == 0 || answer >= 3)
            {
                try
                {
                    answer = Convert.ToInt32(Console.ReadLine());
                    if (answer == 1)
                    {
                        Console.WriteLine("How big should the Christmastree be?");
                        while(size == 0)
                        {
                            try
                            {
                                size = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Which sign should be used?");
                                sign = Console.ReadLine();
                                Console.WriteLine("Christmastree (" + size + ")");
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
                            catch (FormatException)
                            {
                                Console.WriteLine("That is not a valid number, try again: ");
                            }
                        }
                    }
                    else if (answer == 2)
                    {
                        Console.WriteLine("How big should the Quader be?");
                        while (size == 0)
                        {
                            try
                            {
                                size = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Which sign should be used?");

                                sign = Console.ReadLine();

                                Console.WriteLine("Quader (\'" + sign + "\', " + size + ")");

                                for (int j = 0; j < size; j++)
                                {
                                    for (int i = 1; i < size; i++)
                                    {
                                        Console.Write(sign);
                                    }

                                    Console.WriteLine(sign);
                                }
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("That is not a valid number, try again: ");
                            }
                        }
                    }
                    else if (answer == 3)
                    {
                        Console.WriteLine("How big should the Rhombus be?");
                        while (size == 0)
                        {
                            try
                            {
                                size = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Which sign should be used?");

                                sign = Console.ReadLine();

                                Console.WriteLine("Rhombus (\'" + sign + "\', " + size + ")");

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
                            catch (FormatException)
                            {
                                Console.WriteLine("This is not a valid number, try again: ");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("This is not a valid number, try again: ");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("This is not a valid number, try again: ");
                }
            }
            Console.WriteLine("Would you like to draw something else as well?(y/n)"); //mach ein try again 

            Console.WriteLine("Good bye!");
        }     
    }

}
