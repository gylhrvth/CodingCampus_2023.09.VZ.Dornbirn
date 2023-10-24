using System;
namespace Mohammed.Week04.AtHome
{
    public class ConInput
    {

        public static Random rand = new Random();
        public static void Start()
        {
            int random = rand.Next(1, 1000);
            
            bool winer = false;
            while (winer == false)
            {
                int value = ReadNumber("please guess a number between 1 and 1000", 1, 1000);

                if (value == random)
                {
                    Console.WriteLine("Correct;)");
                    winer = true;

                }
                else if (value > random)
                {
                    Console.WriteLine("toooooo big:(");
                }
                else
                {
                    Console.WriteLine("toooo small:)");
                }
            }
        }


        public static int ReadNumber(string name, int min, int max)
        {
            int value = 0;

            bool numberIsvalid = false;

            while (!numberIsvalid)
            {
                Console.WriteLine(name);

                try
                {
                    string input = Console.ReadLine();

                    value = Convert.ToInt32(input);
                    if ((value >= min) && (value <= max))
                    {
                        numberIsvalid = true;

                    }
                    else
                    {
                        Console.WriteLine($"your coutn must between {min} and {max}");

                    }
                }
                catch (FormatException mu)
                {
                    Console.WriteLine("your input is not valid!!");
                }
            }
            return value;

        }

        
    }
}
