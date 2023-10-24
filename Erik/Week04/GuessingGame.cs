using System;
using System.Threading.Tasks;

namespace Erik.Week04
{
    public class GuessingGame
    {
        public static int startCounterTrys = 10;
        private static bool firstGuess = true;          //speichert die erste zahl zum vergleichen ob höher
        private static int firstNumber;
        public static void startGuessingGame()
        {
            GuessingGameUserGuess(GuessingGameUserIntro());
        }

        public static int ReadNumber(string msg, int minValid, int maxValid)
        {
            int result = Int32.MinValue;
            while (result == Int32.MinValue)
            {
                Console.Write("{0}zwischen {1} und {2}: ", msg, minValid, maxValid);
                string line = Console.ReadLine();

                try
                {
                    result = Convert.ToInt32(line);
                    if (result < minValid || result > maxValid)
                    {
                        Console.WriteLine("{0} ist nicht im Bereich zwischen {1} und {2}", result, minValid, maxValid);
                        result = Int32.MinValue;
                    }
                }
                catch (FormatException fe)
                {
                    Console.WriteLine("\"{0}\" ist keine gültige Zahl.", line);
                }
            }

            return result;
        }


        public static int GuessingGameUserIntro()
        {
            Console.WriteLine("                         ╔═════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("                         ║ Welcome to the guessing Game!                                           ║\n                         ║First enter a number to declare the maximum range of the number to guess!║");
            Console.WriteLine("                         ╚═════════════════════════════════════════════════════════════════════════╝");
            int randomNumber = GenerateRandomNumber();
            Console.WriteLine("Random number generated! Start guessing the number!");
            Console.WriteLine(randomNumber);
            return randomNumber;
        }

        public static void GuessingGameUserGuess(int randomNumber)
        {
            int userGuessingNumbers;
            int counterTrys = startCounterTrys;

            //MathMiniGame(counterTrys, randomNumber);
            while (counterTrys != -1)
            {
                RandomJoker(counterTrys, randomNumber);

                if (counterTrys == 0)
                {
                    Console.WriteLine("THIS IS YOUR LAST TRY!!!\n");
                }

                userGuessingNumbers = ReadValidNumber();
                if (userGuessingNumbers == randomNumber)
                {
                    Console.WriteLine("VICTORY!!!");
                    break;
                }

                Console.WriteLine("WRONG GUESS! Try again :)\nTrys left: " + counterTrys);
                Console.WriteLine(SeperateTheLines());
                --counterTrys;

                if (userGuessingNumbers < randomNumber)
                {
                    Console.WriteLine( "The number is bigger!");
                }
                else if (userGuessingNumbers > randomNumber)
                {
                    Console.WriteLine("The number is smaller!");
                }
            }
            Console.WriteLine("Game Over!");
        }
        

        public static string SeperateTheLines()
        {
            string lines = "=======================================================================";
            return lines;
        }
        public static int ReadValidNumber()
        {

            while (true)
            {
                try
                {
                    Console.Write("Your Number: ");
                    int userInput = Convert.ToInt32(Console.ReadLine());

                    while (true)
                    {
                        if (userInput <= 10)                         //check if number is smaller or equal 10(random Number Parameter)
                        {
                            Console.WriteLine("Invalid Input! Number cant be less than ten!");
                            Console.Write("Your Number: ");
                            userInput = Convert.ToInt32(Console.ReadLine());
                        }
                        else if (firstGuess)
                        {
                            firstNumber = userInput;
                            firstGuess = false;
                        }

                        else if (userInput > firstNumber)             //vergleich ob numer höher ist als die erste nummer
                        {
                            Console.WriteLine("Invalid Input! Number cant be greater then the random number!");
                            Console.Write("Your Number: ");
                            userInput = Convert.ToInt32(Console.ReadLine());
                        }
                        else
                        {
                            break;
                        }
                    }
                    Console.WriteLine("\n");
                    return userInput;
                }
                catch (Exception ex) when (ex is System.FormatException ||
                                           ex is System.OverflowException)
                {
                    Console.WriteLine("Invalid Input! Try again!");
                }

            }
        }

        public static int GenerateRandomNumber()
        {
            int userInputRandomNumber = ReadValidNumber();
            Console.WriteLine(SeperateTheLines());
            Random random = new Random();
            int randomNumber = random.Next(11, userInputRandomNumber);
            return randomNumber;

        }

        public static void RandomJoker(int counterTrys, int randomNumber)
        {
            Random ran = new Random();
            int randomJoker = ran.Next(5);
            if (randomJoker == 2 && counterTrys < 8 && randomNumber.ToString().Length > 1)
            {
                Console.WriteLine("The number has " + randomNumber.ToString().Length + " digits!");
            }
            else if (randomJoker == 2 && counterTrys < 8 && randomNumber.ToString().Length < 1)
            {
                Console.WriteLine("The number has " + randomNumber.ToString().Length + " digit!");
            }
        }



        public static void MathMiniGame(int counterTrys, int randomNumber)
        {
            Console.Clear();
            Random ran = new Random();
            int randomJokerMiniGame = ran.Next(1, 2);


            while (randomJokerMiniGame == 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("MINI GAME JOKER!\n\nWin the Game to earn more Tries!");
                System.Threading.Thread.Sleep(3000);
                Console.Clear();
                Console.WriteLine("Solve the Math Exercise!\nBut better be quick!");
                Console.ResetColor();
                Console.WriteLine("Press F to start the Game!");
                var userKeyInput = Console.ReadKey();
                Console.Clear();

                while (userKeyInput.Key != ConsoleKey.F)
                {
                    Console.WriteLine("Invalid input!");
                    userKeyInput = Console.ReadKey();
                }

                for (int i = 10; i >= 0; i--)
                {
                    Console.Write("Timer: {0}", i);
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                }
            }
        }

        public static int RandomMathExercice()
        {
            Random ran = new Random();
            int randomNumber1 = ran.Next(1, 100);
            int randomNumber2 = ran.Next(1, 100);
            int randomChar = ran.Next(1, 4);
            int sum = 0;

            return sum;

        }
    }
}



