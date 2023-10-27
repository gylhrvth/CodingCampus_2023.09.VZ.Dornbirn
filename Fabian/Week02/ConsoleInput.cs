using Fabian.Week01;
using System.Reflection.Metadata;
using System.Text.RegularExpressions;

namespace Fabian.Week02
{
    public class ConsoleInput
    {
        public static void Start()
        {
            //GuessGame();
            //Menu();
            //Calculator();
            //CalculatorBonus();
            //BusinessCard();
            TheGameBegins();
        }

        public static String ReadString(String msg, String pattern = @"^[a-zA-Z]+$")
        {
            while (true)
            {
                Console.Write(msg);
                String text = Console.ReadLine();

                if (text.CompareTo("") == 0)
                {
                    Console.WriteLine("Please enter something!");
                }
                else if (!Regex.IsMatch(text, pattern))
                {
                    Console.WriteLine("Not a valid input!");
                }
                else
                {
                    return text;
                }
            }
        }
        public static int ReadInt(String msg)
        {
            int num = Int32.MinValue;
            while (num == Int32.MinValue)
            {
                try
                {
                    Console.Write(msg);
                    num = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("only numbers!");
                }
            }
            return num;
        }
        public static int ReadInt(String msg, int min, int max)
        {
            int num = Int32.MinValue;
            while (num == Int32.MinValue)
            {
                try
                {
                    Console.Write(msg);
                    num = Convert.ToInt32(Console.ReadLine());

                    if (num < min || num > max)
                    {
                        Console.WriteLine($"{num} is not between {min} and {max}!. Try again");
                        num = Int32.MinValue;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("only numbers!");
                }
                catch(OverflowException)
                {
                    Console.WriteLine("number is too high!");
                }
            }
            return num;
        }
        public static double ReadDouble(String msg)
        {
            double num = Double.MinValue;
            while (num == Double.MinValue)
            {
                try
                {
                    Console.Write(msg);
                    num = Convert.ToDouble(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("only numbers!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("number is too high!");
                }
            }
            return num;
        }
        public static bool AskToPlayAgain()
        {
            String restart = ReadString("Do you want to play again? (Y/N): ", "^[yYnN]$");
            restart = restart.ToUpper();

            if (restart == "N")
            {
                Console.WriteLine("Bye, have a nice day! :)");
                return false;
            }
            return true;
        }
        public static void GuessGame()
        {
            int num = new Random().Next(100) + 1;
            int tries = 0;
            int guess = -1;

            Console.WriteLine("Welcome to my cool guess game! :)");

            while (guess != num)
            {
                guess = ReadInt("Enter a number between 1-100: ", 1, 100);
                tries++;

                if (guess == num)
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

            if (AskToPlayAgain())
            {
                GuessGame();
            }
            else
            {
                return;
            }
        }
        public static void Menu()
        {

            while (true)
            {

                Console.WriteLine("Welcome to the menu! :)");
                Console.WriteLine("1) christmas tree");
                Console.WriteLine("2) empty square");
                Console.WriteLine("3) rhombus");

                int option = ReadInt("\nWhat would you like to draw? ", 1, 3);

                int size = ReadInt("How big should it be? ");

                switch (option)
                {
                    case 1:
                        Methoden.PrintChristmasTree(size);
                        break;
                    case 2:
                        Methoden.PrintEmptySquare("*", size);
                        break;
                    case 3:
                        Methoden.PrintRhombus("*", size);
                        break;
                }

                if (!AskToPlayAgain())
                {
                    return;
                }

            }

        }
        public static void Calculator()
        {

            Console.WriteLine("Welcome to my calculator! :)");

            while (true)
            {
                try
                {
                    double num1 = ReadDouble("Enter number 1 : ");

                    Console.WriteLine("What would you like to do?");
                    String option = ReadString("*, + , -, /, ^ : ", @"^[*\+\-\/\^]$");

                    double num2 = ReadDouble("Enter number 2: ");

                    switch (option)
                    {
                        case "+":
                            double sum = num1 + num2;
                            Console.WriteLine($"{num1} + {num2} = {sum}");
                            break;
                        case "-":
                            double difference = num1 - num2;
                            Console.WriteLine($"{num1} - {num2} = {difference}");
                            break;
                        case "*":
                            double product = num1 * num2;
                            Console.WriteLine($"{num1} * {num2} = {product}");
                            break;
                        case "^":
                            double pow = Math.Pow(num1, num2);
                            Console.WriteLine($"{num1} ^ {num2} = {pow}");
                            break;
                        case "/":
                            double quotient = num1 / num2;
                            if (num2 == 0)
                            {
                                Console.WriteLine("cant divide by 0!");
                                break;
                            }
                            Console.WriteLine($"{num1} / {num2} = {quotient}");
                            break;
                    }

                    if (!AskToPlayAgain())
                    {
                        return;
                    }




                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter a valid number!");
                }
            }
        }
        public static void CalculatorBonus()
        {
            double totalResult = 0;
            double exponent = 0;

            Console.WriteLine("Welcome to my calculator! :)");

            double num = ReadDouble("Enter a number: ");
            totalResult += num;

            while (true)
            {

                Console.WriteLine("What would you like to do?");
                String option = ReadString("*, + , -, /, ^, = : ", @"^[*\+\-\/\^\=]$"); ;


                if (option == "=")
                {
                    Console.WriteLine("total result: " + totalResult);

                    if (AskToPlayAgain())
                    {
                        CalculatorBonus();
                    }
                    return;
                }
                else if (option == "^")
                {
                    exponent = ReadDouble("Enter an exponent: ");
                }
                else
                {
                    num = ReadDouble("Enter a number: ");
                }

                switch (option)
                {
                    case "+":
                        totalResult += num;
                        Console.WriteLine($"result = {totalResult}");
                        break;
                    case "-":
                        totalResult -= num;
                        Console.WriteLine($"result = {totalResult}");
                        break;
                    case "*":
                        totalResult *= num;
                        Console.WriteLine($"result = {totalResult}");
                        break;
                    case "^":
                        double pow = Math.Pow(num, exponent);
                        totalResult += pow - num;
                        Console.WriteLine($"result = {totalResult}");
                        break;
                    case "/":
                        if (num == 0 || totalResult == 0)
                        {
                            Console.WriteLine("cant divide by 0!");
                            break;
                        }
                        totalResult /= num;
                        Console.WriteLine($"result = {totalResult}");
                        break;
                }
            }

        }
        public static void BusinessCard() 
        {
            double width = 49;

            Console.WriteLine("Welcome to my business card maker! :)");

            String firstName = ReadString("Enter yout first name: ");
            String lastName = ReadString("Enter your last name: ");
            String phoneNumber = ReadString("Enter your phone number (+xx xxx xxxxxxx): ", "^[0-9\\+]+$");
            String email = ReadString("Enter your email: ", "^[a-zA-Z0-9\\@\\.]+$");



            double nameSpaces = ((firstName.Length + lastName.Length) / 2) - 0.5;
            double emailSpaces = email.Length / 2;
            double phoneSpaces = phoneNumber.Length / 2;
            double nameSpaces2 = nameSpaces;

            if ((firstName.Length + lastName.Length) % 2 == 1)
            {
                nameSpaces2 += 1;
            }

            double phoneSpaces2 = phoneSpaces;

            if (phoneNumber.Length % 2 == 0)
            {
                phoneSpaces2 -= 1;
            }

            double emailSpaces2 = emailSpaces;

            if (email.Length % 2 == 0)
            {
                emailSpaces2 -= 1;
            }

            //print businesscard
            Methoden.PrintChars(" ", 25);
            for (int i = 0; i < width / 2; i++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
            for (int j = 0; j < 14; j++)
            {
                if (j == 5)
                {
                    Methoden.PrintChars(" ", 25);
                    Console.Write("*");
                    Methoden.PrintChars(" ", (width / 2 - 2 - nameSpaces));
                    Console.Write($"{firstName} {lastName}");
                    Methoden.PrintChars(" ", (width / 2 - 2 - nameSpaces2));
                    Console.WriteLine("*");
                }
                else if (j == 7)
                {
                    Methoden.PrintChars(" ", 25);
                    Console.Write("*");
                    Methoden.PrintChars(" ", width / 2 - 2 - phoneSpaces);
                    Console.Write($"{phoneNumber}");
                    Methoden.PrintChars(" ", width / 2 - 2 - phoneSpaces2);
                    Console.WriteLine("*");
                }
                else if (j == 8)
                {
                    Methoden.PrintChars(" ", 25);
                    Console.Write("*");
                    Methoden.PrintChars(" ", (width / 2 - 2) - emailSpaces);
                    Console.Write($"{email}");
                    Methoden.PrintChars(" ", (width / 2 - 2) - emailSpaces2);
                    Console.WriteLine("*");
                }
                else
                {
                    Methoden.PrintChars(" ", 25);
                    Console.Write("*");
                    Methoden.PrintChars(" ", width - 2);
                    Console.WriteLine("*");
                }
            }
            Methoden.PrintChars(" ", 25);
            for (int i = 0; i < width / 2; i++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
        public static void TheGameBegins()
        {
            while (true)
            {
                int tries = 0;
                int value = new Random().Next(10000);
                int tmp = value;
                int guess = -1;

                int firstNumber = value / 1000;
                tmp -= firstNumber * 1000;
                int secondNumber = tmp / 100;
                tmp -= secondNumber * 100;
                int thirdNumber = tmp / 10;
                tmp -= thirdNumber * 10;
                int fourthNumber = tmp;

                while (guess != value)
                {
                    int wrongPlaceNumbers = 0;
                    guess = ReadInt("Enter a number between 0 and 9999: ", 0, 9999);
                    tries++;

                    int tmp2 = guess;
                    int firstNumber2 = tmp2 / 1000;
                    tmp2 -= firstNumber2 * 1000;
                    int secondNumber2 = tmp2 / 100;
                    tmp2 -= secondNumber2 * 100;
                    int thirdNumber2 = tmp2 / 10;
                    tmp2 -= thirdNumber2 * 10;
                    int fourthNumber2 = tmp2;
                    

                    if (firstNumber == firstNumber2)
                    {
                        Console.WriteLine("the first digit is right!");
                    }
                    if (firstNumber != firstNumber2 && (firstNumber == secondNumber2 || firstNumber == thirdNumber2 || firstNumber == fourthNumber2))
                    {
                        wrongPlaceNumbers++;
                    }
                    if (secondNumber == secondNumber2)
                    {
                        Console.WriteLine("the second digit is right!");
                    }
                    if (secondNumber != secondNumber2 && (secondNumber == firstNumber2 || secondNumber == thirdNumber2 || secondNumber == fourthNumber2))
                    {
                        wrongPlaceNumbers++;
                    }
                    if (thirdNumber == thirdNumber2)
                    {
                        Console.WriteLine("the third digit is right!");
                    }
                    if (thirdNumber != thirdNumber2 && (thirdNumber == firstNumber2 || thirdNumber == secondNumber2 || thirdNumber == fourthNumber2))
                    {
                        wrongPlaceNumbers++;
                    }
                    if (fourthNumber == fourthNumber2)
                    {
                        Console.WriteLine("the fourth digit is right!");
                    }
                    if (fourthNumber != fourthNumber2 && (fourthNumber == firstNumber2 || fourthNumber == secondNumber2 || fourthNumber == thirdNumber2))
                    {
                        wrongPlaceNumbers++;
                    }

                    if (wrongPlaceNumbers > 0)
                    {
                        Console.WriteLine($"{wrongPlaceNumbers} numbers are on the wrong place");
                    }

                    if (guess == value)
                    {
                        Console.WriteLine("You won!");
                        Console.WriteLine($"you needed {tries} tries");

                        if (!AskToPlayAgain())
                        {
                            return;
                        }
                    }
                }
            }
        }
    }
}
