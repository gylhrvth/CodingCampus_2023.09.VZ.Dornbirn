using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cemal.Week04
{
    internal class ConsoleInput
    {
        public static void StartInput()
        {
            Console.WriteLine("String einlesen");
            //stringEinlesen();
            Console.WriteLine();
            //Zahleinlesen("Deine Zahl ist: ");
            //Console.WriteLine("Deine Zahl ist: " + userinput);






        }

        public static string Einlesen()
        {
            string input = Console.ReadLine();
            return input;
            
        }

        public static int Zahleinlesen(string ergebnis, string error)
        {
            
            Console.WriteLine("Gib eine Zahl an");

            string input = Console.ReadLine();
            int userinput = Convert.ToInt32(input);
            //int userInput = int.Parse(Console.ReadLine());



            return userinput;
        }
    }
}

