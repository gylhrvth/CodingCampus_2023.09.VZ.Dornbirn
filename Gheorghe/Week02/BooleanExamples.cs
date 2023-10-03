using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gheorghe.Week02
{
    public class BooleanExamples
    {
        public static void StartBooleanExamples()
        {
            bool isNumber = true;
            Console.WriteLine(isNumber);

            bool isBig = false;
            Console.WriteLine(isBig);


              Console.WriteLine("!false:" + !false);
            Console.WriteLine("!true:" + !true);

            Console.WriteLine("true and true :" + (true && true));
            Console.WriteLine("true and false :" + (true && false));
            Console.WriteLine("false and false:" + (false && false));


            Console.WriteLine("true or true :" + (true || true));
            Console.WriteLine("false or true:" + (false || true));
            Console.WriteLine("false or false :" + (false || false));


            int iX = 5;
            Console.WriteLine("i == 5:" + (iX == 5));
            Console.WriteLine(" i!= 5:" + (iX != 5));
            Console.WriteLine("i  < 7:" + (iX < 7));
            Console.WriteLine("i <= 7:" + (iX <= 7));
            Console.WriteLine("i >  7:" + (iX > 7));
            Console.WriteLine("i >= 7:" + (iX >= 7));


            int size = 7;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                 if (i == j)
                    {
                        Console.Write("X ");

                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                        Console.WriteLine();
            }

        }
    }

}

