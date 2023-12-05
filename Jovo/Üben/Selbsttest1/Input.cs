using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jovo.Üben.Selbsttest1
{
    internal class Input
    {
        public static void Start()
        {
            Input1("Bitte geben Sie einen Text ein:", "Wie oft soll der Text ausgegeben werden:");
        }
        public static int ReadNumber(string msg)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine(msg);
                    string input = Console.ReadLine();
                    int HowOften = Convert.ToInt32(input);
                    return HowOften;
                }
                catch
                {
                    Console.WriteLine("Gib bitte nur eine Zahl ein");
                }
            }
        }
        public static string ReadString(string msg)
        {
            while (true)
            {
                try
                {
                    Console.Write(msg);
                    string input = Console.ReadLine();
                    return input;
                }
                catch
                {
                    Console.WriteLine("Gib bitte einen Satz ohne Zahlen oder zeichen ein");
                }
            }
        }
        public static void Input1(string askText, string HowOften)
        {
            string text = ReadString(askText);
            int times = ReadNumber(HowOften);
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine(text);
            }
        }
    }
}
