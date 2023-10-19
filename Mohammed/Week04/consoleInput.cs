using System;
namespace Mohammed.Week04
{
    public class consoleInput
    {
        public static void Start()
        {

            //erste Aufgabe
            int guess = ReadNumber("please guess a number between 1 and 10", 1,10);
            Random rand = new Random();
            int value = rand.Next(0, 10);

            if (guess == value)
            {
                Console.WriteLine("correct;)");
            }

            

        }

        public static int ReadNumber(string msg, int min, int max)
        {

            int value = 0;
            bool numberIsvalid = false;

            while (numberIsvalid == false)
            {
                Console.WriteLine(msg);

                try
                {
                    string input = Console.ReadLine();
                    value = Convert.ToInt32(input);



                    if((value >= min) && (value <= max)){

                        numberIsvalid = true;
                    }
                    else
                    {
                        Console.WriteLine($"your count must between {min}and {max} ");
                    }
                }
                catch(Exception abc)
                {
                    Console.WriteLine("your input is not valid");
                }
            }
            return value;
            
        }

    }
}

