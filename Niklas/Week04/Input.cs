using Niklas.Week01;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Security.Cryptography.X509Certificates;

namespace Niklas.Week04
{
    internal class Input
    {
        public static void Start()
        {
            // int readString = StringEinlesen("Please enter your a Number: ");

            // int readNumber = ZahlEinlesen("Please enter a number: ", "That's not a number! Try again: ");
            //  Console.WriteLine("Your number is: " + readNumber);

            ////RateSpiel();


            //Console.WriteLine("What is the min number? "); 
            //int min = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("What is the max number? ");
            //int max = Convert.ToInt32(Console.ReadLine());
            //RateSpielCustom(max, min);

            Console.WriteLine("______________________________________");

            int x = 0;

            while (x == 0)
            {
                Console.WriteLine("What do you wanna draw?");
                Console.WriteLine("1) Char\n2) Square\n3) Triangle Bottom Left\n4) Triangle Top Left\n5) Triangle Top Right\n6) Triangle Bottom Right\n7) Empty Square\n8) Slash\n9) Triangle\n10) Rhomnus\n11) X\n12) Christmas Tree");
                int form = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("What size do you want? ");
                int size = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What symbol do you want? ");
                char symbol = Convert.ToChar(Console.ReadLine());
                //Menu
                Menu(symbol, size, form, x);

                if (form == 8)
                {
                    Console.WriteLine("In what direction do you want the slash to be?");
                    Console.WriteLine("1) = \\ |2) = /");
                    int input = Convert.ToInt32(Console.ReadLine());
                    if (input == 1)
                    {
                        Methoden.PrintSlash(Convert.ToString(symbol), size, true);
                    }
                    if (input == 2)
                    {
                        Methoden.PrintSlash(Convert.ToString(symbol), size, false);
                    }
                }
            }


            Console.WriteLine("____________________________________");

            //Calculator
            Console.WriteLine("Enter your fist number!");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What do you wanna calcualte the numbers with?");
            Console.WriteLine("1) +\n2) -\n3) *\n4) ^\n5) /");
            int i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number you wanna calculate with!");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Calculator(num1, num2, i);

        }

        static string StringEinlesen(string input)
        {
            Console.WriteLine(input);

            input = Console.ReadLine();
            string number = Convert.ToString(input);
            return number;
        }





        static int ZahlEinlesen(string promt, string error)
        {
            Console.WriteLine(promt);

            while (true)
            {
                try
                {
                    string input2 = Console.ReadLine();
                    int number = Convert.ToInt32(input2);
                    return number;
                }
                catch (FormatException exc)
                {
                    Console.Error.WriteLine(error);
                }
            }
        }

        static void RateSpiel()
        {
            Random rand = new Random();
            int min = 0;
            int max = 100;
            int guess;
            int number;
            string response;

            guess = 0;
            response = "";
            number = rand.Next(min, max + 1);

            while (guess != number)
            {
                Console.WriteLine("Guess a number between " + min + " - " + max + " : ");
                guess = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Guess: " + guess);
                if (guess > number && guess < max)
                {
                    Console.WriteLine("Your number is too big!");
                }
                if (guess < number && guess > min)
                {
                    Console.WriteLine("Your number is too low!");
                }
                if (guess == number)
                {
                    Console.WriteLine("You have won! The number was: " + number);
                }
                else if (guess < min || guess > max)
                {
                    Console.WriteLine(guess + " is not a valid number!");
                }
            }


        }

        static int RateSpielCustom(int maxnumber, int minnumber)
        {
            while (true)
            {
                Random rand = new Random();
                int min = minnumber;
                int max = maxnumber;
                int guess;
                int number;
                string response;

                guess = 0;
                response = "";
                number = rand.Next(min, max + 1);

                try
                {

                    while (guess != number)
                    {

                        Console.WriteLine("Guess a number between " + min + " - " + max + " : ");
                        guess = Convert.ToInt32(Console.ReadLine());
                        if (guess > number && guess <= max)
                        {
                            Console.WriteLine(guess + " is too big!");
                        }
                        if (guess < number && guess >= min)
                        {
                            Console.WriteLine(guess + " is too low!");
                        }
                        if (guess == number)
                        {
                            Console.WriteLine("You have won! The number was: " + number);
                        }
                        else if (guess < min || guess > max)
                        {
                            Console.WriteLine(guess + " is not a valid number!");
                        }
                    }


                }
                catch (FormatException exc)
                {
                    Console.Error.WriteLine("You can only write numbers!");
                }
                return number;
            }
        }


        static void Menu(char symbol, int size, int form, int end)
        {
            int x = 0;

            while (x == 0)
            {
                if (form == 1)
                {
                    Methoden.PrintChars(Convert.ToString(symbol), size);
                }
                if (form == 2)
                {
                    Methoden.PrintSquare(Convert.ToString(symbol), size);
                }
                if (form == 3)
                {
                    Methoden.PrintTriangleBottomLeft(Convert.ToString(symbol), size);
                }
                if (form == 4)
                {
                    Methoden.PrintTriangleTopLeft(Convert.ToString(symbol), size);
                }
                if (form == 5)
                {
                    Methoden.PrintTriangleTopRight(Convert.ToString(symbol), size);
                }
                if (form == 6)
                {
                    Methoden.PrintTriangleBottomRight(Convert.ToString(symbol), size);
                }
                if (form == 7)
                {
                    Methoden.PrintEmptySquare(Convert.ToString(symbol), size);
                }
                if (form == 8)
                {

                }
                if (form == 9)
                {
                    Methoden.PrintTriangle(Convert.ToString(symbol), size);
                }
                if (form == 10)
                {
                    Methoden.PrintRhombus(Convert.ToString(symbol), size);
                }
                if (form == 11)
                {
                    Methoden.PrintX(Convert.ToString(symbol), size);
                }
                if (form == 12)
                {
                    Methoden.PrintTree(Convert.ToString(symbol), size);
                }

                Console.WriteLine("\nDo you wanna draw something else? [y/n]");
                // int end = Convert.ToChar(Console.ReadLine());
                if (Console.ReadLine() == "y")
                {
                    end = 0;
                }
                if (Console.ReadLine() == "n")
                {
                    Console.WriteLine("Goodybe! The program is closing...");
                    end++;
                }
                else
                {
                    Console.WriteLine("You entered an invalid char!");
                }
            }
        }
        static void Calculator(long num1, long num2, int i)
        {
            if (i == 1)
            {
                num1 += num2;
            }
            if (i == 2)
            {
                num1 -= num2;
            }
            if (i == 3)
            {
                num1 *= num2;
            }
            if (i == 4)
            {

                long times = num1;
                while (num2 > 1)
                {
                    num1 *= times;
                    num2--;
                }
            }
            if (i == 5)
            {
                num1 /= num2;
            }
            Console.WriteLine("Your result is: " + num1);
        }

    }
}