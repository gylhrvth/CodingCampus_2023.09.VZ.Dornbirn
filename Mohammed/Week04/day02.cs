using System;
namespace Mohammed.Week04
{
	public class day02
	{
		public static void Start()
		{
            Console.WriteLine("RekursiveSum");
            int sum = RekursiveSum(5);
			Console.WriteLine("Die Rekursive Summe ist " + sum);


			Console.WriteLine("RekursiveFakt");
			int fakt = RekursiveFakt(4);
			Console.WriteLine("Die Rekursive fakt ist " + fakt);


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

		public static int RekursiveFakt(int x)
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

