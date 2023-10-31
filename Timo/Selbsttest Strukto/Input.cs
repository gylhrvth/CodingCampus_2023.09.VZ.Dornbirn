using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timo.Selbsttest_Strukto
{
    internal class Input
    {
        public static void Start()
        {
            Print();
        }

        public static string ReadString(string msg)
        {
           
                string line = "";
                bool firstTry = true;
                while (line.CompareTo("") == 0)
                {
                    if (!firstTry)
                    {
                        Console.WriteLine("I did not understand. Please try again!");
                    }
                    Console.WriteLine(msg);
                    line = Console.ReadLine();
                    firstTry = false;
                }
                return line;
            

        }
        public static int ReadNumber(string msg, int min, int max)
        {
            int result = Int32.MaxValue;
            while (result == Int32.MaxValue)
            {
                Console.Write("{0}between {1} and {2}: ", msg, min, max);
                string line = Console.ReadLine();
                try
                {
                    result = Convert.ToInt32(line);
                    if (result < min || result > max)
                    {
                        Console.WriteLine("{0} is not in range of {1} and {2}", result, min, max);
                        result = Int32.MaxValue;
                    }
                }
                catch (FormatException fe)
                {
                    Console.WriteLine("\"{0}\" is not a valid number.", line);
                }
            }
            return result;
        }

        public static void Print()
        {
            string input = ReadString("Bitte geben Sie einen Text ein:");
            int repetitions = ReadNumber("Wie oft soll der Text ausgegeben werden:", 1,100);
            for (int i = 0; i < repetitions; i++)
            {
                Console.WriteLine(input);
            }
        }
    }
}
