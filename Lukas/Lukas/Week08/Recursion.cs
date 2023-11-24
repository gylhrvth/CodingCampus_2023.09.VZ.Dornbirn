using System;
namespace Lukas.Week08
{
	public class Recursion
	{
		public Recursion()
		{
		}

		public static void Start()
		{
			Console.WriteLine("The sum from 1 to 10 is: " + Sum(10));

			Console.WriteLine("Random number above 50: " + GetRandomNumberAbove50andBelow55());
		}


		public static int Sum(int number)
		{
			if(number < 0)
			{
				return 0;
			}
			Console.WriteLine(number + " + Sum(" + (number - 1) + ")");
			int result = number + Sum(number-1);
            Console.WriteLine("-->"+number + " "+result);
			return result;
        }

		public static int GetRandomNumberAbove50andBelow55()
		{
			Random random = new Random();

			int number = random.Next(0, 55);

			if(number > 50)
			{
				return number;
			} else
			{
				Console.WriteLine("I tried!");
				return GetRandomNumberAbove50andBelow55();
			}
		}
	}
}

