using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gheorghe.Week02
{
    internal class Teilen
    {
        public static void Start()
        {
            // teilenUndHerrschen(20);
            BerechnungvonLeibniz(100000000);
        }


        public static void teilenUndHerrschen(int count)
        {
            int five = 5;
            double fived = 5.0;

            for (int i = 0; i <= count; i++)
            {
                Console.Write(i + " / " + five + " = ");
                Console.Write(i / five);
                Console.WriteLine();
                Console.Write($"{i} / {fived:0.0} = ");
                Console.Write(i / fived);
                Console.WriteLine();
            }
        }
        public static void BerechnungvonLeibniz(int input)
        {
            double pi = 0;
            for (int i = 1; i < input; i = i + 4)
            {
                pi = pi + (4.0 / i);
                pi = pi - (4.0 / (i + 2));

            }
            Console.WriteLine(pi);
        }
    }
}
