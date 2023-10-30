namespace Fabian.Selftest_SP
{
    public class Loops
    {
        public static void Start()
        {
            //CountBackwards(10, 0);
            //Count(-30, 30);
            CountWithNewLine(0, 10);

        }
        public static void CountBackwards(int start, int end)
        {
            for (int i = start; i >= end; i--)
            {
                Console.Write(i + " ");
            }
        }
        public static void Count(int start, int end)
        {
            for(int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
        }
        public static void CountWithNewLine(int start, int end)
        {
            while (start <= end)
            {
                if(start > 5)
                {
                    Console.WriteLine();
                }
                Console.WriteLine(start++);
            }
        }
    }
}
