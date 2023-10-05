using Fabian.Week01;

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
            PrintCalculatorBonus();
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
                    Console.WriteLine("+, -, *, ^, /, =");

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
                catch
                {
                    Console.WriteLine("Something went wrong");
                }
            }
        }

        public static void PrintCalculatorBonus()
        {
            bool playAgain = true;
            double totalResult = 0;
            String option = "";
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

                        Console.WriteLine("What would you like to do?");
                        Console.WriteLine("+, -, *, ^, /, =");
                        option = Console.ReadLine();

                        Console.WriteLine("Enter a number: ");
                        num = Convert.ToInt32(Console.ReadLine());

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
                                double pow = Math.Pow(num, 2);
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
                            case "=":
                                Console.WriteLine("total result: " + totalResult);
                                break;
                        }
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

           
        }
    }
}
