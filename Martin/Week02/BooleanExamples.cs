using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Martin.Week02
{
    public class BooleanExamples
    {
        public static void StartBooleanExamples()
        {


            bool isNumber = true;
            Console.WriteLine(isNumber);

  
            bool isBig = false;
            Console.WriteLine(isBig);

            Console.WriteLine("!false : " + !false); //dreht das ergebnis
            Console.WriteLine("!true : " + !true);

            //und +

            Console.WriteLine("True and true:" + (true && true));
            Console.WriteLine("true and false:" + (true && false));
            Console.WriteLine("false and true:" + (false && true));
            Console.WriteLine("false and false:" + (false && false));

            //oder *

            Console.WriteLine("True or true:" + (true || true));
            Console.WriteLine("true or false:" + (true || false));
            Console.WriteLine("false or true:" + (false || true));
            Console.WriteLine("false or false:" + (false || false));

            int ix = 5;
            Console.WriteLine("i == 5:" + (ix == 5));
            Console.WriteLine("i != 5:" + (ix != 5));
            Console.WriteLine("i < 7:" + (ix < 7));
            Console.WriteLine("i <= 5:" + (ix <= 5));
            Console.WriteLine("i > 7:" + (ix > 7));
            Console.WriteLine("i >= 5:" + (ix >= 5));

            int size = 7;

            for(int i = 0; i < size; i++) // 5
            {
                for (int j = 0; j < size; j++) //startet immer bei 0
                {
                    if(i == j)
                    {
                        Console.Write("x");
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
