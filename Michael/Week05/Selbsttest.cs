using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Michael.Week05
{
    internal class Selbsttest
    {
        public static void Start()
        {
            ZweiVier('x', 8, false);
        }


        public static void EinsEins()
        {
            for (int i = 10; i >= 0; i--)
            {
                Console.Write(i + " ");
            }
        }


        public static void EinsZwei()
        {
            for (int i = -30; i <= 30; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }


        public static void EinsDrei()
        {
            int i = 0;
            while (i <= 10)
            {
                Console.WriteLine(i);

                if (i > 5)
                {
                    Console.WriteLine();
                }

                i++;
            }
        }


        public static void ZweiEins(string symbol, int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                Console.Write(symbol + " ");
            }
        }


        public static void ZweiZwei(string symbol, int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                Console.WriteLine(symbol + "\n");
            }
        }


        public static void ZweiDrei(string symbol, int amount)
        {
            ZweiEins(symbol, amount);
            ZweiZwei(symbol, amount);
        }


        public static void ZweiVier(char symbol, int length, bool backslash = false)
        {
            for (int y = 0; y < length; y++)
            {
                for (int x = 0; x < length; x++)
                {
                    if (backslash && x - y == 0)
                    {
                        Console.Write(symbol);
                        break;
                    }
                    else if (!backslash && x + y == length - 1)
                    {
                        Console.Write(symbol);
                        break;
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }


        public static void DreiEins()
        {
            string userString = "";
            int userInt = 0;

            while (userString == null || userString == "")
            {
                Console.WriteLine("please enter a string that shall be repeated");
                userString = Console.ReadLine().Trim();
            }

            while (true)
            {
                try
                {
                    Console.WriteLine("and how often shall we repeat it?");
                    userInt = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("invalid input, sorry");
                }
            }

            for (int i = 0; i < userInt; i++)
            {
                Console.WriteLine(userString);
            }
        }
    }
}
