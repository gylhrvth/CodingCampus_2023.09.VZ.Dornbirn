using System;
namespace Lukas.Week01
{
	public class Day03Methods
	{
		public Day03Methods()
		{
		}


		public static int Add(int number1, int number2)
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
		}
	}
}

