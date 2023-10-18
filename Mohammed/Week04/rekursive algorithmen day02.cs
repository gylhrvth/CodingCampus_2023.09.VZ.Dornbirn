using System;
namespace Mohammed.Week04
{
	public class day02
	{
		public static void Start()
		{
			Console.ForegroundColor = ConsoleColor.DarkBlue;

            Console.WriteLine("RekursiveSum");
            int sum = RekursiveSum(5);
			Console.WriteLine("Die Rekursive Summe ist " + sum);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("RekursiveFakt");
			long fakt = RekursiveFakt(55);
			Console.WriteLine("Die Rekursive fakt ist " + fakt);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Fibonacci");
			int fib = Fib(7);
			Console.WriteLine("Die fibonacci ist " + fib);
			
			
		}


		public static int RekursiveSum(int x)
		{
			if (x == 0)
			{
				return 0;
			}
			return x + RekursiveSum(x - 1);
			
		}

		public static long RekursiveFakt(int x)
		{
			if ( x == 1)
			{
				return 1;
			}
			return x  * RekursiveFakt( x - 1);
		}

		public static int Fib (int x)
		{
			if (x == 1 || x ==2)
			{
				return 1;
			}
			return Fib (x - 1) + Fib(x -2);

		}




	}
}

