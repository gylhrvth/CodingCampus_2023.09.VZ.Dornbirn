namespace DarioLuis.Week04
{


    class Fibonacciv1
    {
        public static int Fibonacci(int X)
        {
            if (X == 1 || X == 2)
            {
                return 1;
            }
            else
            {
                return Fibonacci(X - 1) + Fibonacci(X - 2);
            }
        }

        public static void Start()
        {


            int X = 10;
            if (X <= 0)
            {
                Console.WriteLine("Gib bitte eine größere Zahl wie 0 ein!!");
            }
            else
            {
                int result = Fibonacci(X);
                Console.WriteLine("Die " + X + ". Fibonacci-Zahl ist: " + result);
            }

        }
    }
}
