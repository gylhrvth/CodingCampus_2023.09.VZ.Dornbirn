using System;
using System.Security.AccessControl;

namespace David.Week04
{
    public class Day04
    {
        public static void Start()
        {
            Console.WriteLine("Bitte gib einen Minimalwert ein.");
            int userMin = int.Parse(Console.ReadLine());
            int min = userMin;

            Console.WriteLine("Bitte gib einen Maximalwert ein.");
            int userMax = int.Parse(Console.ReadLine());
            int max = userMax;

            Random rand = new Random();
            int value = rand.Next(min, max + 1);


            bool repeat = true;

            while (repeat)
            {
            int guess = ReadNumber("Bitte rate eine Zahl zwischen " + min + " und " + max + " liegen.", min, max);
               

                    if (guess == value)
                    {
                        repeat = false;
                        Console.WriteLine("Richtig!");
                        Console.WriteLine("End of program");
                    }
                    else
                    {
                        Console.WriteLine("Probiers nochmal!");
                        Console.WriteLine(guess);
                    }
                
          
            }
          
            
        }



        public static int ReadNumber(string message, int min, int max)
        {
            int value = 0;
            bool numberIsValid = false;

            while (numberIsValid == false)
            {
                Console.WriteLine(message);
                try
                {
                    String input = Console.ReadLine();
                    value = Convert.ToInt32(input);

                    if ((value >= min) && (value <= max))
                    {
                        numberIsValid = true;
                    }
                    else
                    {
                        Console.WriteLine($"Deine Zahl muss zwischen {min} und {max} liegen.");
                    }
                }
                catch (Exception exc)
                {
                    Console.WriteLine("Deine Eingabe ist ungültig!");
                }
            }
            return value;





        }



    }
}

