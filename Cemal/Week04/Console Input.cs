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
            Einlesen();
            Console.WriteLine();
            Zahleinlesen();






        }

        public static void Einlesen()
        {
            string input = Console.ReadLine();

            Console.WriteLine(input);
        }

        public static int Zahleinlesen()
        {
            
            Console.WriteLine("Gib eine Zahl an");
            int userInput = int.Parse(Console.ReadLine());
            Console.WriteLine("Deine Zahl ist: " + userInput);


            return 0;
        }
    }
}

