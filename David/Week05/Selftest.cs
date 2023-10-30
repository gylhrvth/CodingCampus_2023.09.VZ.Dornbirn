using System;
using System.ComponentModel.Design;
using System.Drawing;
using David.Week04;

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
			Console.WriteLine();

            Console.WriteLine("Aufgabe3:");

            string symbol3 = "X";
            int amount3 = 3;
			Aufgabe3M(symbol3, amount3);
			Console.WriteLine();

            Console.WriteLine("Aufgabe4:");
			int size = 3;
			bool backslash = true;
			Aufgabe4M("x", size, backslash);
			Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("INPUT");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Aufgabe1:");

            //string userInput = ReadString();
            //int rep = ReadNumber();
            //Aufgabe1In(userInput, rep);
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("ARRAYS");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Aufgabe1:");
            int[] arr = new int[] { 0, 1, 23, 5, 12, 4, 4, 2, 5, 2, 10 };
            int[] arr2 = new int[] { 123, 19471, 1, 4, 15715, 15, 1, 5, 15, 1, -10, -100 };
            int[] arr3 = new int[] { 478199, 7812973, 12387123, 12, 3, 123, 12, 3, 1, 3, 1, 3, 1, 8, 9, 15, 1, 5, 1, 5, 1, 5, 15, 1, 5, 0 };

            string print1 = Aufgabe1ARR(arr);
            Console.WriteLine(print1);

            string print2 = Aufgabe1ARR(arr2);
            Console.WriteLine(print2);

            string print3 = Aufgabe1ARR(arr3);
            Console.WriteLine(print3);
        
         

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
                Console.WriteLine();
				}
				else 
				Console.WriteLine(symbol);
			}
		}

	
		public static void Aufgabe3M(string symbol, int amount)
		{
			Aufgabe1M(symbol, amount);
			Aufgabe2M(symbol, amount);
        }

        public static void Aufgabe4M(string symbol, int size, bool backslash)
		{
			if (backslash)
			{
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (j == i)
                    {
                        Console.Write(symbol);
                    }
					else
					{
						Console.Write(" ");
					}
                }
                Console.WriteLine();
            }
			}
			else
			{
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        if (j == (size - 1) - i)
                        {
                            Console.Write(symbol);
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }

		public static string ReadString()
		{
            string userInput = "";
            while (userInput == "")
            {
                try
                {
                    Console.WriteLine("Bitte geben Sie einen Text ein:");
                    userInput = Console.ReadLine();
                }
                catch (FormatException)
                {
                    Console.WriteLine("Das hat leider nicht funktioniert. Bitte geben Sie nochmals einen Text ein:");
                }
            }
            return userInput;
        }
        public static int ReadNumber()
        {
            int userRepNum = 0;
            while (userRepNum == 0)
            {
                try
                {
                    Console.WriteLine("Wie oft soll der Text ausgegeben werden?");
                    userRepNum = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Das hat leider nicht funktioniert. Bitte geben Sie AUSSCHLIESSLICH eine Zahl ein.");
                }
            }
            return userRepNum;
        }
        public static void Aufgabe1In(string text, int rep)
		{
			for (int i = 0; i < rep; i++)
			{
				Console.WriteLine(text);
			}
        }

        public static string Aufgabe1ARR(int[] arr)
        {
            string print1 = "";
            string pos1 = "";
            string pos2 = "";

            for (int i = 0; i < arr.Length; i++)
            {
                if (i == 0)
                {
                    pos1 = Convert.ToString(arr[i]);
                }
                if (i == arr.Length - 1)
                {
                    pos2 = Convert.ToString(arr[i]);
                }
                print1 = ("First: " + pos1 + ", Second: " + pos2 + ",");
            }
            return print1;
        }
    }
}

