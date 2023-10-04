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
            PrintCalculator();
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
                            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                            break;
                        case "-":
                            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                            break;
                        case "*":
                            Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                            break;
                        case "^":
                            Console.WriteLine($"{num1} ^ {num2} = {Math.Pow(num1, num2)}");
                            break;
                        case "/":
                            if(num2 == 0)
                            {
                                Console.WriteLine("cant divide by 0!");
                                break;
                            }
                            Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
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
    }
}
