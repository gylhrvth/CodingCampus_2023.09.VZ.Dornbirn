using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Gheorghe.Week02
{
    internal class Teilen
    {
        public static void Start()
        {
            // teilenUndHerrschen(20);
            // BerechnungvonLeibniz(100000000);
            //BerechnungvonNilakantha(1000000000);
            //GeheimeReihe(10);
            Wurzelnaehrung(10000);

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
            for (double i = 1; i < input; i += 2)
            {
                pi += 4.0 / i;
                pi *= -1;

            }
            Console.Write(pi);
        }

        public static void BerechnungvonNilakantha(int input)
        {
            double pi = 0;
            for (double i = 2; i < input; i += 2)
            {
                pi -= 4.0 / i;
                pi *= -1;
            }
            Console.WriteLine(pi);
        }




        public static void GeheimeReihe(int input)
        {
            double wert = 1.0;
            Console.WriteLine("1. Element = " + wert);
            for (int i = 2; i <= input; i++)
            {

                wert = (wert / 2) + (1 / wert);
                Console.WriteLine(i + ". Element = " + wert);
            }

        }
        public static void Wurzelnaehrung(int n)
        {
           int firstpower = 2;
           int  Root = 0;
           int  Minimum = 0;
           int  Maximum = Root;
            double random = new Random().Next(10000) + 1;

            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    firstpower++;
                    Console.WriteLine(  );
                }
            }
        }
    }
}

