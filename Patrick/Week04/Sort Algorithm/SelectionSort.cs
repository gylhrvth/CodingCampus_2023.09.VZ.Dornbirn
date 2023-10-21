using System;
using static Patrick.Week03.ExamplesArrays;

namespace Patrick.Week04
{
    internal class SelectionSort
    {

        public static void Start()
        {
            int[] array = RandomNumberArray(0, 101, 10);
            Console.WriteLine("Array");
            Console.WriteLine("[{0}]", string.Join(", ", array));
           
            SelectionSort1(array);

        }

        public static int SearchMinPos(int[] array, int start)
        {
            int min = start;
            for (int i = min; i < array.Length; i++)
            {
                if (array[i] < array[min])
                {
                    min = i;
                }               
            }
            return min;
        }

        public static void SelectionSort1(int[] array)
        {
            for (int x = 0; x < array.Length; x++)
            {
                int minPos = SearchMinPos(array, x);

                int temp = array[x];
                array[x] = array[minPos];
                array[minPos] = temp;
                Console.WriteLine("[{0}]", string.Join(", ", array));
            }
        }
    }
}
