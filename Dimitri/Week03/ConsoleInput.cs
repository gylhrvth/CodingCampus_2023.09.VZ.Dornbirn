using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dimitri.Week03
{
    internal class ConsoleInput
    {
        public static void Main()
        {
            Console.WriteLine("Write your input here:");
            StringOutput(StringRead());
        }

        public static string StringRead()
        {
            string input = Console.ReadLine();
            return input;

        }

        public static void StringOutput(string input)
        {
            Console.WriteLine("This is your input:");
            Console.WriteLine(input);

        }
    }
}
