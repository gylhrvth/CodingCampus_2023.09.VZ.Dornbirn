using Fabian.Week01;

namespace Fabian.Week02
{
    public class ConsoleInput
    {
        public static void Start()
        {
            //ReadString();
            //ReadInt();
            //GuessGame();
            //Menu();
            //Calculator();
            //CalculatorBonus();
            //BusinessCard();
            //TheGameBegins();
        }

        public static void ReadString()
        {
            Console.WriteLine("Enter a text: ");
            String text = Console.ReadLine();

            Console.WriteLine($"text = {text}");
        }

        public static void ReadInt()
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

        public static void GuessGame()
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

        public static void Menu()
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

        public static void Calculator()
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

        public static void CalculatorBonus()
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

                    while (option != "=")
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
                                CalculatorBonus();
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
                                Console.WriteLine($"result = {totalResult}");
                                option = "";
                                break;
                            case "-":
                                totalResult -= num;
                                Console.WriteLine($"result = {totalResult}");
                                option = "";
                                break;
                            case "*":
                                totalResult *= num;
                                Console.WriteLine($"result = {totalResult}");
                                option = "";
                                break;
                            case "^":
                                double pow = Math.Pow(num, exponent);
                                totalResult += pow;
                                Console.WriteLine($"result = {totalResult}");
                                option = "";
                                break;
                            case "/":
                                if (num == 0 || totalResult == 0)
                                {
                                    Console.WriteLine("cant divide by 0!");
                                    break;
                                }
                                totalResult /= num;
                                Console.WriteLine($"result = {totalResult}");
                                option = "";
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
        public static void BusinessCard()
        {
            String firstName = "";
            String lastName = "";
            String email = "";
            String phoneNumber = "";
            double width = 49;

            Console.WriteLine("Welcome to my business card maker! :)");

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
            double nameSpaces = ((firstName.Length + lastName.Length) / 2) - 0.5;
            while (phoneNumber == "")
            {
                Console.WriteLine("Enter your phone number: ");
                phoneNumber = Console.ReadLine();
            }
            double phoneSpaces = phoneNumber.Length / 2;
            while (email == "")
            {
                Console.WriteLine("Enter your email: ");
                email = Console.ReadLine();
            }
            double emailSpaces = email.Length / 2;




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
                    Methoden.PrintChars(" ", (width / 2 - 2 -  nameSpaces2));
                    Console.WriteLine("*");
                }
                else if (j == 7)
                {
                    Methoden.PrintChars(" ", 25);
                    Console.Write("*");
                    Methoden.PrintChars(" ", width / 2 - 2 - phoneSpaces);
                    Console.Write($"{phoneNumber}");
                    Methoden.PrintChars(" ", width/ 2 - 2 - phoneSpaces2);
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
            
            bool playAgain = true;
            while (playAgain)
            {
                int tries = 0;
                int value = new Random().Next(10000);
                int tmp = value;
                int guess = -1;
                int wrongPlaceNumbers = 0;
                Console.WriteLine(value);

                int firstNumber = value / 1000;
                tmp -= firstNumber * 1000;
                int secondNumber = tmp / 100;
                tmp -= secondNumber * 100;
                int thirdNumber = tmp / 10;
                tmp -= thirdNumber * 10;
                int fourthNumber = tmp;

                

                while(guess != value) {
                    try
                    {
                        Console.WriteLine("Enter a number between 0 and 9999: ");
                        guess = Convert.ToInt32(Console.ReadLine());
                        tries++;

                        int tmp2 = guess;
                        int firstNumber2 = tmp2 / 1000;
                        tmp2 -= firstNumber2 * 1000;
                        int secondNumber2 = tmp2 / 100;
                        tmp2 -= secondNumber2 * 100;
                        int thirdNumber2 = tmp2 / 10;
                        tmp2 -= thirdNumber2 * 10;
                        int fourthNumber2 = tmp2;


                        if (guess == value)
                        {
                            Console.WriteLine("You won!");
                            Console.WriteLine($"you needed {tries} tries");

                            Console.WriteLine("Do you want to play again? (Y/N)");
                            String restart = Console.ReadLine();
                            restart = restart.ToUpper();

                            if (restart == "N" || restart == "")
                            {
                                Console.WriteLine("Bye, have a nice day! :)");
                                playAgain = false;
                            }
                            break;
                        }
                        else if(guess < 0 || guess > 9999)
                        {
                            Console.WriteLine("only numbers between between 0 and 9999!!");
                        }

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

                        Console.WriteLine($"{wrongPlaceNumbers} numbers are on the wrong place");
                    }
                    catch
                    {
                        Console.WriteLine("Enter a valid number!");
                    }

                }             
            }
        }
    }
}
