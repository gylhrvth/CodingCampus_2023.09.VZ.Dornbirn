using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week06.SelfTest
{
    internal class Input
    {
        public static void Start()
        {
            Console.WriteLine("Bitte geben Sie einen Text ein:");
            Console.Write(">>>>>");
            string inputText = ReadString();
            Console.WriteLine("Wie oft soll der Text ausgegeben werden?");
            Console.Write(">>>>>");
            int inputNumber = ReadNumber();
            Output(inputNumber, inputText);
        }

        public static string ReadString()
        {
            string inputText = "...";

            while (true)
            {
                inputText = Console.ReadLine();
                if (inputText == string.Empty)
                {
                    Console.WriteLine("Du musst einen Text eingeben, bitte wiederholen");
                    Console.Write(">>>>>");
                }
                else
                {
                    break;
                }

            }
            return inputText;
        }

        public static int ReadNumber()
        {
            while (true)
            {
                string inputNumber = Console.ReadLine();
                try
                {
                    return int.Parse(inputNumber);
                }
                catch (FormatException)
                {
                    Console.WriteLine("\"{0}\" Das ist keine Zahl, versuche es nocheinmal!", inputNumber);
                }
            }
        }

        public static void Output(int inputNumber, string inputText)
        {
            for (int i = 0; i < inputNumber; i++)
            {
                Console.WriteLine(inputText);
            }
        }
    }
}
