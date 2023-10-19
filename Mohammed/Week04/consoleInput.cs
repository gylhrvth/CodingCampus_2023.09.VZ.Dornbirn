using System;
namespace Mohammed.Week04
{
    public class consoleInput
    {
        public static void Start()
        {

            //erste Aufgabe
            
            Random rand = new Random();
            int random = rand.Next(1, 10);

            bool winer = false;
            while(winer == false)
            {
                int value = ReadNumber("please guess a number between 1 and 10", 1, 10);

                //Prüfen

                //Richtig
                winer = true;

                //Nicht richtig
                
            }




            Console.WriteLine("===================================");


            Console.WriteLine("Willkommen beim super coolen zahlen Ratespiel!" +
                "Errate die Zahl zwischen 0 und 100!" + "Gib die Zahl nun ein");

           


        }

        public static int ReadNumber(string msg, int min, int max)
        {

            int value = 0;
            bool numberIsvalid = false;

            while (numberIsvalid)
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
                catch (Exception abc)
                {
                    Console.WriteLine("your input is not valid");
                }
            }
            return value;

        }


        

        

    }
}

