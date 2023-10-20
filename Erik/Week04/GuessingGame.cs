using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Erik.Week04
{
    public class GuessingGame
    {
        public static void startGuessingGame()
        {
            GuessingGameUserGuess(GuessingGameUserIntro());
        }

        public static int GuessingGameUserIntro()
        {
            Console.WriteLine("Welcome to the guessing Game! \n\nEnter a number to declare the maximum range of the number to guess!");
            int randomNumber = GenerateRandomNumber();
            Console.WriteLine("Random number generated! Start guessing the number!");
            Console.WriteLine(randomNumber);
            return randomNumber;
        }

        public static void GuessingGameUserGuess(int randomNumber)
        {
            int userGuessingNumbers;
            int counterTrys = CounterTrys();

            MathMiniGame(counterTrys, randomNumber);
            while (counterTrys != -1)
            {
             
                RandomJoker(randomNumber, counterTrys);

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
                    Console.WriteLine("The number is bigger!");
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
                    {
                        Console.WriteLine("\n");
                        return userInput;
                    }
                }
                catch (Exception ex) when (ex is System.FormatException)
                {
                    Console.WriteLine("Invalid Input! Try again!");
                }

            }
        }

        public static int GenerateRandomNumber()
        {
            while (true)
            {
                try
                {
                    int userInputRandomNumber = ReadValidNumber();
                    Console.WriteLine(SeperateTheLines());
                    Random random = new Random();
                    int randomNumber = random.Next(11, userInputRandomNumber);
                    return randomNumber;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Number must be greater than 10!\nEnter a new Number!");
                }
            }
        }

        public static void RandomJoker(int counterTrys, int randomNumber)
        {
            Random ran = new Random();
            int randomJoker = ran.Next(7);
            if (randomJoker == 2 && counterTrys < 4 && randomNumber.ToString().Length > 1)
            {
                Console.WriteLine("The number has " + randomNumber.ToString().Length + " digits!");
            }
            else if (randomJoker == 2 && counterTrys < 4 && randomNumber.ToString().Length <= 1)
            {
                Console.WriteLine("The number has " + randomNumber.ToString().Length + " digit!");
            }
        }

        public static int CounterTrys()
        {
            return 10;
        }

        public static void MathMiniGame(int counterTrys, int randomNumber)
        {
            Console.Clear();
            Random ran = new Random();
            int randomJokerMiniGame = ran.Next(1,2);
            int timeCounter = 10;
            

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
    }
}

//todo:
//mini game mathe aufgabe lösen um eine Zahl zu erhalten!

