using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Erik.Week03
{
    public class GuessingGame
    {
        public static void startGuessingGame()
        {
            GuessingGameUserGuess(GuessingGameUserIntro());
        }

        public static void GuessingGameMain(int randomNumber)
        {

        }

        public static int GuessingGameUserIntro()
        {
            Console.WriteLine("Welcome to the guessing Game! \n\nEnter a number to declare the maximum range of the number to guess!");
            Console.Write("Your Number: ");
            try
            {
                int userInput = Convert.ToInt32(Console.Read());
            }
            catch (System.ArgumentException sae) 
            {
                Console.WriteLine("Number not acceptable. Try again!");
            }
            SeperateTheLines();
            Random random = new Random();
            int randomNumber = random.Next(100);

            Console.WriteLine("Random number generated! Start guessing the number!");
            //Console.WriteLine(randomNumber);
            return randomNumber;
        }

        public static void GuessingGameUserGuess(int randomNumber)
        {
            Console.Write("Your Number: ");
            int userGuessingNumbers = Convert.ToInt32(Console.ReadLine()); //error not stop to reading linegit

            while (userGuessingNumbers != randomNumber)
            {
                userGuessingNumbers = Convert.ToInt32(Console.ReadLine());
                Console.Write("Number wrong!!!\n\nNext Try: ");
            }
        }

        public static string SeperateTheLines()
        {
            string lines = "=======================================================================";
            return lines;
            
        }
    }
}
