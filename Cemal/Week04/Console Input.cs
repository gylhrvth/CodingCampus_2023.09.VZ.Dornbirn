using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cemal.Week04
{
    internal class ConsoleInput
    {
        public static Random random = new Random();
        public static void StartInput()
        {

            //// Name eingeben
            //string userinput = Einlesen("Wie heißt du?");
            //Console.WriteLine("Wilkommen " + userinput);
            //Console.WriteLine();

            ////Alter eingeben
            //int userinputnumber = Zahleinlesen("Wie alt bist du?", "Gib nur Zahlen ein!");
            //Console.WriteLine("Du bist " + userinputnumber + "Jahre alt.");
            //Console.WriteLine();

            //Ratespiel
            Console.WriteLine();
            Ratespiel();
            Console.WriteLine();
        }

        public static string Einlesen(string prompt)
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine();
            return input;

        }

        public static int Zahleinlesen(string prompt, string error)
        {
            Console.WriteLine(prompt);

            while (true)
            {
                try
                {
                    int userinput = int.Parse(Console.ReadLine());
                    return userinput;
                }
                catch (Exception)
                {
                    Console.WriteLine(error);
                }
            }
        }

        public static void Ratespiel()
        {

            Console.WriteLine("Wilkommen beim super coolen Zahlen Ratespiel!");
            Console.WriteLine("Errate die Zahl zwischen 0 und 100!");
            Console.WriteLine("Jetzt gib eine Zahl ein: ");
            int eingabe = 0;
            int randomnumber = random.Next(101);
            int counter = 0;

            while (eingabe != randomnumber)
            {
            eingabe = int.Parse(Console.ReadLine());
                counter++;

                if (eingabe == randomnumber)
                {
                    Console.WriteLine("Hurraaa! Du hast die Zahl erraten!");
                    Console.WriteLine("Du hast {0} versuche gebraucht!", counter);
                }

                else if (eingabe <= randomnumber)
                {
                    Console.WriteLine("Die Zahl ist zu niedrig!");
                }

                else if (eingabe > randomnumber)
                {
                    Console.WriteLine("Die Zahl ist zu hoch!");
                }
            }
            Console.ReadKey();
        }
    }
}

