using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Niklas
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
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 10 == 0)
                {
                    Console.WriteLine();
                }
                Console.Write(arr[i] + " ");
            }
            return arr;
        }
    }
}

