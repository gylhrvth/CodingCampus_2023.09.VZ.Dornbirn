using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
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
            string prompt = "Write your integer here:";
            IntOutput(IntRead(prompt));
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

        public static int IntRead(string prompt)
        {
            Console.WriteLine(prompt);
            while (true)
            {
                try
                {
                    String input = Console.ReadLine();
                    int ourNumber = Convert.ToInt32(input);
                    return ourNumber;
                }
                catch (Exception e)
                {
                    StringOutput("Input not allowed. Please enter an Integer:");
                }
            }
        }

        public static void IntOutput(int input)
        {
            Console.WriteLine("This is your integer:");
            Console.WriteLine(input);
        }
    }
}
