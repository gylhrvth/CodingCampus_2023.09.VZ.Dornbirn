using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dimitri.Week03.Array;

namespace Dimitri.Week04
{
    internal class Sort
    {
        public static void Main()
        {
            int[] arr = RandomNumberArray(10, -100, 100);
            Console.WriteLine("Sorted Array ascending: ");
            BubbleSortAsc(arr);
            PrintArrayToStringForI(arr);

            arr = RandomNumberArray(20, 0, 100);
            Console.WriteLine("Sorted Array descending: ");
            BubbleSortDsc(arr);
            PrintArrayToStringForI(arr);

            arr = RandomNumberArray(20, 0, 100);
            Console.WriteLine("Sorted Array ascending with switch: ");
            BubbleSortSwitch(arr, true);
            PrintArrayToStringForI(arr);

            arr = RandomNumberArray(20, 0, 100);
            Console.WriteLine("Sorted Array descending with switch: ");
            BubbleSortSwitch(arr, false);
            PrintArrayToStringForI(arr);

            int size = 10;
            arr = RandomNumberArray(size, 0, 100);
            Console.WriteLine("Merge Sorted array:");
            MergeSort(arr, 0, size);
            PrintArrayToStringForI(arr);

        }

        public static void BubbleSortAsc(int[] arr)
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

        public static void BubbleSortDsc(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

        }

        public static void BubbleSortSwitch(int[] arr, bool asc)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1] && asc == true)
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                    else if (arr[j] < arr[j + 1] && asc == false)
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }

                }
            }

        }


        public static void MergeSort(int[] arr, int lo, int hi)
        {
            if (hi - lo <= 1) { return; }

            int mid = (hi + lo) / 2;

            int[] arrLow = new int[mid - lo];
            int[] arrHigh = new int[hi - mid];


            MergeSort(arrLow, lo, mid);
            MergeSort(arrHigh, mid, hi);

            int[] tmpArr = new int[hi - lo];



        }
    }
}
