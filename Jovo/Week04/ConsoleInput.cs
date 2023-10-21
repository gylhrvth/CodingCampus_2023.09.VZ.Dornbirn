using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Jovo.Week03;

namespace Jovo.Week04
{
    internal class ConsoleInput
    {


        public static void Start()
        {

            //string input = Console.ReadLine();
            //Console.WriteLine("the input was" + input);


            //int readNumber = ReadNumber("Please enter a number:", "Your number is bad. Please try again:");
            //Console.WriteLine("Read number is:" + readNumber);

            Console.BackgroundColor = ConsoleColor.DarkGreen;

            GuessGame();



            

        }


        public static int ReadNumber(String prompt, String onError)
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
                catch (FormatException exc)
                {
                    Console.Error.WriteLine(onError);
                }




            }


        }
        public static void GuessGame()
        {
            int num = new Random().Next(100) + 1;
            int guess = 0;
            int tries = 0;

            Console.WriteLine("Welcome to my guess game!");
            Console.WriteLine("GOOD LUCK");

            while (num != guess)
            {

                try
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
                        Console.WriteLine("DAMMNNN YOU GOT IT NICE!!!!");
                    }
                    else if (guess > num)
                    {
                        Console.WriteLine($"{guess} is too high dont give up!");
                    }
                    else if (guess < num)
                    {
                        Console.WriteLine($"{guess} is too low dont give up!");
                    }
                    else
                    {
                        Console.WriteLine("versuch etwas anderes");
                    }
                    

                }


                catch 
                {
                    Console.Error.WriteLine("Es funktionieren nur Zahlen");

                }











            }
        }
    }


}
