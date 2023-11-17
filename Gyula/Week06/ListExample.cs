using System;
namespace Gyula.Week06
{
	public class ListExample
	{
		private static Random rand = new Random();
		public static void Start()
		{
			List<int> values = new List<int>();

			for (int i = 0; i < 2000; i++)
			{
				values.Add(rand.Next(1, 101));
			}

            Console.WriteLine("Count: {0}", values.Count);
            Console.WriteLine("Capacity: {0}", values.Capacity);

			Console.WriteLine("[{0}]", string.Join(", ", values));

			for (int i = 0; i < values.Count; i++)
			{
				Console.WriteLine("{0}. is {1}", i, values[i]);
			}

			foreach (int item in values)
			{
				Console.WriteLine("Value: {0}", item);
			}

			values.RemoveAt(0);
			Console.WriteLine("[{0}]", string.Join(", ", values));


			Console.WriteLine("Ist 20 drin? " + values.Contains(20));
        }
    }
}

