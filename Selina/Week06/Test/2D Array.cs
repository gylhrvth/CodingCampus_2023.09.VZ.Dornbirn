namespace Selina.Week06.Test
{
    public class _2D_Array
    {
        public static void Start()
        {
            int [,] arr = FillArray(20);
            CreateRandomArray(arr, 100, 10);
            PrintArray(arr);
        }
        public static int[,] FillArray(int size)
        {
            int[,] newArray = new int[size, size];
            for (int i = 0; i < size; i++)
            {
                newArray[i, i] = i + 1;
            }
            return newArray;
        }
        public static int[,] CreateRandomArray(int[,] randomArray, int from, int to)
        {
            Random rand = new Random();
            for (int i = 0; i < randomArray.Length; i++)
            {
                randomArray[i,i] = rand.Next(from, to);
            }
            return randomArray;
        }
        public static void PrintArray(int[,] arr)
        {
            for (int row = 0; row < arr.GetLength(0); row++)
            {
                for (int col = 0; col < arr.GetLength(1); col++)
                {
                    Console.Write($"{arr[row, col],-4}   ");
                }
                Console.WriteLine();
            }
        }
    }
}
