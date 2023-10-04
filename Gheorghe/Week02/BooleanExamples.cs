using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Gheorghe.Week02
{
    public class BooleanExamples
    {

        public static void StartBooleanExamples()
        {

            printRohmbus("*", 7);


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



            int input = 7;
            for (int zeile = 0; zeile < input; zeile++)
            {
                for (int col = 0; col < input; col++)
                {
                    if (zeile == col)
                    {
                        Console.Write(" * ");

                    }
                    else
                    {
                        Console.Write(" . ");
                    }
                }
                Console.WriteLine();
            }

        }

        public static void printRohmbus(string symbol, int size)
        {
            for (int zeile = 0;zeile < size ;zeile++)
            {
                for(int col = 0;col < size -1 - zeile  ;col++)
                {
                    if (zeile > 0 )
                    {
                        Console.Write(".");

                    }
                    else
                    {
                        Console.Write("$");
                    }
                   
                }
                Console.WriteLine();
            }
        }

    }
}          




