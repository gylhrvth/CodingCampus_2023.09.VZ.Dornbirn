using System;
using System.Runtime.InteropServices;

namespace Dimitri.Week03
{
    internal class Array
    {
        public static void Main()
        {
            //Console.WriteLine("Increasing");
            //PrintArray(IncreaseNumberArray(5));
            //Console.WriteLine("COPY");
            //PrintArray(CopyArray(IncreaseNumberArray(5)));
            //Console.WriteLine("Decreasing");
            //PrintArray(DecreaseNumberArray(5));
            //Console.WriteLine("COPY");
            //PrintArray(CopyArray(DecreaseNumberArray(5)));
            //Console.WriteLine("print random array");
            //PrintArray(RandomNumberArray(-50, 50));
            //Console.WriteLine(CreateNumberArray(10));
            //CreateNumberArrayVerkehrt(7);
            //int[] lustigesArray = { 1, 3, 5, 7, 9 };
            //Console.WriteLine MakeACopy(lustigesArray);
            //PrintArrayToString3(RandomNumberArray(0, 100));
            //PrintCrazyRangeArray(RandomNumberArray(-50, 50));
            //PrintArrayZaehlen(RandomNumberArray(1, 100), 30);
            //Console.WriteLine(ReturnArraySumme(RandomNumberArray(1, 100)));
            //Console.WriteLine(ReturnArrayMin(RandomNumberArray(-50, 50)));
            //Console.WriteLine(ReturnArrayMax(RandomNumberArray(-50, 50)));
            //Console.WriteLine(ReturnArrayAvg(RandomNumberArray(0, 100)));
            //Console.WriteLine(ReturnArrayMinIndex(RandomNumberArray(-50, 50)));
            //Console.WriteLine(ReturnArrayMaxIndex(RandomNumberArray(-50, 50)));
            //PrintArray(BubbleSortAsc(RandomNumberArray(0, 100)));
            //PrintArray(BubbleSortDesc(RandomNumberArray(0, 10)));
            //PrintArray(MergeSort(RandomNumberArray(0, 5)));
            //PrintArray(SelectionSort(RandomNumberArray(0, 10)));
            PrintArray(InsertionSort(RandomNumberArray(0, 10)));
        }

        public static int[] IncreaseNumberArray(int n)
        {
            int[] arr0 = new int[n];

            for (int i = 0; i < arr0.Length; i++)
            {
                arr0[i] = i + 1;
                //Console.WriteLine("{0}. = {1}", i, arr0[i]);
            }

            return arr0;
        }
        public static int[] DecreaseNumberArray(int n)
        {


            int[] arr1 = new int[n];


            for (int j = 0; j < arr1.Length; j++)
            {
                arr1[j] = arr1.Length - j;
            }
            //Console.WriteLine("{0}. = {1}", i, arr1[i]);


            return arr1;
        }

        public static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("{0}...{1}", i, arr[i]);
            }
            /* For some reason this only returns a 0 if you have an array with only one element */
        }

        public static int[] CopyArray(int[] original)
        {

            int[] arrNew = new int[original.Length];

            for (int i = 0; i < arrNew.Length; i++)
            {
                arrNew[i] = original[i];
            }

            return arrNew;
        }

        public static int[] RandomNumberArray(int lower, int upper)
        {

            int[] arr = new int[(upper - lower)];
            if (lower == upper)
            {
                return arr;
            }
            else
            {
                Random random = new Random();


                for (int i = 0; i < (upper - lower); i++)
                {
                    arr[i] = random.Next(lower, upper);
                }

                return arr;
            }


        }

        public static void PrintArrayToString0(int[] arr)
        {
            Console.Write("[");

            //foreach (type variableName in arrayName) { }
            foreach (int i in arr)
            {
                if (i < arr.Length)
                {
                    Console.Write(arr[i] + ",");
                }
                else
                {
                    Console.Write(arr[i]);
                }
            }
            Console.Write("]");
        }
        public static void PrintArrayToString1(int[] arr)
        {
            Console.Write("[");
            for (int i = 0; i < arr.Length; i++)
            {

                if (i < arr.Length - 1)
                {
                    Console.Write(arr[i] + ",");
                }
                else
                {
                    Console.Write(arr[i]);
                }
            }
            Console.Write("]");
        }

        public static void PrintArrayToString2(int[] arr, int erster, int zweiter, int dritter)
        {
            Console.WriteLine("{0}, {1}, {2}", arr[1], arr[5], arr[10]);
        }

        public static void PrintArrayToString3(int[] arr)
        {
            Console.Write("[");
            for (int i = 0; i < arr.Length; i += 2)
            {

                if (i < arr.Length - 3)
                {
                    Console.Write(arr[i] + ",");
                }
                else
                {
                    Console.Write(arr[i]);
                }
            }
            Console.Write("]");
        }

        public static void PrintCrazyRangeArray(int[] arr)
        {

            //foreach (type variableName in arrayName) { }
            //foreach (int i in arr)
            //{
            //        Console.WriteLine(arr[i]);
            //}

            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
                count++;
            }
            Console.WriteLine("---------");
            Console.WriteLine(count);


        }
        public static void PrintArrayZaehlen(int[] arr, int from)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 30)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }

        public static int ReturnArraySumme(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            return sum;
        }

        public static int ReturnArrayMin(int[] arr)
        {
            int min = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {

                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }



            return min;
        }

        public static int ReturnArrayMax(int[] arr)
        {
            int max = arr[0];

            for (int i = 1; i < arr.Length; i++)
            {

                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }



            return max;
        }

        public static int ReturnArrayAvg(int[] arr)
        {

            int sum = ReturnArraySumme(arr);

            int avg = sum / arr.Length;

            return avg;
        }

        public static int ReturnArrayMinIndex(int[] arr)
        {
            int min = arr[0];
            int indexMin = 0;

            for (int i = 1; i < arr.Length; i++)
            {

                if (arr[i] < min)
                {
                    min = arr[i];
                    indexMin = i;
                }
            }

            return indexMin;
        }

        public static int ReturnArrayMaxIndex(int[] arr)
        {
            int max = arr[0];
            int indexMax = 0;

            for (int i = 1; i < arr.Length; i++)
            {

                if (arr[i] > max)
                {
                    max = arr[i];
                    indexMax = i;
                }
            }

            return indexMax;
        }

        public static int[] BubbleSortAsc(int[] arr)
        {

            for (int i = 0; i <= arr.Length * arr.Length; i++)
            {

                for (int j = 0; j < arr.Length - 1; j++)
                {
                    int a = arr[j];
                    int b = arr[j + 1];
                    if (a > b)
                    {
                        arr[j + 1] = a;
                        arr[j] = b;
                    }

                }

            }

            return arr;
        }

        public static int[] BubbleSortDesc(int[] arr)
        {
            for (int i = 0; i <= arr.Length * arr.Length; i++)
            {

                for (int j = 0; j < arr.Length - 1; j++)
                {
                    int a = arr[j];
                    int b = arr[j + 1];
                    if (a < b)
                    {
                        arr[j + 1] = a;
                        arr[j] = b;
                    }

                }

            }

            return arr;

        }

        //private static int[] MergeSort(int lo, int hi, int[] arr)
        //{
        //    int hi = ReturnArrayMaxIndex(arr);
        //    int lo = ReturnArrayMaxIndex(arr);

        //    if (hi - lo <= 1)
        //    {
        //        return arr;
        //    }

        //    int mid = (hi + lo) / 2;

        //    for (int i = 0; i )




        //        int indexMax = ReturnArrayMaxIndex(arr);

        //    int indexMin = ReturnArrayMinIndex(arr);

        //    if (indexMax - indexMin <= 1)
        //    {
        //        return arr;
        //    }
        //    else
        //    {
        //        int indexMid = (indexMax + indexMin) / 2;

        //        int[] tmpArr = arr;

        //        int i = indexMin;
        //        int j = indexMid;
        //        int k = 1;

        //        while (i < indexMid && j < indexMax)
        //        {


        //            if (arr[i] < arr[j])
        //            {
        //                tmpArr[k] = arr[i];
        //                i++;
        //                k++;
        //                j++;

        //            }
        //            else
        //            {
        //                tmpArr[k] = arr[j];
        //                i++;
        //                k++;
        //                j++;
        //            }

        //        }

        //        while (i < indexMid)
        //        {
        //            tmpArr[k++] = arr[i++];
        //            i++;
        //            k++;
        //        }

        //        while (j < indexMax)
        //        {
        //            tmpArr[k++] = arr[j++];
        //            j++;
        //            k++;
        //        }

        //        arr = tmpArr;

        //        return arr;
        //    }
        //}

        //public static int[] MergeSort(int[] arr)
        //{
        //    return MergeSort(0, arr.Length - 1, arr);
        //}

        //public static int[] QuickSort(int[] arr)
        //{

        //    return QuickSort(arr, left, mid - 1);
        //}

        //private static int[] QuickSort(int[] arr, int left, int right)
        //{
        //    if (left < right)
        //    {
        //        arr;
        //    }
        //    else
        //    {

        //    }

        //    return
        //}

        public static int[] SelectionSort(int[] arr)
        {
            int n = arr.Length;

            //int[] tempArr = new int[n];
            for (int i = 0; i < n; i++)
            {
                int min = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }

                }
                int a = arr[i];
                int b = arr[min];
                arr[min] = a;
                arr[i] = b;
            }

            return arr;
        }

        //public static int[] InsertionSort(int[] arr)
        //{
        //    int n = arr.Length;
        //    int[] tmpArr = CopyArray(arr);
        //    for (int k = 0; k < arr.Length - 1; k++)
        //    {
        //        int i = 0;
        //        int j = i + 1;
        //        while (i < n)
        //        {
        //            for (j = i + 1; j < n; j++)
        //            {
        //                if (arr[i] < arr[j])
        //                {
        //                    tmpArr[i] = arr[i];
        //                    i++;
        //                }
        //                else
        //                {
        //                    tmpArr[i] = arr[j];
        //                    i++;
        //                }
        //            }
        //            i++;

        //        }
        //    }

        //    return tmpArr;
        //}
        public static int[] InsertionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; i++)
            {
                int j = i;
                while (j > 0 && arr[j - 1] > arr[j])
                {
                    int a = arr[j];
                    int b = arr[j - 1];

                    arr[j] = b;
                    arr[j - 1] = a;

                    j--;
                }
            }

            return arr;
        }
    }

}
