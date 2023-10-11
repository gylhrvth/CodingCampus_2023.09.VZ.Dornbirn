using System;
namespace Mohammed.Week02
{
    public class BooleanExamples
    {
        public static void start()
        {
            printRhombus("x", 7);


            /*
            bool isNumber = true;
            Console.WriteLine(isNumber);

            bool isBig = false;
            Console.WriteLine(isBig);

            Console.WriteLine("!false : " + !false);
            Console.WriteLine("!true : " + !true);



            int size = 3;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < 2 * size - 1; j++)
                {
                    if ((i + j + 1 == size) || (i + size - 1 == j) || (i == size - 1))
                    {
                        Console.Write("x ");
                    }
                    else
                    {
                        Console.Write(". ");
                    }
                }
                Console.WriteLine();
            }
            //SACHEN VON WEEK 1 ZU WIEDER HOLEN


            */








        }


        public static void printRhombus(string symbol, int count)
        {

            // obere hälfte
            for (int a = 0; a < count; a++)
            {
                for (int s = 0; s < count - 1 - a; s++)
                {
                    Console.Write(" ");
                }

                Console.Write(symbol);

                if (a > 0)
                {
                    for (int k = 0; k < 2 * a - 1; k++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(symbol);
                }
                Console.WriteLine();

            }


            // untere hälfte

            for (int y = count - 2; y >= 0; y--)
            {
                for (int i = 0; i < count - y - 1; i++)
                {
                    Console.Write(" ");
                }

                Console.Write(symbol);
                if (y > 0)
                {
                    for (int k = 0; k < 2 * y - 1; k++)
                    {
                        Console.Write(" ");
                    }
                        Console.Write(symbol);
                }
                Console.WriteLine();

            }


        }

        
    }
}