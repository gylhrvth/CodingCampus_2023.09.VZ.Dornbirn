﻿using static Gheorghe.Week03.Arrays03;

namespace Gheorghe.Week04
{
    internal class SortingAlgorithm
    {

        public static void Start()
        {

            Console.WriteLine("Absteigend");
            int[] arr = CrazyRangeArray(10);

            Console.WriteLine("Unsorted");
            PrintCrazyRangeArry(arr);

            Console.WriteLine();


            Console.WriteLine("Sorted:");
            BubbleSort(arr);
            PrintCrazyRangeArry(arr);


            Console.WriteLine();


            Console.WriteLine("Aufsteigend");
            Console.WriteLine("Unsorted");
            PrintCrazyRangeArry(arr);


            Console.WriteLine();


            Console.WriteLine("Sorted:");
            BubbleSortDesc(arr);
            PrintCrazyRangeArry(arr);





        }



        public static void BubbleSortDesc(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        public static void BubbleSort(int[] arra)
        {
            for (int i = 0; i < arra.Length; i++)
            {
                for (int j = 0; j < arra.Length - i - 1; j++)
                {
                    if (arra[j] < arra[j + 1])
                    {
                        int temp = arra[j];
                        arra[j] = arra[j + 1];
                        arra[j + 1] = temp;
                    }
                }
            }
        }
    }
}
