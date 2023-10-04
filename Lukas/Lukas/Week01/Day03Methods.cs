using System;
namespace Lukas.Week01
{
	public class Day03Methods
	{
		public Day03Methods()
		{
		}


		public static int Add(int number1, int number2 = 10)
		{
			int result = number1 + number2;
			return result;
		}

		public static void Start()
		{
			Console.WriteLine("Calling Method Add:");

			int number1 = 100;
			int number2 = 300;

			int numberResult = Add(number1, number2);

			Console.WriteLine(Add(number1, number2));


			printChars("1", 5);
			Console.WriteLine();

			Console.WriteLine("Printing square:");
			printSquare("#", 100);
		}

        public static void printChars(String text, int repeatTimes)
		{
			for (int i = 0; i < repeatTimes; i++)
			{
				Console.Write(text);
			}
		}

		public static void printSquare(String text, int width)
		{
			for(int row = 0; row < width; row++)
			{
				Console.Write(row);
				Console.Write($"\u001B[{row}m");
				printChars(text, width);
                Console.Write("\u001B[0m");
                Console.WriteLine();
				Thread.Sleep(10);
				Console.Write("\u001b[H\u001b[2J");
            }
			
		}

		
	}
}
