using System;
namespace Mohammed.Week04
{
    public class consoleInput
    {
        public static Random random = new Random();
        public static void Start()
        {

            //erste Aufgabe

            Random rand = new Random();
            int random = rand.Next(1, 10);

            bool winer = false;
            while (winer == false)
            {
                int value = ReadNumber("please guess a number between 1 and 10", 1, 10);

                //Prüfen

                //Richtig
                winer = true;

                //Nicht richtig

            }


        }

        public static int ReadNumber(string msg, int min, int max)
        {

            int value = 0;
            bool numberIsvalid = false;

            while (!numberIsvalid)
            {
                Console.WriteLine(msg);

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
                        Console.WriteLine($"your count must between {min}and {max} ");
                    }
                }
                catch (FormatException abc)
                {
                    Console.WriteLine("your input is not valid!!!!");
                }
            }
            return value;

        }


        

        

    }
}

