using System;


namespace Erik.Week03
{
    public class SortAlgorithmBubblesortDecrease
    {
        public static void StartSortAlgorithm()
        {
            int[] arr = NumbersOutput(0, 100, 20);
            Console.WriteLine("Unsorted numbers:");
            PrintArrayWithIndex(arr);
            Console.WriteLine();
            Console.WriteLine("< " + "for increasing sort /" + " >" + " for decreasing sort");
            Console.Write("Your Input: ");
            String userDecision = Console.ReadLine();



            if (userDecision == "<")
            {
                Console.WriteLine("Sorted numbers increasing:");
                SortAlgoBubblesortIncrease(arr);
                PrintArrayWithIndex(arr);
            }
            else if (userDecision == ">")
            {
                Console.WriteLine("Sorted numbers decreasing:");
                SortAlgoBubblesortDecrease(arr);
                PrintArrayWithIndex(arr);
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
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


        public static void SortAlgoBubblesortIncrease(int[] arr)
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

        public static void SortAlgoBubblesortDecrease(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (arr[j] < arr[j + 1])
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
