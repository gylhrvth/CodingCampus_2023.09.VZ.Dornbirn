using System;
using System.Reflection.Metadata;

namespace Erik.Week03
{
    public class SortAlgorithmBubblesortDecrease
    {
        public static void StartSortAlgorithm()
        {
            Console.WriteLine("Press F to start the program!");
            while (true)
            {
                var userInput = Console.ReadKey();
                if (userInput.Key == ConsoleKey.F)
                {
                    Console.WriteLine("\n");
                    break;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid input! \nPress F to start the program!");
                }
            }
            int[] arr = NumbersOutput(0, 100, 20);
            Console.WriteLine("Unsorted numbers:");
            PrintArrayWithIndex(arr);
            Console.WriteLine();
            Console.WriteLine("< " + "for increasing sort or" + " >" + " for decreasing sort");
            Console.Write("Your input (press enter): ");
            String userDecision = Console.ReadLine();

            while (true)
            {
                if (userDecision == "<")
                {
                    Console.WriteLine("Sorted numbers increasing:");
                    SortAlgoBubblesortIncrease(arr);
                    PrintArrayWithIndex(arr);
                    break;
                }
                else if (userDecision == ">")
                {
                    Console.WriteLine("Sorted numbers decreasing:");
                    SortAlgoBubblesortDecrease(arr);
                    PrintArrayWithIndex(arr);
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input!\n");
                    Console.Write("Your input: ");
                    String NewUserDecision = Console.ReadLine();
                    userDecision = NewUserDecision;
                }
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
