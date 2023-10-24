using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Gheorghe.Week04
{
    internal class UserInput
    {
        public static void Start()
        {
            //Console.WriteLine("Bitte geben Sie Ihren Namen ein:");
            //string eingabe = Console.ReadLine();
            //Console.WriteLine("Ihr Name lautet: {0}", eingabe);

            //StringEinlesen();

            //int inputNumber = ZahlEinlesen();
            //Console.WriteLine(inputNumber);

            // int zahl = ZahlEinlesen2();
            // Console.WriteLine("Die eingegebene zahl ist: {0}", zahl  );

            GuessGame2();
        }

        static void StringEinlesen()
        {
            string eingabe = Console.ReadLine();

            Console.WriteLine("Die Eingabe war: {0}", eingabe);
        }



        static int ZahlEinlesen()
        {
            Console.WriteLine("Bitte geben Sie einen zahl ein!");
            string input = Console.ReadLine();

            int zahl = int.Parse(input);

            return zahl;
        }


        static int ZahlEinlesen2()
        {
            int zahl = 0;

            while (zahl == 0)
            {
                Console.WriteLine("Bitte geben Sie eine Zahl ein!");
                string input = Console.ReadLine();

                try
                {
                    zahl = int.Parse(input);
                    return zahl;
                }
                catch (Exception exc)
                {
                    Console.WriteLine("Die Eingabe ist keine Zahl!");
                }
            }
            return zahl;
        }




        static void GuessGame()
        {

            int geheimZahl = new Random().Next(0, 100);

            bool gewonnen = false;

            while (!gewonnen)
            {
                Console.WriteLine("Willkommen beim super coolen Zahlen Ratespiel");
                Console.WriteLine("Errate die Zahl zwischen 0 und 100!");
                Console.WriteLine("Gib die Zahl nun ein:");

                int gerateneZahl = ZahlEinlesen2();

                if (gerateneZahl == geheimZahl)
                {
                    Console.WriteLine("Du hast gewonnen");
                    gewonnen = true;
                }
                else if (gerateneZahl < geheimZahl)
                {
                    Console.WriteLine("Die Zahl ist zu niedrig!");
                }
                else
                {
                    Console.WriteLine("Zahl ist zu Hoch!");
                }
            }
        }








        static void GuessGame2()
        {
            Console.WriteLine("Willkommen beim super Coolen zahlen Ratesspiel!");

            int SecretNumber = new Random().Next(0, 100);

            bool win = false;

            while (!win)
            {
               

                int generatedNumber = ZahlEinlesen2();

                if (generatedNumber == SecretNumber)
                {
                    Console.WriteLine("Du hast gewonnen");
                    win = true;
                      
                }
                else if (generatedNumber < SecretNumber)

                {
                    Console.WriteLine("Die Zahl ist zu niedrig");

                }
                else
                {
                    Console.WriteLine("Zahl ist zu hoch");
                }
            }




        }
    }
}




















