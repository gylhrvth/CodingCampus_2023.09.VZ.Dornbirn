using System;
namespace Mohammed.Week04
{
    public class day02
    {
        public static void Start()
        {

            Console.WriteLine("RekursiveSum");
            int sum = RekursiveSum(5);
            Console.WriteLine("Die Rekursive Summe ist " + sum);


            Console.WriteLine("RekursiveFakt");
            long fakt = RekursiveFakt(55);
            Console.WriteLine("Die Rekursive fakt ist " + fakt);


            Console.WriteLine("Fibonacci");
            int fib = Fib(7);
            Console.WriteLine("Die fibonacci ist " + fib);


            Console.WriteLine("pascal Dreieck");
            PascalTriangle(10);



        }


        public static int RekursiveSum(int x)
        {
            if (x == 0)
            {
                return 0;
            }
            return x + RekursiveSum(x - 1);

        }

        public static long RekursiveFakt(int x)
        {
            if (x == 1)
            {
                return 1;
            }
            return x * RekursiveFakt(x - 1);
        }

        public static int Fib(int x)
        {
            if (x == 1 || x == 2)
            {
                return 1;
            }
            return Fib(x - 1) + Fib(x - 2);

        }




        //Frage stellen warum es nicht geht, hat mit methode aufrufen zum tun!! methoden aufrfufen wieder holen.

        public static int[] PascalTriangle(int x)
        {
            int[] triangle = new int[x];

            triangle[0] = 1;
            triangle[x - 1] = 1;

            for (int i = 1; i < x - 1; i++)
            {
                triangle[i] = triangle[i - 1] + triangle[i];
            }

            return triangle;
        }


    }
}

