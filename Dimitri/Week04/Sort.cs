﻿using System;
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
            //int[] arr = RandomNumberArray(10, -100, 100);
            //Console.WriteLine("Sorted Array ascending: ");
            //BubbleSortAsc(arr);
            //PrintArrayToStringForI(arr);

            //arr = RandomNumberArray(20, 0, 100);
            //Console.WriteLine("Sorted Array descending: ");
            //BubbleSortDsc(arr);
            //PrintArrayToStringForI(arr);

            //arr = RandomNumberArray(20, 0, 100);
            //Console.WriteLine("Sorted Array ascending with switch: ");
            //BubbleSortSwitch(arr, true);
            //PrintArrayToStringForI(arr);

            //arr = RandomNumberArray(20, 0, 100);
            //Console.WriteLine("Sorted Array descending with switch: ");
            //BubbleSortSwitch(arr, false);
            //PrintArrayToStringForI(arr);

            //int size = 10;
            //int[] arr = RandomNumberArray(size, 0, 100);
            //PrintArrayToStringForI(arr);

            //int[] result = MergeSort(arr, 0, arr.Length);
            //Console.WriteLine("Merge Sorted array:");
            //PrintArrayToStringForI(result);

            //int [] arr = RandomNumberArray(5, 0, 10);
            //Console.WriteLine("cocktailshaker sort:");
            //int [] result = CocktailshakerSort(arr);
            //PrintArrayToStringForI(result);

            int[] arr = RandomNumberArray(5, 0, 10);
            Console.WriteLine("My Array:");
            PrintArrayToStringForI(arr);
            int[] result = HeapSort(arr);
            Console.WriteLine("Sorted Array with HeapSort:");
            PrintArrayToStringForI(result);

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

        //public static void MergeSort(int[] arr)
        //{


        //    MergeSort();
        //    MergeSort();

        //}


        public static int[] MergeSort(int[] arr, int lo, int hi)
        {
            int[] B = new int[hi - lo];

            if (hi - lo == 1)
            {
                B[0] = arr[lo];
                return B;
            }


            int mid = (hi + lo) / 2;

            int[] arrLeft = MergeSort(arr, lo, mid);
            int[] arrRight = MergeSort(arr, mid, hi);


            int i = 0;
            int j = 0;
            int k = 0;
            while (i < arrLeft.Length && j < arrRight.Length)
            {
                if (arrLeft[i] < arrRight[j])
                {

                    B[k] = arrLeft[i];
                    ++k;
                    ++i;
                }
                else
                {

                    B[k] = arrRight[j];
                    ++k;
                    ++j;
                }
            }

            while (i < arrLeft.Length)
            {

                B[k] = arrLeft[i];
                ++k;
                ++i;
            }

            while (j < arrRight.Length)
            {

                B[k] = arrRight[j];
                ++k;
                ++j;
            }

            return B;

        }

        public static int[] CocktailshakerSort(int[] arr)
        {
            int lo = 0;
            int hi = arr.Length - 1;
            int mov = lo;

            while (lo < hi)
            {
                for (int i = hi; i > lo; i--)
                {
                    if (arr[i - 1] > arr[i])
                    {
                        int temp = arr[i - 1];
                        arr[i - 1] = arr[i];
                        arr[i] = temp;
                        mov = i;
                    }
                }
                lo = mov;
                for (int i = lo; i < hi; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                        mov = i;
                    }
                }

                hi = mov;
            }

            return arr;
        }

        public static int[] HeapSort(int[] arr) 
        {
            BuildHeap(arr);
            int n = arr.Length - 1;
            while(n > 0)
            {
                int temp = arr[0];
                arr[0] = arr[n];
                arr[n] = temp;
                n -= 1;
                SiftDown(arr, 0, n);
            }
            return arr;
        }

        private static int[] BuildHeap(int[] arr)
        {
            for(int i = (arr.Length - 1)/2; i >= 0; i--)
            {
                SiftDown(arr, i, arr.Length - 1);
            }
            return arr;
        }

        private static int[] SiftDown(int[] arr, int i, int n)
        {
            if (2 * i >= n)
            {
                return arr;
            }

            int k = 2 * i;
            if (2 * i + 1 < arr.Length && arr[2*i] <= arr[2*i + 1])
            {
                k += 1;
            }
            if (arr[i] < arr[k])
            {
                int tmp = arr[i];
                arr[i] = arr[k];
                arr[k] = tmp;
                SiftDown(arr, k, n);
            }

            return arr;
        }
    }
}
