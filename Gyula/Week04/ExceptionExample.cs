using System;
using System.Text;
using Gyula.Week03;
namespace Gyula.Week04
{
	public class ExceptionExample
	{
		public static void Start()
		{
			int[] arr = ArrayGenerator.CreateArrayRandom(9);
			for (int i = 0; i < 10; i++)
			{
				PrintPos(arr, i);
			}
		}


		public static void PrintPos(int[] arr, int pos)
		{
			try
			{
                Console.WriteLine("{0}. is {1}", pos, arr[pos]);
            } catch (IndexOutOfRangeException ioore)
			{
				Console.WriteLine("Nicht vorhandene Position");
                //Console.WriteLine(ioore.ToString());
            }


        }


	}
}

