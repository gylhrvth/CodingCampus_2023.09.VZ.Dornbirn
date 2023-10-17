using System;
using static Patrick.Week03.ExamplesArrays;

namespace Patrick.Week04
{
    internal class SelectionSort
    {
        public static int[] array = RandomNumberArray(0, 101, 10);

        public static void start()
        {
            Console.WriteLine("Array");
            Console.WriteLine("[{0}]", string.Join(", ", array));
            PrintArrayFor(selectionSort(array));

        }

        public static int[] selectionSort(int[] array)
        {

            for (int x = 0; x < array.Length - 1; x++)
            {
                int min = x;
                for (int y = x + 1; y < array.Length; y++)
                {
                    if (array[y] < array[min])
                    {
                        min = y;

                    }
                }
                if (min != array[x])
                {
                    int temporaryMemory = array[min];
                    array[min] = array[x];
                    array[x] = temporaryMemory;
                }


            }
            Console.WriteLine("SelectionSort: ");
            return array;
        }
    }
}
