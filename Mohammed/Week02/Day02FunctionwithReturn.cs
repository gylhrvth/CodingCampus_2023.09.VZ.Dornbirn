using System;
namespace Mohammed.Week02
{
    public class Day02
    {
        public static void Day02start()
        {

            //ADD
            //Console.WriteLine(Add(3, 2));
            int c = Add();
            //Console.WriteLine(c);

            //LONG
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine("{0,2}! = {1,20}", i, Factorialcalculus(i));
            }

            //long a = Factorialcalculus2();
            //Console.WriteLine(a);
            Factorialcalculus2();

            
        }



        public static int Add()
        {
            int result = 0;

            for (int i = 20; i <= 50; i++)
            {
                result += i;
            }
            return result;

        }

        public static long Factorialcalculus(int n)
        {
            long solution = 1;

            for (int i = 1; i <= n; i++)
            {
                solution *= i;
            }
            return solution;


        }

        public static void Factorialcalculus2()
        {
            decimal sum = 0.0m;

            for(int i=0; i <= 100; i++)
            {
                sum += 0.1m;
                Console.WriteLine(String.Format("{0:0.00}", sum));
                Console.WriteLine(String.Format("{0:0.0}", sum));
            }
            string[,] matrix = new string[17, 10];
            for(int i=0; i<10;i++)
            {
                for(int j=0;j<17;j++)
                {
                    if (j == 9 && i == 0)
                    {
                        matrix[i, j] = "*";
                    } else
                    {

                    }
                }
            }

            var x = 0;

            if (x == 1)
            {
                Console.WriteLine("nicht 0");
            } else
            {
                Console.WriteLine("0");
            }
 
        }
    }
}

