using System;
namespace David.Week03
{
	public class Week03Day02Arrays
	{
		public static void Week03Day02()
		{

			//Aufgabe 1
			Console.WriteLine("Aufgabe Number Array aufsteigend");

			int[] myArr = CreateArray(6);
            Console.WriteLine("[{0}]", string.Join(", ", myArr));
			Console.WriteLine();

			//Repeat 1
			Console.WriteLine("Absteigend");

			int[] rep1 = Repeat1(6);
            Console.WriteLine("[{0}]", string.Join(", ", rep1));
        }


		public static int[] CreateArray(int size)
		{
			int[] array1 = new int[size];
            
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = i + 1;
            }
            return array1;
        }

		public static int[] Repeat1(int count)
		{
			int[] arrrep = new int[count];

			for (int i = 0; i < arrrep.Length; i++)
			{
				arrrep[i] = count - i;
			}
			return arrrep;

		}
	}
}

