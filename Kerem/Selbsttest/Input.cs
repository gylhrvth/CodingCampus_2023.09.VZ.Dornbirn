using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Kerem.Selbsttest
{
    internal class Input
    {
        public static void Start()
        {
           PrintText();
        }

        public static string ReadString(string msg, string sign = "^[a-zA-Z]*$")
        {
            while (true)
            {
                Console.WriteLine(msg);
                string input = Console.ReadLine();
                if (input == "")
                {
                    Console.WriteLine("Bitte geben Sie etwas ein!");
                }
                else if (!Regex.IsMatch(input, sign))
                {
                    Console.WriteLine("Ungültige Eingabe!");
                }
                else
                {
                    return input;
                }

            }
        }
        public static int ReadNumber(string msg)
        {
            int number = 0;
            while (number == 0)
            {
                try
                {
                    Console.Write(msg);
                    number = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Geben Sie eine gültige Zahl ein!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Nummer zu hoch!");
                }
            }
            return number;
        }
    
        public static void PrintText()
        {
            string input = ReadString("Bitte geben Sie einen Text ein: ");
            int count = ReadNumber("Wie oft soll der Text ausgegeben werden: ");

            for(int i = 0; i < count; i++)
            {
                Console.WriteLine(input);
            }
        }
    }
}
