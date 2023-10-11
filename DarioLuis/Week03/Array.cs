namespace DarioLuis.Week03
{
    public class Array
    {
        public static Random rand = new Random();


        public static void StartArrayExample()
        {
            int[] fixArray = { 5, 3, 12, -4, 0, 9, 6, 2 };
            Console.WriteLine("[{0}]", string.Join(", ", fixArray));

            Console.WriteLine("======================");

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
        
    }
}





