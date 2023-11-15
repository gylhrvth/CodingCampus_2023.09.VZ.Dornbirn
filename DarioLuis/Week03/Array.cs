namespace DarioLuis.Week03
{
    public class Arrays
    {
        public static Random rand = new Random();

        public int[]? array { get; set; }

        public static void StartArrayExample()
        {


            /*Console.WriteLine("[{0}]", string.Join(", ", CreateArray(10)));

            //============================================
            Console.WriteLine("[{0}]", string.Join(", ", CrazyRangeArray(10)));

            //============================================
            int[] fixArray = { 5, 3, 12, -4, 0, 9, 6, 2 };
            Console.WriteLine("[{0}]", string.Join(", ", fixArray));

            Console.WriteLine("======================");

            //============================================
            int[] myArray = CreateArray(10);
            Console.WriteLine("[{0}]", string.Join(", ", myArray));

            Console.WriteLine("======================");


            for (int i = 0; i < myArray.Length; i++)
            {
                int value = myArray[i];
                Console.WriteLine("myArray[{0}] = {1}", i, value);
            }
            Console.WriteLine("======================");

            foreach (int value in myArray)
            {
                Console.WriteLine("... {0}", value);
            }
            Console.WriteLine("======================");

            SortArray();*/

            int[,] arr = CreatePascalTriangle(10);
            PrintPascalTriangle(arr);
        }
        public static int[] CreateArray(int size)
        {
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(100);
            }
            return arr;
        }
        public static int[] CrazyRangeArray(int size)
        {
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(-50, 50);
            }

            return arr;
        }

        public static void SortArray()
        {

            int[] array = new int[] { 73, 57, 49, 99, 133, 20, 1 };
            int n = array.Length;

            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (array[j] > array[j + 1])
                    {
                        (array[j + 1], array[j]) = (array[j], array[j + 1]);
                    }
            Console.WriteLine("[{0}]", string.Join(", ", array));
        }

        public static int[,] CreatePascalTriangle(int size = 0)
        {
            while (size < 1)
            {
                try
                {
                    Console.WriteLine("Enter the size: ");
                    size = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Enter a valid number!!");
                }
            }
            int[,] arr = new int[size, size];
            int sum;

            for (int i = 1; i < size; i++)
            {
                arr[0, 0] = 1;
                arr[i, 0] = 1;
                for (int j = 1; j < size; j++)
                {
                    arr[0, j] = 1;
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
                    Console.Write("{0, 10}", arr[i, j]);
                }
                Console.WriteLine();
            }
        }
        public static int ArraySum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }
            return sum;
        }

    }
}





