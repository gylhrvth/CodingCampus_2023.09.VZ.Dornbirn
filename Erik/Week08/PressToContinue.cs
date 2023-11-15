using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erik.Week08
{
    internal class PressToContinue
    {
        public static void Start(string message)
        {
            Console.WriteLine(message);

            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {
                Console.WriteLine("\nWrong Input! Try again!");
            }
        }
    }
}
