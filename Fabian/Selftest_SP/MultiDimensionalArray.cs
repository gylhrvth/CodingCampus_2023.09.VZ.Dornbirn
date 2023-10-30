namespace Fabian.Selftest_SP
{
    public class MultiDimensionalArray
    {
        public static void Start()
        {
            int[][] arr = Create2DArray(10, 10);
            Fill2DArray(arr);
            Print2DArray(arr);
        }

        public static int[][] Create2DArray(int height, int width)
        {
            int[][] arr = new int[height][];

            for (int i = 0; i < height; i++)
            {
                arr[i] = new int[width];
            }
            return arr;
        }
        public static int[][] Fill2DArray(int[][] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = count++;
                }
            }
            return arr;
        }
        public static void Print2DArray(int[][] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write("{0, -10}", arr[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}
