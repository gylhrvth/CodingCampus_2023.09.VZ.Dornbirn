using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
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

            //Console.WriteLine("Task - Guessinggame");
            //Guessinggame("Willkommen beim super coolen Zahlen Ratespiel", "Errate die Zahl zwischen 0 und 100", "Die Zahl ist zu hoch!", "Die zahl ist zu niedrig!", "Du hast gewonnen!!! DAS WAR DIE RICHTIGE ZAHL", "Please only input numbers! Try again!");
            Console.WriteLine("Input parameters for Guessing Game");
            Guessinggame(ReaduserinputString("schreibe eine Willkommensnachricht"), 
                ReaduserinputString("user soll wissen in welchem Parameter er die Zahlen erraten soll"),
                ReaduserinputString("schreibe eine Ausgabe für wenn die Zahl zu hoch ist"), 
                ReaduserinputString("schreibe eine Ausgabe für wenn die Zahl zu nieder ist"), 
                ReaduserinputString("schreibe eine Siegesnachricht"), 
                ReaduserinputString("schreibe eine fehlernachricht für ungültige eingaben"),
                ReaduserinputString("schreibe eine anchricht die sagen soll wie viele Versuche man gebraucht hat (danach wird die zahl ausgegeben)"));

        }

        //Aufgabe String einlesen
        public static String ReaduserinputString(String prompt)
        {
            Console.WriteLine(prompt);
                String input = Console.ReadLine();
                return input;
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
        public static void Guessinggame(String promt1, String promt2, String hnumber, String lnumber, String won, String error, String numberofguesses)
        {
            Console.WriteLine(promt1);
            int winningnumber = random.Next(0, 101);
            int count = 0;
            while (true)
            {
                try
                {
                    int output = Readuserinputint(promt2, error);
                    if (output > winningnumber)
                    {
                        Console.WriteLine(hnumber);
                    }
                    else if (output < winningnumber)
                    {
                        Console.WriteLine(lnumber);
                    }
                    else
                    {
                        Console.WriteLine(won);
                        Console.WriteLine(numberofguesses, count);
                        return;
                    }
                    count ++;
                }
                catch
                {
                    Console.WriteLine(error);
                }
            }
        }
        //Aufgabe Erweitere die früheren Aufgaben um Benutzereingabe



    }
}
