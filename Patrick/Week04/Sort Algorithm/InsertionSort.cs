using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week04
{
    internal class InsertionSort
    {
        public static void Start()
        {
            //PrintArray(CreateRandomArray(10));
            PrintArray(InsertionSortPatrick(CreateRandomArray(10)));

        }

        public static int[] CreateRandomArray(int length)
        {
            int[] array = new int[length];
            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                array[i] = random.Next(0, 100);
            }
            return array;
        }

        public static void PrintArray(int[] array)
        {
            foreach (int item in array)
            {
                Console.Write(item + " ");
            }
        }


        public static int[] InsertionSortPatrick(int[] array)
        {

            for (int i = 0; i <= array.Length -1; i++)
            {
                int tempMemory = array[i];
                int j = i - 1;

                while (j >= 0 && array[j] > tempMemory)
                {
                    array[j + 1] = array[j];
                    j -= 1;
                }
                array[j + 1] = tempMemory;
            }
            return array;
        }

    }
}
