using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon.Selbsttest
{
    internal class Input
    {
        public static void Start() 
        {
            Print(ReadString(), Readint());
        }

        public static string ReadString()
        {
            while (true)
            {
                Console.WriteLine("Bitte geben Sie einen Text ein:");
                try
                {
                    string input = Console.ReadLine();
                    if (input != "")
                    {
                        return input;
                    }
                }
                catch
                {
                    Console.WriteLine("Ungültige eingabe versuche es erneut");
                }
            }
        }

        public static int Readint()
        {
            while (true)
            {
                Console.WriteLine("Wie oft soll der Text ausgegeben werden:");
                try
                {
                    string input = Console.ReadLine();
                    int output = Convert.ToInt32(input);
                    return output;
                }
                catch
                {
                    Console.WriteLine("Ungültige eingabe versuche es erneut");
                }
            }
        }
        public static void Print(string userinput, int userinput1)
        {
            for (int i = 0; i < userinput1; i++)
            {
                Console.WriteLine(userinput);
            }
        }


    }
}
