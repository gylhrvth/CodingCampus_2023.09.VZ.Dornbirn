using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Mohammed.Week03
{
	public class Arrayall
	{
		public static void startArrayall()
		{



			Console.WriteLine("orginal");
			int[] orginal = Array(10);

			foreach (int element in orginal)
			{
				Console.Write(element + ", ");
			}

			Console.WriteLine();
			Console.WriteLine("---------------");

			Console.WriteLine("Copy");
			int[] copy = makeAcopy(orginal);
			foreach(int element in copy)
			{
				Console.Write(element + ", ");
			}

			Console.WriteLine();

			Console.WriteLine("---------------");
			Console.WriteLine(" change orginal");
			orginal[9] = 200;
			foreach (int element in orginal)
			{
				Console.Write(element + " ");
			}
			Console.WriteLine();

			Console.WriteLine("..............");
			Console.WriteLine("change copy");
			foreach(int element in copy)
			{
				Console.Write(element + " ");
			}
			Console.WriteLine();


			//Random Number Array
			int[] RandomArr = RandomNumber(10);


            Console.WriteLine("[{0}]", string.Join(", ", RandomArr));

            foreach (int element in RandomArr)
            {
                Console.Write(element+ " ");
            }

        }

		//erster aufgebe
		public static int[] Array(int size)
		{
			int[] arr = new int[size];

			for (int i = 0; i< arr.Length; i++)
			{
				arr[i] = i + 1;
			}
			return arr;


		}

		// zweite aufgabe
		public static int[] makeAcopy(int[] orginal)
		{
			int[] copy = new int[orginal.Length];

			for (int i = 0; i < orginal.Length; i++)
			{
				copy[i] = orginal[i];
			}
			return copy;



		}


		//drite Aufgabe Random Number Array

		public static Random rand = new Random();

		public static int[] RandomNumber(int array)
		{
			int[] arr = new int[array];
			for (int i = 0; i< arr.Length; i++)
			{
				arr[i] = rand.Next(100);
			}
			return arr;

		}
	
		
        
    }


}

