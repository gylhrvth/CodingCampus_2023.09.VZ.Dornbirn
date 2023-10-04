using System;
using System.Net.Sockets;

namespace Fabienne.week02
{


    public class Primitiven_Datentypen
    {
        public static void StartPrimitivenDatentypen()
        {
            
            PrintSum();
            Console.WriteLine();
            Faktorial(20);
        }

        public static void PrintSum()
        {
            int result = 0;

            for (int i = 20; i <= 50; i++)
            {
                result += i;
                Console.WriteLine(result);
            }

            Console.WriteLine();
        }

        public static void Faktorial(long number)
        {
            long result = 1;

            for (int i = 1; i <= number; i++)
            {
                result = result * i;

                Console.WriteLine("{0, -2}! = {1, 20} ",i,result) ;
            }
        }

        public class funktionWithReturn //was gyula vorgezeigt hat
        {
            public static void Start()
            {
                Console.WriteLine(Add(3, 22));

                int c = Add(5, 4);

                Console.WriteLine(c);
            }

            public static int Add(int a, int b)
            {
                int result = a + b;

                return result;
            }
        }
    }

    
}

