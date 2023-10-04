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
            Console.WriteLine(c);

            //LONG
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine("{0,2}! = {1,20}", i, Factorialcalculus(i));
            }

            long a = Factorialcalculus2();
            //Console.WriteLine(a);

            
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

        public static long Factorialcalculus2()
        {
            long solution = 1;

            for (int a = 1; a <= 20; a++)
            {
                solution *= a;
            }
            return solution;
        }


        
        


    }
}

