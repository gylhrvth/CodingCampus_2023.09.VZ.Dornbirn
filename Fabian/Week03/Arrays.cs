namespace Fabian.Week03
{
    public class Arrays
    {
        public static Random rand = new Random(123);
        public static int[] arr = RandomNumberArrayMinMaxAvg();

        public static void Start()
        {
            //Console.WriteLine("[{0}]", string.Join(", ", CreateNumberArray(10)));
            //Console.WriteLine("[{0}]", string.Join(", ", NumberArrayReversed()));
            //int[] originial = { 1, 2, 3, 4 };
            //Console.WriteLine("[{0}]", string.Join(", ", MakeACopy(originial)));
            //RandomNumberArray(10);
            //PrintRandomNumberArrayEverySecond();
            //PrintRandomNumberArray2();
            //PrintRandomNumberArrayEverySecond();
            //PrintRandomNumberArrayCrazyRange();
            //Console.WriteLine(RandomNumberArrayCount(arr));
            //Console.WriteLine("sum of array = " + RandomNumberArraySum());

            //task Random Number Array Min/Max/Avg:
            /*
            Console.WriteLine("[{0}]", string.Join(", ", arr));
            Console.WriteLine("smallest number = " + RandomNumberArrayMin(arr));
            Console.WriteLine("index of smallest number = " + IndexOfRandomNumberArrayMin(arr));
            Console.WriteLine("biggest number = " + RandomNumberArrayMax(arr));
            Console.WriteLine("index of biggest number = " + IndexOfRandomNumberArrayMax(arr));
            Console.WriteLine("average = " + RandomNumberArrayAvg(arr));*/

            int[] arr1 = MakeACopy(arr);
            //BubbleSortASC(arr1);
            //Console.WriteLine("[{0}]", string.Join(", ", arr1));
            int[] arr2 = MakeACopy(arr);
            //BubbleSortDESC(arr2);
            //Console.WriteLine("[{0}]", string.Join(", ", arr2));
            int[] arr3 = MakeACopy(arr);
            //SelectionSort(arr3);
            //Console.WriteLine("[{0}]", string.Join(", ", arr3));
            int[] arr4 = MakeACopy(arr);
            //InsertionSort(arr4);
            //Console.WriteLine("[{0}]", string.Join(", ", arr4));
            int[] arr5 = MakeACopy(arr);
            //GnomeSort(arr5);
            //Console.WriteLine("[{0}]", string.Join(", ", arr5));

            /*int[,] twoDarray = CreateRandomMultiDimensionalArray(4, 3);
            Print2DArray(twoDarray);
            Console.WriteLine("sum of columns = [{0}]", string.Join(", ", SumByColumn(twoDarray)));
            Console.WriteLine("sum of rows = [{0}]", string.Join(", ", SumByRow(twoDarray)));*/

            int[,] pascal = CreatePascalTriangle(10);
            PrintPascalTriangle(pascal);
        }
        public static int[] CreateNumberArray(int size)
        {
            int[] nums = new int[size];

            for (int i = 0; i < size; i++)
            {
                nums[i] = i + 1;
            }
            return nums;
        }

        public static int[] NumberArrayReversed()
        {
            int[] numsReversed = new int[10];

            for (int i = 0; i < numsReversed.Length; i++)
            {
                numsReversed[i] = numsReversed.Length - i;
            }
            return numsReversed;
        }

        public static int[] MakeACopy(int[] original)
        {
            int[] copy = new int[original.Length];

            for (int i = 0; i < copy.Length; i++)
            {
                copy[i] = original[i];
            }
            return copy;
        }

        public static int[] RandomNumberArray()
        {
            int[] arr = new int[10];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(1, 100);
            }

            return arr;
        }
        public static int[] RandomNumberArrayFor()
        {
            int[] randomNums = new int[10];

            for (int i = 0; i < randomNums.Length; i++)
            {
                randomNums[i] = rand.Next(1, 100);
            }
            return randomNums;

        }
        public static void PrintRandomNumberArrayForEach()
        {
            foreach (int i in RandomNumberArray())
            {
                Console.WriteLine(i);
            }
        }

        public static void PrintRandomNumberArray2()
        {
            int[] arr = RandomNumberArray();

            Console.WriteLine($"\n2nd value = {arr[1]}");
            Console.WriteLine($"5th value = {arr[4]}");
            Console.WriteLine($"10th value = {arr[9]}");
        }
        public static void PrintRandomNumberArrayEverySecond()
        {
            int[] arr = RandomNumberArray();

            for (int i = 0; i < arr.Length - 1; i += 2)
            {
                Console.WriteLine(arr[i]);
            }

        }

        public static int[] RandomNumberArrayCrazyRange()
        {
            int[] randomNums = new int[10];

            for (int i = 0; i < randomNums.Length; i++)
            {
                randomNums[i] = rand.Next(-50, 50);
            }

            return randomNums;
        }

        public static void PrintRandomNumberArrayCrazyRange()
        {

            foreach (int i in RandomNumberArrayCrazyRange())
            {
                Console.WriteLine(i);
            }
        }

        public static int RandomNumberArrayCount(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 30)
                {
                    count++;
                }
            }
            return count;
        }

        public static int RandomNumberArraySum()
        {
            int[] randomNums = new int[10];
            int sum = 0;

            for (int i = 0; i < randomNums.Length; i++)
            {
                randomNums[i] = rand.Next(1, 100);
                sum += randomNums[i];
            }

            return sum;
        }

        public static int[] RandomNumberArrayMinMaxAvg()
        {
            int[] randomNums = new int[10];

            for (int i = 0; i < randomNums.Length; i++)
            {
                randomNums[i] = rand.Next(1, 100);
            }

            return randomNums;
        }

        public static int RandomNumberArrayMin(int[] arr)
        {
            return arr.Min();
        }

        public static int RandomNumberArrayMax(int[] arr)
        {
            return arr.Max();
        }

        public static double RandomNumberArrayAvg(int[] arr)
        {
            return arr.Average();
        }

        public static int IndexOfRandomNumberArrayMin(int[] arr)
        {
            int minIndex = Array.IndexOf(arr, RandomNumberArrayMin(arr));

            return minIndex;
        }

        public static int IndexOfRandomNumberArrayMax(int[] arr)
        {
            int maxIndex = Array.IndexOf(arr, RandomNumberArrayMax(arr));

            return maxIndex;
        }

        public static void BubbleSortASC(int[] arr)
        {

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        (arr[j + 1], arr[j]) = (arr[j], arr[j + 1]);
                    }
                }
            }
        }

        public static void BubbleSortDESC(int[] arr)
        {

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        (arr[j + 1], arr[j]) = (arr[j], arr[j + 1]);
                    }
                }
            }
        }

        public static void SelectionSort(int[] arr)
        {
            int min;
            for (int i = 0; i < arr.Length; i++)
            {
                min = i;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] > arr[min])
                    {
                        min = j;

                        (arr[min], arr[i]) = (arr[i], arr[min]);
                    }
                }
            }
        }

        public static void InsertionSort(int[] arr)
        {
            int j;
            for (int i = 0; i < arr.Length; i++)
            {
                j = i;
                while (j > 0 && arr[j - 1] > arr[j])
                {
                    (arr[j], arr[j - 1]) = (arr[j - 1], arr[j]);
                    j--;
                }
            }
        }

        public static void GnomeSort(int[] arr)
        {
            int i = 2;

            while (i < arr.Length)
            {
                if (arr[i] >= arr[i - 1])
                {
                    i++;
                }
                else
                {
                    (arr[i], arr[i - 1]) = (arr[i - 1], arr[i]);

                    if (i >= 2)
                    {
                        i--;
                    }
                }
            }
        }

        public static int[,] CreateRandomMultiDimensionalArray(int height, int width)
        {
            int[,] arr = new int[height, width];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rand.Next(100);
                }
            }
            return arr;
        }

        public static void Print2DArray(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write("{0} ", arr[i, j]);
                }
                Console.WriteLine();
            }
        }

        public static int[] SumByColumn(int[,] arr)
        {
            int[] sum = new int[arr.GetLength(1)];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    sum[j] += arr[i, j];
                }
            }

            return sum;
        }

        public static int[] SumByRow(int[,] arr)
        {
            int[] sum = new int[arr.GetLength(0)];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    sum[i] += arr[i, j];
                }
            }

            return sum;
        }

        public static int[,] CreatePascalTriangle(int size)
        {
            int[,] arr = new int[size, size];
            int sum;

            for (int i = 1; i < size; i++)
            {
                for (int j = 1; j < size; j++)
                {
                    sum = arr[i, j - 1] + arr[i - 1, j];
                    arr[i, j] = sum;
                }
            }

            return arr;
        }
        public static void PrintPascalTriangle(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write("{0} ", arr[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
