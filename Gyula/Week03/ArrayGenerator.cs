using System;
namespace Gyula.Week03
{
	public class ArrayGenerator
	{
        public static Random rand = new Random();


        public static int[] CreateArrayAsc(int size)
        {
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = 1 + i;
            }
            return arr;
        }

        public static int[] CreateArrayDesc(int size)
        {
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = size - i;
            }
            return arr;
        }

        public static int[] CopyOfArray(int[] original)
        {
            int[] arr = new int[original.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = original[i];
            }
            return arr;
        }

        public static int[] CreateArrayRandom(int size)
        {
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(101);
            }
            return arr;
        }

        public static int[] CreateArrayRandom(int size, int min, int max)
        {
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(min, max);
            }
            return arr;
        }

    }
}

