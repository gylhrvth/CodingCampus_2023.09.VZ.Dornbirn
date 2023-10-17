using System;
namespace Eren.Week03
{
	public class ArrayZuHause
	{
        public static Random rand = new Random();

        public static void StartArrayZuHause()
        {

            int[] arr = RandomArray(10);

            foreach(int element in arr)
            {
                Console.WriteLine(element);
            }

            int summe = ArraySumme(arr);

            Console.WriteLine("Das ist die summe"+summe);

        }
        public static int ArraySumme(int[] arr)
        {
            int count = 0;
            foreach( int element in arr)
            {
                count += element;
            }

            return count;
        }

        public static int[] RandomArray(int size)
        {
            int[] Array = new int[size];
            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = rand.Next(0, 100);
            }
            return Array;
        }

    }
}

