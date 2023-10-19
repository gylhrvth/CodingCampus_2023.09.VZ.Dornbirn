using System;
namespace Mohammed.Week04
{
    public class consoleInput
    {
        public static void Start()
        {

            //erste Aufgabe
            /*int guess = ReadNumber("please guess a number between 1 and 10", 1,10);
            Random rand = new Random();
            int value = rand.Next(0, 10);

            if (guess == value)
            {
                Console.WriteLine("correct;)");
            }*/

            Console.WriteLine("===================================");


            Console.WriteLine("Willkommen beim super coolen zahlen Rarespiel!" +
                "Errate die Zahl zwischen 0 und 100!" + "Gib die Zahl nun ein");

            Random rand = new Random();
            int randomNumber = rand.Next(0, 100);
            

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


        public static void Rate(string[] array)
        {
            
            int randomNumber = new Random().Next(1, 101);

           
            Console.WriteLine("Bitte erraten Sie eine Zahl zwischen 1 und 100:");
            int guess = Convert.ToInt32(Console.ReadLine());

            
            if (guess == randomNumber)
            {
              
                Console.WriteLine("Sie haben gewonnen!");
            }
            else
            {
             
                Console.WriteLine("Sie haben verloren!");

     
                if (guess > randomNumber)
                {
                    Console.WriteLine("Ihre Zahl war zu hoch.");
                }
                else
                {
                    Console.WriteLine("Ihre Zahl war zu niedrig.");
                }
            }
        }



    }
}

