using System;
namespace David.Week03
{
	public class Week03Day02Arrays
	{
		public static void Week03Day02()
		{

			//Aufgabe 1
			Console.WriteLine("Aufgabe Number Array");

			int[] myArr = CreateArray(6);
			Console.WriteLine("[{0}]", string.Join(", ",myArr));

		}
		public static int[] CreateArray(int size)
		{
			int[] array1 = new int[size];
			for (int i=0; i<array1.Length; i++)
			{
				array1[i] = i + 1;
			}

			foreach (int element in array1)
			{
				Console.Write(element + " ");
			}
			return array1;
		}
	}
}

