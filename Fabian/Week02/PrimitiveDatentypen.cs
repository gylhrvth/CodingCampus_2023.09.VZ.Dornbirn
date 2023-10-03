namespace Fabian.Week02
{
    public class PrimitiveDatentypen
    {
        public static void Start()
        {
            PrintSum(20, 50);
            Console.WriteLine();
            PrintFactorial(1, 20);
            Console.WriteLine();
            PrintDecimalNums(0, 100);
            Console.WriteLine();
            PrintDivideAndConquer();
            Console.WriteLine();
            PrintCalculatePiLeibniz();
            Console.WriteLine();
        }

        public static void PrintSum(int minNum, int maxNum)
        {
            for (int i = minNum; i <= maxNum; i++)
            {
                Console.WriteLine($" {i} + {i} = {i + i}");
            }
        }

        public static void PrintFactorial(int minNum, int maxNum)
        {
            long fac = 1;
            for (int i = minNum; i <= maxNum; i++)
            {
                fac *= i;

                Console.WriteLine($"{i,2}! = {fac,20}");

            }
        }

        public static void PrintDecimalNums(float minNum, float maxNum)
        {
            for (float i = minNum; i <= maxNum; i += 0.1f)
            {

                Console.WriteLine($"Result 1 digit = {i,-3:N1}");
                Console.WriteLine($"Result 2 digit = {i,9:N2}");
            }
        }

        public static void PrintDivideAndConquer()
        {
            for (int x = 0; x <= 20; x++)
            {
                Console.WriteLine($"{x} / 5 = {x / 5,3}");
                Console.WriteLine($"{x} / 5.0 = {x / 5.0,0}");
            }
            Console.WriteLine("if you divide by a 5.0 it converts the int to a double");
        }

        public static void PrintCalculatePiLeibniz()
        {
            double pi = 1;

            for (int k = 0; k <= 20; k++)
            {

                for (double i = 1; i <= 20; i += 2)
                {
                    pi = pi + (4 / i);
                    Console.WriteLine($"𝜋 = {pi}");
                }

                for (int j = 3;  j <= 20; j++)
                {
                    pi = pi - (4 / j);
                    Console.WriteLine($"\u03A0r^2 = {pi}");
                }

            }
        }

        public static void PrintCalculatePiNilakantha()
        {
            double pi;


        }
    }
}
