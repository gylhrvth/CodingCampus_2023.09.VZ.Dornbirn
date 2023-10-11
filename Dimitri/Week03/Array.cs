using System;

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
            PrintArray((BubbleSortAsc(RandomNumberArray(0, 100))));
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
                Console.WriteLine(arr[i]);
            }
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
            Random random = new Random();


            for (int i = 0; i < (upper - lower); i++)
            {
                arr[i] = random.Next(lower, upper);
            }

            return arr;
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
            int[] arrAsc = new int[arr.Length];

            for (int i = 0; i < arr.Length * arr.Length; i++)
            {
                for (int j = 0; j < arrAsc.Length; j++)
                {
                    int a = arr[j];
                    int b = arr[j + 1];
                    if (a > b)
                    {
                        arrAsc[j + 1] = a;
                        arrAsc[j] = b;
                    } else
                    {
                        arrAsc[j] = a;
                        arrAsc[j + 1] = b;
                    }

                }

            }

            return arrAsc;
        }

        //public static void BubbleSortDesc(int[] arr)
        //{

        //}
    }
}
