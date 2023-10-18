using System;
namespace Eren.Week04
{
	public class TwoDArray
	{
        public static Random rand = new Random();

        public static void StartTwoDArray() {

            int[][] arr = RandomArray(10);

            foreach (int[] element in arr)
            {
                Console.WriteLine(element + "a");
            }
            Console.WriteLine(arr);

        }

        public static int[][] RandomArray(int size)
        {
            int[][] Array = new int[size][];
            for (int i = 0; i < Array.Length; i++)
            {
                Array[i][i] = rand.Next(0, 100);
            }
            return Array;
        }


    }
}

