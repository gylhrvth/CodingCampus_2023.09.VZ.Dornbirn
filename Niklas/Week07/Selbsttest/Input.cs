using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Niklas.Week07.Selbsttest
{
    internal class Input
    {
        public static void Start()
        {
            input();
        }
        public static void input()
        {
            Console.Write("Gib einen text ein: ");
            string input = Console.ReadLine();
            Console.Write("Wie oft soll sich der text wiederholen: ");
            int amount = Convert.ToInt32(Console.ReadLine());

            for (; amount > 0; amount--)
            {
                Console.WriteLine(input);
            }
        }
    }
}
