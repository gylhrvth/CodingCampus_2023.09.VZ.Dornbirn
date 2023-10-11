	using System;
namespace Gyula.Week03
{
	public class RandomExample
	{
        public static Random rand = new Random(1234);
        public static void StartRandomExample()
		{
			Console.WriteLine(DateTime.Now.Ticks);

			for (int i = 0; i < 10; i++)
			{
				Console.WriteLine(rand.Next(100));
			}
		}
	}
}

