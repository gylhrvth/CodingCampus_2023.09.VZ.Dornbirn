

using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

namespace Jovo.Week02
{
    public class Boolean
    {
        public static void Start()
        {
            int result = Add();
            Console.WriteLine("ergebniss " + result);
            Console.WriteLine("========================================");

            long result2 = Add2();
            Console.WriteLine("=========================================");

            int d1 = Zaehlen();
            Console.WriteLine("ergebniss" + d1);
            Console.WriteLine("==========================================");




            Console.WriteLine("");












        }




        public static void Summe()
        {
            int result = 0;
            for (int i = 20; i <= 50; i++) {
                result += i;
                Console.WriteLine(result);
            }
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


        public static long Add2()
        {


            long result = 1;
            for (long i = 1; i <= 20; i++)
            {

                result *= i;
                Console.Write($"{i,2}");
                Console.Write($"{result,20}");
                Console.WriteLine();


            }
            return result;

        }

        public static int Zaehlen()
        {

            int d1 = 100;
            for (int i = 10; i < 1000; i++)
            {
                d1 = d1 + 10;
                Console.WriteLine(d1 / 100.0);
            }
            return d1;

        }

        public static void Zaehlen2()
        {
            float d2 = 100;
            Console.WriteLine(d2);
            for (int i = 0; i < 100; i++)
            {
                d2 = d2 + 10;
                Console.WriteLine(d2);

            }


        }
        





    }

    

}
