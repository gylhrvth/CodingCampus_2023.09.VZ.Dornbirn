namespace Fabian.Week02
{
    public class PrimitiveDatentypen
    {
        public static void Start()
        {
            //Console.WriteLine("The sum is = " + CalcSum(20, 50));
            //PrintFactorial(20);
            //PrintDecimalNums(0, 100);
            //PrintDivideAndConquer();

            //Console.WriteLine("Pi is around {0}", CalculatePiLeibniz());
            //Console.WriteLine("Pi is around {0}", CalculatePiNilakantha());
            //Console.WriteLine(CalcSecretRow());
            //Console.WriteLine("Root i around {0}", CalcRootApproximation()); 
            Console.WriteLine("Root is around {0}", CalcRootApproximationBonus()); 

        }

        public static int CalcSum(int minNum, int maxNum)
        {
            int sum = 0;
            for (int i = minNum; i <= maxNum; i++)
            {
                sum += i;
            }
            return sum;

        }

        public static void PrintFactorial(int maxNum)
        {
            for (int i = 1; i <= maxNum; i++)
            {
                Console.WriteLine("{0,2}! = {1,20}", i, CalcFactorial(i));
            }
        }

        public static long CalcFactorial(int maxNum)
        {
            long fac = 1;
            for (int i = 1; i <= maxNum; i++)
            {
                fac *= i;
            }
            return fac;
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
            for (double x = 0; x <= 20; x++)
            {
                Console.WriteLine($"{x,2} / 5 = {x / 5, 5}");
                Console.WriteLine($"{x,2} / 5.0 = {x / 5.0, 3}");
            }
        }


        public static double CalculatePiLeibniz()
        {
            double pi = 0;

            for (double i = 1; i <= 30000; i += 2)
            {
                pi += 4 / i;
                Console.WriteLine($"pi = {pi}");
                pi *= -1;
            }
            return pi;
        }

        public static double CalculatePiNilakantha()
        {
            double pi = 3;

            for (double i = 2; i <= 100; i += 2)
            {
                pi += 4 / (i * (i + 1) * (i + 2));
                Console.WriteLine($"pi = {pi}");
                pi *= -1;
            }
            return pi;
        }

        public static double CalcSecretRow()
        {
            double value = 1;

            for(double i = 0; i < 10; i++)
            {
                value = value / 2 + 1 / value;
                Console.WriteLine($"{value}");
            }
            return value;
        }

        public static double CalcRootApproximation()
        {
            double random = new Random().Next(10000) + 1;
            double max = random;
            double min = 0;
            double average = 0;

            for (int i = 0; i < 100; i++)
            {
                average = (max + min) / 2;
                if (Math.Pow(average, 2) > random)
                {
                    max = average;
                }
                else if (Math.Pow(average, 2) == random)
                {
                    break;
                }
                else
                {
                    min = average;
                    Console.WriteLine(average);
                }
            }
            return average;
        }

        public static double CalcRootApproximationBonus()
        {
            double num = 1297419;
            double max = num;
            double min = 0;
            double average = 0 ;
            double error = 1;
            int tries = 0;

            for (int i = 0; error > 0.1; i++)
            {
                average = (max + min) / 2;
                error = Math.Abs(average / num * 100);
                if (Math.Pow(average, 2) > num)
                {
                    max = average;
                }
                else
                {
                    min = average;
                }
                tries++;
                Console.WriteLine($"{average,-20} error percentage = {error:N4}%");
            }
            Console.WriteLine($"it took {tries} tries");
            return average;
        }
    }
}
