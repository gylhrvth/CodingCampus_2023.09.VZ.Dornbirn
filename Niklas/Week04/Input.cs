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
using System.Runtime.InteropServices;
using System.Numerics;

namespace Niklas.Week04
{
    internal class Input
    {
        public static void Start()
        {
            //string readString = StringEinlesen("Please enter a Number: ");

            //int readNumber = ZahlEinlesen("Please enter a number: ", "That's not a number! Try again: ");
            //Console.WriteLine("Your number is: " + readNumber);

            ////RateSpiel();


            //Console.WriteLine("What is the min number? ");
            //Console.Write(">>>: ");
            //int min = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("What is the max number? ");
            //Console.Write(">>>: ");
            //int max = Convert.ToInt32(Console.ReadLine());
            //RateSpielCustom(max, min);

            //Console.WriteLine("______________________________________");

            //int x = 0;

            //while (x == 0)
            //{
            //    try
            //    {

            //        Console.WriteLine("What do you wanna draw?");
            //        Console.WriteLine("1) Char\n2) Square\n3) Triangle Bottom Left\n4) Triangle Top Left\n5) Triangle Top Right\n6) Triangle Bottom Right\n7) Empty Square\n8) Slash\n9) Triangle\n10) Rhomnus\n11) X\n12) Christmas Tree");
            //        Console.Write(">>>:  ");
            //        int form = Convert.ToInt32(Console.ReadLine());

            //        while (x == 5)
            //        {
            //            Console.WriteLine("Wrong number!");
            //            x = 1;
            //        }

            //        Console.WriteLine("What size do you want? ");
            //        Console.Write(">>>: ");
            //        int size = Convert.ToInt32(Console.ReadLine());
            //        Console.WriteLine("What symbol do you want? ");
            //        Console.Write(">>>: ");
            //        char symbol = Convert.ToChar(Console.ReadLine());
            //        //Menu
            //        Menu(symbol, size, form, x);

            //        if (form == 8)
            //        {
            //            Console.WriteLine("In what direction do you want the slash to be?");
            //            Console.WriteLine("1) = \\ \n2) = /");
            //            Console.Write(">>>:  ");
            //            int input = Convert.ToInt32(Console.ReadLine());
            //            if (input == 1)
            //            {
            //                Methoden.PrintSlash(Convert.ToString(symbol), size, true);
            //            }
            //            if (input == 2)
            //            {
            //                Methoden.PrintSlash(Convert.ToString(symbol), size, false);
            //            }
            //        }

            //        Console.WriteLine("\nDo you wanna draw something else? [y/n (2x)]");
            //        Console.Write(">>>:  ");

            //        x++;

            //        while (x == 1)
            //        {
            //            if (Console.ReadLine() == "y")
            //            {
            //                x = 0;
            //            }
            //            else if (Console.ReadLine() == "n")
            //            {
            //                Console.WriteLine("Goodbye! The program is closing...");
            //                x = 2;
            //            }

            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //        x = 0;
            //    }
            //}



            //Console.WriteLine("____________________________________");

            ////Calculator
            //Console.WriteLine("Enter your fist number!");
            //Console.Write(">>>:  ");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("What do you wanna calcualte the numbers with?");
            //Console.WriteLine("1) +\n2) -\n3) *\n4) ^\n5) /");
            //Console.Write(">>>:  ");
            //int i = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the second number you wanna calculate with!");
            //Console.Write(">>>:  ");
            //int num2 = Convert.ToInt32(Console.ReadLine());

            //Calculator(num1, num2, i);

            ////CalculatorExtended

            //int y = 0;

            //try
            //{
            //    while (y == 0)
            //    {
            //        Console.WriteLine("Enter your fist number!");
            //        Console.Write(">>>:  ");
            //        int number1 = Convert.ToInt32(Console.ReadLine());
            //        Console.WriteLine("What do you wanna calcualte the numbers with?");
            //        Console.WriteLine("1) +\n2) -\n3) *\n4) ^\n5) /");
            //        Console.Write(">>>:  ");
            //        int j = Convert.ToInt32(Console.ReadLine());
            //        Console.WriteLine("Enter the second number you wanna calculate with!");
            //        Console.Write(">>>:  ");
            //        int number2 = Convert.ToInt32(Console.ReadLine());

            //        CalculatorExtended(number1, number2, j);

            //        y++;

            //        while (y == 1)
            //        {
            //            Console.WriteLine("Do you wanna make a new calculation? (y/n [2x])");
            //            Console.Write(">>>:  ");

            //            if (Console.ReadLine() == "y")
            //            {
            //                y = 0;
            //            }
            //            else if (Console.ReadLine() == "n")
            //            {
            //                Console.WriteLine("Goodbye! The program is closing...");
            //                y = 2;
            //            }
            //        }
            //    }



            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    y = 0;
            //}

            ////CalculatorInfinite
            //int z = 0;
            //try
            //{
            //    Console.WriteLine("Press '=' whenever you're done with the calculation!");
            //    Console.WriteLine("******************************************************");

            //    Console.WriteLine("Enter a number you wanna calculate with!");
            //    Console.Write(">>>:  ");
            //    long number1 = Convert.ToInt32(Console.ReadLine());

            //    while (z == 0)
            //    {
            //        Console.WriteLine();
            //        Console.WriteLine("What do you wanna calcualte the numbers with?");
            //        Console.WriteLine("1) +\n2) -\n3) *\n4) ^\n5) /");
            //        Console.Write(">>>: ");
            //        int j = Convert.ToInt32(Console.ReadLine());

            //        Console.WriteLine();
            //        Console.WriteLine("Enter another number you wanna calculate with!");
            //        Console.Write(">>>: ");
            //        long number2 = Convert.ToInt32(Console.ReadLine());


            //        number1 = CalculatorInfinite(number1, number2, j);


            //        string end = Convert.ToString(Console.ReadLine());
            //        if (end == "=")
            //        {
            //            Console.WriteLine("Your final result is: " + number1);
            //            z = 2;
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    z = 0;
            //}

            //CalculatorMemory
            Console.WriteLine("_____________________________________________________");

            int z = 2;

            try
            {
                for (z = 2; z > 0; z--)
                {
                    Console.WriteLine("Press '=' whenever you're done with the calculation!");
                    Console.WriteLine("_____________________________________________________");
                    Console.WriteLine("Enter 'MC' to clear your memory \n Enter 'M+' to add memory \n Enter 'M-' to remove memory \n Enter 'MR' to print out your memory!");
                    Console.WriteLine("*****************************************************");
                }
                for (z = 0; z < 1; z++)
                {
                    Console.WriteLine("Enter a number you wanna calculate with!");
                    Console.Write(">>>:  ");
                    long number1 = Convert.ToInt32(Console.ReadLine());
                    while (z == 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("What do you wanna calcualte the numbers with?");
                        Console.WriteLine("1) +\n2) -\n3) *\n4) ^\n5) /");
                        Console.Write(">>>: ");
                        int j = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine();
                        Console.WriteLine("Enter another number you wanna calculate with!");
                        Console.Write(">>>: ");
                        long number2 = Convert.ToInt32(Console.ReadLine());


                        number1 = CalculatorMemory(number1, number2, j);


                        string end = Convert.ToString(Console.ReadLine());
                        end.ToUpper();
                        end.ToLower();
                        if (end == "=")
                        {
                            Console.WriteLine("Your final result is: " + number1);
                            z = 2;
                        }

                        string Memory = Convert.ToString(Console.ReadLine());
                        if (Memory == "MC")
                        {
                            number1 = 0;
                            number2 = 0;
                            j = 0;
                            z = 1;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                z = 0;
            }

        }

        static string StringEinlesen(string input)
        {
            Console.WriteLine(input);
            Console.Write(">>>:  ");

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
                    Console.Write(">>>:  ");
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
                        Console.Write(">>>:  ");
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
            while (x < 1)
            {
                if (form == 1)
                {
                    Console.WriteLine();
                    Methoden.PrintChars(Convert.ToString(symbol), size);
                    x++;
                }
                if (form == 2)
                {

                    Console.WriteLine();
                    Methoden.PrintSquare(Convert.ToString(symbol), size);
                    x++;
                }
                if (form == 3)
                {

                    Console.WriteLine();
                    Methoden.PrintTriangleBottomLeft(Convert.ToString(symbol), size);
                    x++;
                }
                if (form == 4)
                {

                    Console.WriteLine();
                    Methoden.PrintTriangleTopLeft(Convert.ToString(symbol), size);
                    x++;
                }
                if (form == 5)
                {

                    Console.WriteLine();
                    Methoden.PrintTriangleTopRight(Convert.ToString(symbol), size);
                    x++;
                }
                if (form == 6)
                {

                    Console.WriteLine();
                    Methoden.PrintTriangleBottomRight(Convert.ToString(symbol), size);
                    x++;
                }
                if (form == 7)
                {

                    Console.WriteLine();
                    Methoden.PrintEmptySquare(Convert.ToString(symbol), size);
                    x++;
                }
                if (form == 8)
                {

                    Console.WriteLine();
                    x++;
                }
                if (form == 9)
                {

                    Console.WriteLine();
                    Methoden.PrintTriangle(Convert.ToString(symbol), size);
                    x++;
                }
                if (form == 10)
                {

                    Console.WriteLine();
                    Methoden.PrintRhombus(Convert.ToString(symbol), size);
                    x++;
                }
                if (form == 11)
                {

                    Console.WriteLine();
                    Methoden.PrintX(Convert.ToString(symbol), size);
                    x++;
                }
                if (form == 12)
                {

                    Console.WriteLine();
                    Methoden.PrintTree(Convert.ToString(symbol), size);
                    x++;
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
        static void CalculatorExtended(long num1, long num2, int i)
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

        static long CalculatorInfinite(long num1, long num2, int i)
        {
            long result = 0; ;

            if (i == 1)
            {
                num1 += num2;
                Console.WriteLine();
                Console.Write(">>>: ");
                Console.WriteLine($"{num1}");
                result = num1;
            }
            if (i == 2)
            {
                num1 -= num2;
                Console.WriteLine();
                Console.Write(">>>: ");
                Console.WriteLine($"{num1}");
                result = num1;
            }
            if (i == 3)
            {
                num1 *= num2;
                Console.WriteLine();
                Console.Write(">>>: ");
                Console.WriteLine($"{num1}");
                result = num1;
            }
            if (i == 4)
            {
                int c = 0;
                long times = num1;
                Console.WriteLine();
                while (num2 > 1)
                {
                    num1 *= times;
                    c++;
                    num2--;
                    Console.Write(">>>: ");
                    Console.WriteLine($"Steps: {c}, Result = {num1}");
                    result = num1;
                }
            }
            if (i == 5)
            {
                num1 /= num2;
                Console.WriteLine();
                Console.Write(">>>: ");
                Console.WriteLine($"{num1}");
                result = num1;
            }
            return result;
        }
        static long CalculatorMemory(long num1, long num2, int i)
        {
            long result = 0; ;

            if (i == 1)
            {
                num1 += num2;
                Console.WriteLine();
                Console.Write(">>>: ");
                Console.WriteLine($"{num1}");
                result = num1;
            }
            if (i == 2)
            {
                num1 -= num2;
                Console.WriteLine();
                Console.Write(">>>: ");
                Console.WriteLine($"{num1}");
                result = num1;
            }
            if (i == 3)
            {
                num1 *= num2;
                Console.WriteLine();
                Console.Write(">>>: ");
                Console.WriteLine($"{num1}");
                result = num1;
            }
            if (i == 4)
            {
                int c = 0;
                long times = num1;
                Console.WriteLine();
                while (num2 > 1)
                {
                    num1 *= times;
                    c++;
                    num2--;
                    Console.Write(">>>: ");
                    Console.WriteLine($"Steps: {c}, Result = {num1}");
                    result = num1;
                }
            }
            if (i == 5)
            {
                num1 /= num2;
                Console.WriteLine();
                Console.Write(">>>: ");
                Console.WriteLine($"{num1}");
                result = num1;
            }
            return result;
        }
    }
}