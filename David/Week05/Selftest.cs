using System;
using System.ComponentModel.Design;

namespace David.Week05
{
	public class Selftest
	{
		public static void Start()
		{
            Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("SCHLEIFEN");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Aufgabe1:");
			Aufgabe1(10);
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("Aufgabe2:");
			Aufgabe2(30);

            Console.WriteLine();
            Console.WriteLine("Aufgabe3:");
			Aufgabe3(10);
            Console.WriteLine();

			Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("METHODEN");
			Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Aufgabe1:");

			string symbol = "X";
			int amount = 10;
			Aufgabe1M(symbol, amount);
			Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Aufgabe2:");

			string symbol2 = "X";
			int amount2 = 3;
			Aufgabe2M(symbol2, amount2);

            Console.WriteLine("Aufgabe3:");

            string symbol3 = "X";
            int amount3 = 3;
            Aufgabe3M(symbol3, amount3);

        }


        public static void Aufgabe1(int max)
		{
			for (int i = max; i >= 0; i--)
			{
				Console.Write(i + " ");
			}
		}

		public static void Aufgabe2(int count)
		{
			for (int i = -count; i <= count; i++)
			{
				int teilbar = i % 3;
				if (teilbar == 0)
				{
					Console.WriteLine(i);
				}
			}
		}

        public static void Aufgabe3(int count)
        {
            for (int i = 0; i < count; i++)
            {
				while (i <= 5)
				{
					Console.WriteLine(i++);
				}
				Console.WriteLine();
				Console.WriteLine(i);
            }
        }

		public static void Aufgabe1M(string symbol, int amount)
		{
			for (int i = 0; i < amount; i++)
			{
				Console.Write(symbol + " ");
			}
			
		}

		public static void Aufgabe2M(string symbol, int amount)
		{
			for (int i = 0; i < amount; i++)
			{
				if (i < amount-1)
				{
                Console.WriteLine(symbol);
                Console.WriteLine("-");
				}
				else 
				Console.WriteLine(symbol);
			}
		}

	
		public static void Aufgabe3M(string symbol, int amount)
		{

			Console.WriteLine(Selftest.Aufgabe1M);
			Console.WriteLine(Selftest.Aufgabe2M);
		}
    }
}

