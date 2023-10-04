using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace Michael.Week01
{
    public class ConsoleInputs
    {

        public static string StringInput(String text = "")
        {
            if (text != "")
            {
                Console.WriteLine(text);
            }

            Console.WriteLine("enter a string");
            String userInput = Console.ReadLine();
            Console.WriteLine($"Thank you! \nYour input was: {userInput}");
            return userInput;
        }


        public static int IntInput(String text = "")
        {
            if (text != "")
            {
                Console.WriteLine(text);
            }

            Console.WriteLine("enter an integer");

            while (true)
            {
                int userInput = 0;

                try
                {
                    userInput = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("invalid input, try again");
                    continue;
                }

                Console.WriteLine($"Thank you! \nYour input was: {userInput}\n");
                return userInput;

            }
        }


        public static char CharInput(String text = "")
        {
            if (text != "")
            {
                Console.WriteLine(text);
            }

            Console.WriteLine("enter a character");

            while (true)
            {
                char userInput = '0';

                try
                {
                    userInput = Convert.ToChar(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("invalid input, try again");
                    continue;
                }

                Console.WriteLine($"Thank you! \nYour input was: {userInput}\n");
                return userInput;

            }
        }


        public static float FloatInput(String text = "")
        {
            if (text != "")
            {
                Console.WriteLine(text);
            }

            Console.WriteLine("enter a number");

            while (true)
            {
                float userInput = 0;

                try
                {
                    userInput = (float)Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("invalid input, try again");
                    continue;
                }

                Console.WriteLine($"Thank you! \nYour input was: {userInput}\n");
                return userInput;

            }
        }


        public static void GuessingGame()
        {
            Random rnd = new Random();
            Console.WriteLine("pick a difficulty for this game, the higher the number the more difficult");
            int maxNum = IntInput();

            int number = rnd.Next(maxNum);
            int guess = 0;

            Console.WriteLine($"a number between 0 and {maxNum} has been chosen. guess it.");

            while (true)
            {

                guess = IntInput();

                if (guess > number)
                {
                    Console.WriteLine($"sorry, your number {guess} is too big!");
                }
                else if (guess < number)
                {
                    Console.WriteLine($"sorry, your number {guess} is too small!");
                }
                else
                {
                    Console.WriteLine($"congrats! you won, the number was {guess}");
                    return;
                }

            }
        }


        public static void DrawShape()
        {

            int length = 0;
            int width = 0;
            char character = 'X';
            bool backslash = false;

            Console.WriteLine("Willkommen bei meinen Aufgabe! \nWas möchten sie zeichnen");

            int choice = IntInput(" 1) Line of characters \n 2) Filled Rectangle\n 3) Empty Square \n 4) Triangle \n 5) Slash \n 6) just an X \n 7) Filled Circle \n 8) Christmas-Tree");
            Console.WriteLine("and what symbol should we use?");
            character = Convert.ToChar(Console.ReadLine());

            Console.WriteLine($"your choice: {choice}");

            if (choice > 8 || choice < 1)
            {
                Console.WriteLine("very funny. abort, panic");
            }

            if (choice == 7)
            {
                length = IntInput("What is the radius of your circle?");
            }
            else
            {
                length = IntInput("How long should your shape be?");
            }


            if (choice == 2)
            {
                width = IntInput("And how wide is your rectangle?");
            }

            if (choice == 5)
            {
                int backslashChoice = IntInput("Should it be a BACKslash? 1 for yes, 0 for no");
                if (backslashChoice == 1)
                {
                    backslash = true;
                }

                else if (backslashChoice == 0)
                {
                    backslash = false;
                }

                else
                {
                    Console.WriteLine("that's not an option, sorry");
                }
            }


            switch (choice)
            {
                case 1:
                    Methods.printChars(character, length);
                    break;
                case 2:
                    Methods.printRect(character, length, width);
                    break;
                case 3:
                    Methods.printEmptySquare(character, length);
                    break;
                case 4:
                    Methods.printTriangle(character, length);
                    break;
                case 5:
                    Methods.printSlash(character, length, backslash);
                    break;
                case 6:
                    Methods.printX(character, length);
                    break;
                case 7:
                    Methods.printCirclePythagoras(character, length);
                    break;
                case 8:
                    Methods.printChristmasTree(character, length - 3);
                    break;
            }

        }


        public static void Calculator()
        {
            bool repeat = true;

            bool memoryBool = false;

            float result = 0;

            float num1 = 0;

            while (repeat)
            {

                if (!memoryBool)
                {
                    num1 = FloatInput();
                }

                char operation = CharInput();

                float num2 = FloatInput();

                switch (operation)
                {
                    case '+':
                        result = num1 + num2;
                        break;
                    case '-':
                        result = num1 - num2;
                        break;
                    case '*':
                        result = num1 * num2;
                        break;
                    case '/':
                        result = num1 / num2;
                        break;
                    default:
                        Console.WriteLine("nope, not an option");
                        break;
                }

                Console.WriteLine($"{num1} {operation} {num2} = {result}");

                while (true)
                {
                    char again = CharInput("Do you want to go again? y/n");
                    if (again == 'n')
                    {
                        repeat = false;
                        Console.WriteLine("bye bye");
                        break;
                    }
                    else if (again == 'y')
                    {
                        Console.WriteLine("let's go again then!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("i did not understand that input, i'm sorry. i'm also case sensitive fyi!");
                    }
                }

                if (!repeat)
                    break;

                while (true)
                {
                    char again = CharInput("Do you want to continue with this result? y/n");
                    if (again == 'n')
                    {
                        Console.WriteLine("let's pick a new one then");
                        break;
                    }
                    else if (again == 'y')
                    {
                        memoryBool = true;
                        num1 = result;
                        Console.WriteLine($"we will start with:\n{result}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("i did not understand that input, i'm sorry. i'm also case sensitive fyi!");
                    }
                }

            }

        }


        public static void BusinessCard()
        {
            int cardWidth = 34;


            string name = StringInput("\nhi, what's your name");
            string number = StringInput("\nand what's your telephone number?");
            string mail = StringInput("\nand last but not least, your mail adress?");

            for (int y = 0; y < 11; y++)
            {
                if (y == 0 || y==10)
                {
                    Methods.printChars('*', cardWidth, true);
                }
                else if (y == 4)
                {
                    Methods.printChars('*', 1);
                    Methods.printChars(' ', (cardWidth - 2 - name.Length) / 2);
                    Console.Write(name);
                    Methods.printChars(' ', (cardWidth - 2 - name.Length) / 2);

                    //fixes rounding down 
                    if (name.Length % 2 == 1)
                    {
                        Methods.printChars(' ', 1);
                    }

                    Methods.printChars('*', 1, true);

                }
                else if (y == 5)
                {
                    Methods.printChars('*', 1);
                    Methods.printChars(' ', (cardWidth - 2 - number.Length) / 2);
                    Console.Write(number);
                    Methods.printChars(' ', (cardWidth - 2 - number.Length) / 2);

                    //fixes rounding down 
                    if (number.Length % 2 == 1)
                    {
                        Methods.printChars(' ', 1);
                    }

                    Methods.printChars('*', 1, true);

                }
                else if (y == 6)
                {
                    Methods.printChars('*', 1);
                    Methods.printChars(' ', (cardWidth - 2 - mail.Length) / 2);
                    Console.Write(mail);
                    Methods.printChars(' ', (cardWidth - 2 - mail.Length) / 2);

                    //fixes rounding down 
                    if (mail.Length % 2 == 1)
                    {
                        Methods.printChars(' ', 1);
                    }

                    Methods.printChars('*', 1, true);

                }
                else
                {
                    Methods.printChars('*', 1);
                    Methods.printChars(' ', cardWidth - 2);
                    Methods.printChars('*', 1, true);
                }
            }

        }


        public static void TheGame()
        {
            Random rand = new Random();
            int solution = (int) rand.NextInt64(999,10000);
            bool won = false;
            int testSolution = 0;
            int testGuess = 0;
            int correctDigit = 0;
            int correctPlace = 0;

            Console.WriteLine("a number between 999 and 10000 has been chosen. guess it.");

            /*counts the 20 rounds*/
            for (int round = 0; round < 20; round++)
            {
                int guess = IntInput("your guess?");

                Console.WriteLine(solution);


                /*picks the i-th digit of the guess*/
                for (int i = 0; i < 4; i++)
                {
                    testGuess = (int) (guess / Math.Pow(10,i) % 10);

                    Console.WriteLine($"digit of guess: {testGuess}");


                    /*compares the i-th digit of the guess with the j-th digit of the solution*/
                    for (int j = 0; j < 4; j++)
                    {
                       testSolution = (int) (solution / Math.Pow(10, j) % 10);

                        Console.WriteLine($"digit of solution: {testSolution}");

                        if (testGuess == testSolution)
                        {
                            correctDigit++;

                            if (i == j)
                            {
                                correctPlace++;
                            }

                            break;
                        }
                    }
                }

                Console.WriteLine($"{correctDigit} {correctPlace}");

            }


            if (won)
            {
                Console.WriteLine("congrats, you won!");
            }
            else
            {
                Console.WriteLine("unlucky, you lost...");
            }


        }



        public static void TheGameAlt()
        {

        }





        public static void ConsoleInput()
        {

            BusinessCard();

        }



    }
}