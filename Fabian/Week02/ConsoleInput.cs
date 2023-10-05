﻿using Fabian.Week01;

namespace Fabian.Week02
{
    public class ConsoleInput
    {
        public static void Start()
        {
            //PrintReadString();
            //PrintReadInt();
            //PrintGuessGame();
            //PrintMenu();
            //PrintCalculator();
            //PrintCalculatorBonus();
            PrintBusinessCard();
            //TheGameBegins();
        }

        public static void PrintReadString()
        {
            Console.WriteLine("Enter a text: ");
            String text = Console.ReadLine();

            Console.WriteLine($"text = {text}");
        }

        public static void PrintReadInt()
        {
            int num = 0;
            while (num == 0)
            {
                try
                {
                    Console.WriteLine("Enter a number: ");
                    num = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"number = {num}");
                }
                catch
                {
                    Console.WriteLine("only numbers!");
                }
            }
        }

        public static void PrintGuessGame()
        {
            int num = new Random().Next(100) + 1;
            int guess = 0;
            int tries = 0;

            Console.WriteLine("Welcome to my cool guess game! :)");

            while (num != guess)
            {
                Console.WriteLine("Enter a number between 1 and 100");
                guess = Convert.ToInt32(Console.ReadLine());
                tries++;

                if (guess > 100 || guess < 1)
                {
                    Console.WriteLine("You can only guess between 1 and 100!");
                }
                else if (guess == num)
                {
                    Console.WriteLine("Nice!! You won! :)");
                }
                else if (guess > num)
                {
                    Console.WriteLine($"{guess} is too high!");
                }
                else if (guess < num)
                {
                    Console.WriteLine($"{guess} is too low!");
                }

            }
        }

        public static void PrintMenu()
        {
            bool playAgain = true;

            while (playAgain)
            {
                try
                {
                    Console.WriteLine("Welcome to the menu! :)");
                    Console.WriteLine("What would you like to draw?");
                    Console.WriteLine("1) christmas tree");
                    Console.WriteLine("2) empty square");
                    Console.WriteLine("3) rhombus");
                    String option = Console.ReadLine();

                    Console.WriteLine($"how big should the {option} be?");
                    int size = Convert.ToInt32(Console.ReadLine());

                    switch (option)
                    {
                        case "1":
                            Methoden.PrintChristmasTree(size);
                            break;
                        case "2":
                            Methoden.PrintEmptySquare("*", size);
                            break;
                        case "3":
                            Methoden.PrintRhombus("*", size);
                            break;
                    }

                    Console.WriteLine("Do you want to play again? (Y/N)");
                    String restart = Console.ReadLine();
                    restart = restart.ToUpper();

                    if (restart == "N")
                    {
                        playAgain = false;
                    }


                }
                catch
                {
                    Console.WriteLine("Something went wrong");
                }
            }
        }

        public static void PrintCalculator()
        {
            bool playAgain = true;

            Console.WriteLine("Welcome to my calculator! :)");

            while (playAgain)
            {
                try
                {

                    Console.WriteLine("Enter number 1: ");
                    float num1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("What would you like to do?");
                    Console.WriteLine("+, -, *, ^, /");

                    String option = Console.ReadLine();

                    Console.WriteLine("Enter number 2: ");
                    float num2 = Convert.ToInt32(Console.ReadLine());

                    switch (option)
                    {
                        case "+":
                            float sum = num1 + num2;
                            Console.WriteLine($"{num1} + {num2} = {sum}");
                            break;
                        case "-":
                            float difference = num1 - num2;
                            Console.WriteLine($"{num1} - {num2} = {difference}");
                            break;
                        case "*":
                            float product = num1 + num2;
                            Console.WriteLine($"{num1} * {num2} = {product}");
                            break;
                        case "^":
                            float pow = (float)(Math.Pow(num1, num2));
                            Console.WriteLine($"{num1} ^ {num2} = {pow}");
                            break;
                        case "/":
                            float quotient = num1 / num2;
                            if (num2 == 0)
                            {
                                Console.WriteLine("cant divide by 0!");
                                break;
                            }
                            Console.WriteLine($"{num1} / {num2} = {quotient}");
                            break;
                    }

                    Console.WriteLine("Do you want to play again? (Y/N)");
                    String restart = Console.ReadLine();
                    restart = restart.ToUpper();

                    if (restart == "N")
                    {
                        Console.WriteLine("Bye, have a nice day! :)");
                        playAgain = false;
                    }


                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public static void PrintCalculatorBonus()
        {
            bool playAgain = true;
            double totalResult = 0;
            String option = "";
            double exponent = 0;

            Console.WriteLine("Welcome to my calculator! :)");

            while (playAgain)
            {
                try
                {
                    Console.WriteLine("Enter a number: ");
                    double num = Convert.ToDouble(Console.ReadLine());
                    totalResult += num;

                    while (true)
                    {
                        while (option == "")
                        {
                            Console.WriteLine("What would you like to do?");
                            Console.WriteLine("+, -, *, ^, /, =");
                            option = Console.ReadLine();
                        }

                        if (option == "=")
                        {
                            Console.WriteLine("total result: " + totalResult);

                            Console.WriteLine("Do you want to play again? (Y/N)");
                            String restart = Console.ReadLine();
                            restart = restart.ToUpper();

                            if (restart == "N" || restart == "")
                            {
                                Console.WriteLine("Bye, have a nice day! :)");
                                playAgain = false;
                            }
                            else
                            {
                                PrintCalculatorBonus();
                            }
                        }
                        else if (option == "^")
                        {
                            Console.WriteLine("Enter the exponent: ");
                            exponent = Convert.ToDouble(Console.ReadLine());
                        }
                        else
                        {
                            Console.WriteLine("Enter a number: ");
                            num = Convert.ToDouble(Console.ReadLine());
                        }

                        switch (option)
                        {
                            case "+":
                                totalResult += num;
                                Console.WriteLine(totalResult);
                                break;
                            case "-":
                                totalResult -= num;
                                Console.WriteLine(totalResult);
                                break;
                            case "*":
                                totalResult *= num;
                                Console.WriteLine(totalResult);
                                break;
                            case "^":
                                double pow = Math.Pow(num, exponent);
                                totalResult += pow;
                                Console.WriteLine(totalResult);
                                break;
                            case "/":
                                if (num == 0 || totalResult == 0)
                                {
                                    Console.WriteLine("cant divide by 0!");
                                    break;
                                }
                                totalResult /= num;
                                Console.WriteLine(totalResult);
                                break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public static void PrintBusinessCard()
        {
            String firstName = "";
            String lastName = "";
            String email = "";
            String phoneNumber = "";
            int test = 5;


            while (firstName == "")
            {
                Console.WriteLine("Enter your first name: ");
                firstName = Console.ReadLine();
            }
            while (lastName == "")
            {
                Console.WriteLine("Enter your last name: ");
                lastName = Console.ReadLine();
            }
            while (phoneNumber == "")
            {
                Console.WriteLine("Enter your phone number: ");
                phoneNumber = Console.ReadLine();
            }
            while (email == "")
            {
                Console.WriteLine("Enter your email: ");
                email = Console.ReadLine();
            }

            for (int i = 0; i < 44; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            for (int j = 0; j < 15; j++)
            {
                Console.WriteLine("*");
                if (j == 4)
                {
                    Console.WriteLine($"* {firstName,20} {lastName} {"*",19}");
                }
                else if (j == 6)
                {
                    Console.WriteLine($"* {phoneNumber,27} {"*",14}");
                }
                else if (j == 7)
                {
                    Console.WriteLine($"* {email,30} {"*",11}");
                }
                else
                {
                    Console.Write($"{"*",-43}");
                }
            }
            Console.WriteLine();
            for (int i = 0; i < 44; i++)
            {
                Console.Write("*");
            }
        }

        public static void TheGameBegins()
        {
            
            bool playAgain = true;
            while (playAgain)
            {
                int tries = 0; ;
                int value = new Random().Next(10000);
                int tmp = value;

                int firstNumber = value / 1000;
                tmp -= firstNumber * 1000;
                int secondNumber = tmp / 100;
                tmp -= secondNumber * 100;
                int thirdNumber = tmp / 10;
                tmp -= thirdNumber * 10;
                int fourthNumber = tmp;


                Console.WriteLine("Enter a number between 0 and 9999: ");
                int guess = Convert.ToInt32(Console.ReadLine());

            }
        }
    }
}
