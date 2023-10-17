using System;
using static David.Week03.Week03Day03RandomArrays;

namespace David.Week04
{
    public class Day01
    {
        public static void StartDay01()
        {
            int[] arr = RandomA(20);
            

            BubbleSort(arr);
            Console.WriteLine("Sorted:");
            for (int i = 0; i < 1; i++)
            {
                Console.Write("[{0}]", string.Join(", ", arr));
            }
            Console.WriteLine();


        }

        public static int[] BubbleSort(int[] array)
        {
            int i = 0;
            int j = 0;

            for (j = 0; j < array.Length; j++)
            {
                for (i = 0; i < array.Length - j - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                    }
                }
            }
            return array;
        }
    }
    
}
