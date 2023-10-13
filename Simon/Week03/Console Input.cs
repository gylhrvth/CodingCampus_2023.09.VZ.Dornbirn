using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon.Week03
{
    internal class Console_Input
    {
        public static Random random = new();
        public static void Start()
        {
            //Console.WriteLine("Task - Read a String");
            //String userinputstring = ReaduserinputString("Enter a String");
            //Console.WriteLine("Userinput was: " + userinputstring);

            //Console.WriteLine("\nTask - Read a Number");
            //int userinput = Readuserinputint("Enter a number", "Please only input numbers! Try again!");
            //Console.WriteLine("Userinput was: " + userinput);

            Console.WriteLine("Task - Guessinggame");
            int game = Guessinggame("Willkommen beim super coolen Zahlen Ratespiel", "Errate die Zahl zwischen 0 und 100", "Die Zahl ist zu hoch!", "Die zahl ist zu niedrig!", "Du hast gewonnen!!! DAS WAR DIE RICHTIGE ZAHL", "Please only input numbers! Try again!");

        }

        //Aufgabe String einlesen
        public static String ReaduserinputString(String prompt)
        {
            Console.WriteLine(prompt);
            while (true)
            {

                String input = Console.ReadLine();
                return input;
            }
        }

        //Aufgabe Zahl einlesen
        public static int Readuserinputint(String promt, String error)
        {
            Console.WriteLine(promt);
            while (true)
            {
                try
                {
                    String input = Console.ReadLine();
                    int output = Convert.ToInt32(input);
                    return output;
                }
                catch
                {
                    Console.WriteLine(error);
                }
            }
        }

        //Aufgabe Ratespiel
        public static int Guessinggame(String promt1, String promt2, String hnumber, String lnumber, String won, String error)
        {
            Console.WriteLine(promt1);
            Console.WriteLine(promt2);
            int winningnumber = random.Next(0, 101);
            while (true)
            {
                try
                {
                    String input = Console.ReadLine();
                    int output = Convert.ToInt32(input);
                    if (output == winningnumber)
                    {
                        Console.WriteLine(won);
                    }
                    else if (output < winningnumber)
                    {
                        Console.WriteLine(lnumber);
                    }
                    else
                    {
                        Console.WriteLine(hnumber);
                    }
                    return output;
                }
                catch
                {
                    Console.WriteLine(error);
                }
            }
        }


    }
}
