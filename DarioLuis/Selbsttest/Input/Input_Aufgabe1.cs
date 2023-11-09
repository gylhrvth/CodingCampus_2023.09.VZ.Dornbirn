using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarioLuis.Selbsttest.Input
{
    public class Input_Aufgabe1
    {
        public static void Main()
        {
            Console.WriteLine("Gib bitte einen Text ein:");
            string text = Console.ReadLine();

            Console.WriteLine("Wie oft soll der Text ausgegeben werden?");
            int amount = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < amount; i++)
            {
                Console.WriteLine(text);
            }
        }
    }
}
