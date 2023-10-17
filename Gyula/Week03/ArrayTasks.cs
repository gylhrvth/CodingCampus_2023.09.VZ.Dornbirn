using System;
using System.Drawing;

namespace Gyula.Week03
{
	public class ArrayTasks
	{

		public static void Start()
		{
			int[] arr1 = ArrayGenerator.CreateArrayRandom(20, 0, 101);
			Console.WriteLine("[{0}]", string.Join(", ", arr1));

            Console.WriteLine("Count bigger 30: {0,4}", CountBigger30(arr1));
            Console.WriteLine("Summe          : {0,4}", Sum(arr1));
            Console.WriteLine("Avarage        : {0,7:N2}", Avarage(arr1));
            Console.WriteLine("Min            : {0,4}", Min(arr1));
            Console.WriteLine("Max            : {0,4}", Max(arr1));
        }

        public static void PrintArrayForEach(int[] arr)
		{
            Console.Write("[");
			bool first = true;
            foreach (int value in arr)
			{
				if (!first)
				{
                    Console.Write(", ");
                }
                Console.Write(value);
				first = false;
			}
			Console.WriteLine("]");
		}


        public static void PrintArrayForI(int[] arr)
        {
            Console.Write("[");
			for (int i = 0; i < arr.Length; i++)
			{
				if (i > 0) {
                    Console.Write(", ");
                }
                Console.Write(arr[i]);
			}
            Console.WriteLine("]");
        }

		public static void PrintSecondFifthTenth(int[] arr)
		{
			PrintXth(arr, 1);
            PrintXth(arr, 4);
            PrintXth(arr, 9);
        }

        public static void PrintXth(int[] arr, int pos)
        {
			if (pos >= 0 && pos < arr.Length)
			{
                Console.WriteLine(arr[pos]);
            }
			else
			{
				Console.WriteLine("n.a.");
			}
        }

        public static void PrintArrayEverySecond(int[] arr)
        {
            Console.Write("[");
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 2 == 1) // Select every second value
                {
                    if (i > 1)
                    {
                        Console.Write(", ");
                    }
                    Console.Write(arr[i]);
                }
            }
            Console.WriteLine("]");
        }


        public static int CountBigger30(int[] arr)
        {
            int counter = 0;
            foreach (int value in arr)
            {
                if (value > 30)
                {
                    ++counter;
                }
            }

            return counter;
        }

        public static int Sum(int[] arr)
        {
            int sum = 0;
            foreach (int value in arr)
            {
                sum += value;
            }
            return sum;
        }

        public static double Avarage(int[] arr)
        {
            if (arr.Length == 0)
            {
                return 0;
            }
            return Sum(arr) / (double)arr.Length; 
        }

        public static int Min(int[] arr)
        {
            int min = Int32.MaxValue;
            foreach (int value in arr)
            {
                if (value < min)
                {
                    min = value;
                }
            }

            return min;
        }

        public static int Max(int[] arr)
        {
            int max = Int32.MinValue;
            foreach (int value in arr)
            {
                if (value > max)
                {
                    max = value;
                }
            }

            return max;
        }
    }
}

