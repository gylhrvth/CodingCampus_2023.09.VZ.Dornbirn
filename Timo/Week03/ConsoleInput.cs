using System;

namespace Timo.Week03
{
    public class ConsoleInputs
    {
        public static void Start()
        {
            /*
            //Aufgabe1
            Console.WriteLine("Aufgabe1: String einlesen");

            Console.WriteLine("Please enter your String");
            String stringInput = Console.ReadLine();
            Console.WriteLine("The input was : " + stringInput);

            Console.WriteLine("=======================================");


            //Aufgabe2.2 Zahl einlesen
            Console.WriteLine("Aufgabe2: Zahl einlesen");

            int readNumber = ReadNumber("Please enter your number:", "Thats not a number. Please try again:");
            Console.WriteLine("Read number is: " + readNumber);

            Console.WriteLine("=======================================");
            */

            //Aufgabe3 Ratespiel
            Console.WriteLine("Aufgabe3: Ratespiel");
            Guessinggame(ReadNumber("Please enter your number:", "Thats not a number. Please try again:"));


        }

        //Aufgabe1
        public static string ReadString(String input)
        {
            String myInput = Console.ReadLine();
            return myInput;
        }


        //------------------------------------------------------------------------------------------------------------------------------

        //Aufgabe2
        public static int ReadNumber(String prompt, String onError)
        {
            Console.WriteLine(prompt);

            while (true)
            {
                try
                {
                    String input = Console.ReadLine();

                    int myNumber = Convert.ToInt32(input);

                    return myNumber;
                }
                catch (FormatException exc)
                {
                    Console.Error.WriteLine(onError);
                }
            }
        }


        //------------------------------------------------------------------------------------------------------------------------------

        //Aufgabe3
        public static void Guessinggame(int input)
        {
            int count = 1;
            int i = new Random().Next(1, 101);

            while (input != i)
            {
                int zahl = input;
                if (i < zahl)
                {
                    Console.WriteLine("Your number is too big, try again");
                }
                else if (i > zahl)
                {
                    Console.WriteLine("Your number is too small, try again");
                }
                else
                {
                    Console.WriteLine("You have won! Number of guesses: " + count);
                }
                count++;
            }
        }
    }
}
