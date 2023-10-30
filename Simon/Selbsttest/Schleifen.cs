using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon.Selbsttest
{
    internal class Schleifen
    {
        public static void Start()
        {
            Countreverse(10);
            Console.WriteLine();
            Countmodulo3(-30);
            Console.WriteLine();
            Countwhile(10);
            Console.WriteLine();

        }
        //Loops Tasks
        public static void Countreverse(int number)
        {
            for (int i = 0; i < number; number--)
            {
                Console.WriteLine(number);
            }
        }
        public static void Countmodulo3(int number)
        {
            for (int i = 30; i >= number; number++)
            {
                if (number % 3 == 0)
                Console.WriteLine(number);
            }
        }
        public static void Countwhile(int number)
        {
            int number1 = 0;
            while(number1 < number/2+1) 
            {
                Console.WriteLine(number1);
                number1++;
            }
            while (number1 <= number)
            {
                Console.WriteLine(number1);
                Console.WriteLine();
                number1++;
            }
        }

    }
}
