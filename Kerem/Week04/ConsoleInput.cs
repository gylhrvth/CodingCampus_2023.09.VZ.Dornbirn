using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using static Kerem.Week01.Methoden;

namespace Kerem.Week04
{
    internal class ConsoleInput
    {
        public static void Start()
        {
            //string userinput = ReadString("Enter a String");
            //Console.WriteLine("Userinput was: " + userinput);

            //int userinputnumber = ReadNumber("Enter a number", "Please only numbers! Try again!");
            //Console.WriteLine("Userinput was: " + userinputnumber);

            //Console.WriteLine("Welcome to my super duper Guessgame");
            //Guessgame();

            Menu("Welcome to my Exercises!", "What do you wanna draw?", "PrintEmptySquare", "PrintSquare", "PrintTriangleTopRight", "How big should it be?", "Which sign you wanna use?");


        }
 
        public static void Guessgame()
        {
            int num = new Random().Next(101);
            int guess = 0;

            while (num != guess)
            {
                try
                {
                    Console.WriteLine("Enter a number between 1 and 100!!");
                    guess = Convert.ToInt32(Console.ReadLine());

                    if (guess > 100 || guess < 1)
                    {
                        Console.WriteLine("Functionable only between 1 and 100!!");
                    }
                    else if (guess == num)
                    {
                        Console.WriteLine("Good job jackass!");
                    }
                    else if (guess > num)
                    {
                        Console.WriteLine("Your number is too high!!");
                    }
                    else if (guess < num)
                    {
                        Console.WriteLine("Your number is too low!!");
                    }
                }
                catch
                {
                    Console.WriteLine("Only Numbers!");
                }
            }
        }
        public static int ReadChoices(string msg)
        {
            while (true)
            {
                try
                {

                    Console.WriteLine(msg);
                    string input = Console.ReadLine();
                    int output = Convert.ToInt32(input);
                    return output;




                }
                catch
                {
                    Console.WriteLine("Enter a number");
                }
            }
        }
        public static String ReadSymbol(string msg)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine(msg);
                    string input = Console.ReadLine();
                    return input;
                }
                catch
                {
                    Console.WriteLine("Enter a number!");
                }
            }
        }
        public static void Menu(string greet, string askingdraw, string draw1, string draw2, string draw3, string asksize, string asksign)
        {

            bool end = false;
            while (!end)
            {

                Console.WriteLine(greet);
                Console.WriteLine("1 for : " + draw1);
                Console.WriteLine("2 for : " + draw2);
                Console.WriteLine("3 for : " + draw3);
                Console.WriteLine();

                int number = ReadChoices(askingdraw);
                int size = ReadChoices(asksize);
                string sign = ReadSymbol(asksign);

                    if (number == 1)
                    {
                        printEmptySquare(sign, size);
                    }
                    else if (number == 2)
                    {
                        printSquare(sign, size);
                    }
                    else if (number == 3)
                    {
                        printTriangleTopRight(sign, size);
                    }
                    else
                    {
                        Console.WriteLine("Unvalid Number!");
                    }


                    Console.WriteLine();

                    Console.WriteLine("You wanna draw something else? (y/n)");
                    string again = Console.ReadLine();

                    if (again != "y")
                    {
                        end = true;
                    }

                

            }

        }

    }
}
