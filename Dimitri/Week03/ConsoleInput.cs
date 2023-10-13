using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Dimitri.Week03
{
    internal class ConsoleInput
    {
        public static void Main()
        {
            //Console.WriteLine("Write your input here:");
            //StringOutput(StringRead());

            //string prompt = "Write your integer here:";
            //string onError = "Input not allowed. Please enter an Integer:";
            //IntOutput(IntRead(prompt, onError));

            GuessingGame();
        }

        public static string StringRead()
        {
            string input = Console.ReadLine();
            return input;

        }

        public static void StringOutput(string input)
        {
            Console.WriteLine("This is your input:");
            Console.WriteLine(input);

        }

        public static int IntRead(string prompt, string onError)
        {
            Console.WriteLine(prompt);
            while (true)
            {
                try
                {
                    String input = Console.ReadLine();
                    int ourNumber = Convert.ToInt32(input);
                    return ourNumber;
                }
                catch (Exception e)
                {
                    Console.WriteLine(onError);
                }
            }
        }

        public static void IntOutput(int input)
        {
            Console.WriteLine("This is your integer: " + input);
        }

        public static void GuessingGame()
        {
            int randomNum = new Random().Next(0, 101);

            Console.WriteLine("Willkommen beim super coolen Zahlen Ratespiel!");
            Console.WriteLine("Errate die Zahl zwischen 0 und 100!");

            int num = 0;

            while(num != randomNum)
            {
                num = IntRead("Gib die Zahl nun ein:", "Input not allowed. Please enter an Integer:");
                if(num > randomNum)
                {
                    Console.WriteLine("Die Zahl ist zu hoch!");
                } else if (num < randomNum) {
                    Console.WriteLine("Die Zahl ist zu niedrig!");
                } else
                {
                    Console.WriteLine("Du hast gewonnen!!!");
                }
            }



        }
    }
}
