using System;


namespace Erik.Week03
{
    public class SortAlgorithmBubblesortDecrease
    {
        public static void StartSortAlgorithm()
        {
            int[] arr = NumbersOutput(-150, 100, 20);
            Console.WriteLine("Unsorted numbers:");
            PrintArrayWithIndex(arr);
            Console.WriteLine("Sorted numbers");
            SortAlgoBubblesort(arr);
            PrintArrayWithIndex(arr);

        }

        public static int[] NumbersOutput(int randMin, int randMax, int randSize)
        {
            int[] arr1 = new int[randSize];
            Random random = new Random();
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = random.Next(randMin, randMax);
            }
            return arr1;
        }

        public static void SortAlgoBubblesort(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int tmp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = tmp;
                    }
                }
            }
        }

        public static void PrintArrayWithIndex(int[] arr)
        {
            Console.Write("[");
            for (int i = 0; i < arr.Length; i++)
            {
                if (i > 0)
                {
                    Console.Write(", ");
                }
                Console.Write(arr[i]);
            }
            Console.WriteLine("]");
        }
    }
}
