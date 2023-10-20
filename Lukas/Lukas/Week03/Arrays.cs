using System;
namespace Lukas.Week03
{
	public class Arrays
	{
		public Arrays()
		{
		}

		public static void Start()
		{
			int[] arr = new int[100];

			Random random = new Random();

			for (int i = 0; i < arr.Length; i++)
			{
				int randomNumber = random.Next(10, 100);
				arr[i] = randomNumber;
			}

			foreach (int element in arr)
			{
				Console.Write(element+" ");
			}

			Console.WriteLine();

			for(int i=0; i< arr.Length;i++)
			{
				if(i % 10 == 0)
				{
					Console.WriteLine();
				}
                Console.Write(arr[i] + " ");
            }
		}
	}
}

