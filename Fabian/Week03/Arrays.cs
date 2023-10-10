namespace Fabian.Week03
{
    public class Arrays
    {
        public static Random rand = new Random(1234);
        public static int[] arr = RandomNumberArrayMinMaxAvg();

        public static void Start()
        {
            //NumberArray();
            /*int[] originial = { 1, 2, 3, 4 };
            MakeACopy(originial);*/
            //RandomNumberArray();
            //RandomNumberArrayCrazyRange();
            //PrintRandomNumberArrayCount();
            //Console.WriteLine("sum of array = " + RandomNumberArraySum());

            //task Random Number Array Min/Max/Avg:
            /*
            Console.WriteLine("[{0}]", string.Join(", ", arr));
            Console.WriteLine("smallest number = " + RandomNumberArrayMin(arr));
            Console.WriteLine("index of smallest number = " + IndexOfRandomNumberArrayMin(arr));
            Console.WriteLine("biggest number = " + RandomNumberArrayMax(arr));
            Console.WriteLine("index of biggest number = " + IndexOfRandomNumberArrayMax(arr));
            Console.WriteLine("average = " + RandomNumberArrayAvg(arr));*/

            //BubbleSortASC(arr);
            //BubbleSortDESC(arr);
            SelectionSort(arr);




        }
        public static void NumberArray()
        {
            int[] nums = new int[10];
            int[] numsReversed = new int[10];

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = i;
                numsReversed[i] = numsReversed.Length - 1 - i;
            }
            Console.WriteLine("[{0}]", string.Join(", ", nums));
            Console.WriteLine("[{0}]", string.Join(", ", numsReversed));
            Console.WriteLine();
        }

        public static int[] MakeACopy(int[] original)
        {
            int[] copy = new int[original.Length];

            for (int i = 0; i < copy.Length; i++)
            {
                copy[i] = original[i];
                Console.WriteLine(copy[i]);
            }
            return copy;
        }

        public static void RandomNumberArray()
        {
            int[] randomNums = new int[10];

            Console.WriteLine("array in foreach loop: ");
            foreach (int i in randomNums)
            {
                randomNums[i] = rand.Next(1, 100);
                Console.WriteLine(randomNums[i]);
            }
            Console.WriteLine("\narray in for loop with string.Join: ");
            for (int i = 0; i < randomNums.Length; i++)
            {
                randomNums[i] = rand.Next(1, 100);
            }
            Console.WriteLine("[{0}]", string.Join(", ", randomNums));

            Console.WriteLine($"\n2nd value = {randomNums[1]}");
            Console.WriteLine($"5th value = {randomNums[4]}");
            Console.WriteLine($"10th value = {randomNums[9]}\n");

            Console.WriteLine("every second value: ");
            for (int i = 0; i < randomNums.Length - 1; i += 2)
            {
                Console.WriteLine($"{i} = {randomNums[i]}");
            }
        }

        public static void RandomNumberArrayCrazyRange()
        {
            int[] randomNums = new int[10];

            foreach (int i in randomNums)
            {
                randomNums[i] = rand.Next(-50, 50);
                Console.WriteLine(randomNums[i]);
            }
        }

        public static int[] RandomNumberArrayCount()
        {
            int[] randomNums = new int[10];

            for (int i = 0; i < randomNums.Length; i++)
            {
                randomNums[i] = rand.Next(1, 100);

                if (randomNums[i] < 30)
                {
                    randomNums[i] = 0;
                }
            }
            return randomNums;
        }

        public static void PrintRandomNumberArrayCount()
        {
            Console.WriteLine("[{0}]", string.Join(", ", RandomNumberArrayCount()));
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
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp; 
                    }
                }
            }
            Console.WriteLine("[{0}]", string.Join(", ", arr));
        }

        public static void BubbleSortDESC(int[] arr)
        {

            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("[{0}]", string.Join(", ", arr));
        }

        public static void SelectionSort(int[] arr)
        {
            int min;
            for (int i = 0; i < arr.Length; i++)
            {
                min = arr[i];
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j] < min)
                    {
                        min = arr[j];      
                    }
                }
            }
            Console.WriteLine("[{0}]", string.Join(", ", arr));
        }
        
    }
}
