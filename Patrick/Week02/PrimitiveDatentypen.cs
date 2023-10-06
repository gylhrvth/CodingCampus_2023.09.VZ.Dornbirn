using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week02
{
    internal class PrimitiveDatentypen
    {
        public static void start()
        {
            //summe();
            //faktorial(20);
            //faktorialErweitert(20);
            //zaehlenDezimalSchritten(100);
            //zaehlenDezimalSchrittenErweitert(100);
            //teilenUndHerrschen(20);
            berechnungPi();
        }

        //Erstelle eine Funktion, die von 20 bis 50 alle Ganzzahlen nimmt und deren Summe ausrechnet
        public static void summe()
        {
            int result = 0;

            for (int i = 20; i <= 50; i++)
            {

                result += i;
            }
            Console.WriteLine(result);
            Console.WriteLine("----------");
            Console.WriteLine("----------");

        }

        // Erstelle eine Funktion, die von 1 bis 20 alle Faktorial ausrechnet und ausgibt
        public static void faktorial(long num)
        {
            long result = 1;

            for (int i = 1; i <= num; i++)
            {
                result *= i;
            }
            Console.WriteLine(result);
            Console.WriteLine("----------");
            Console.WriteLine("----------");


        }

        //Erweitere deinen Ausdruck damit, dass die Werte rechtsbündig ausgedruckt werden. Verwende die console.WriteLine Funktion. Probiere verschiedene Formatstrings "{0,20}" oder "{0,-20}"
        public static void faktorialErweitert(long num)
        {
            long result = 1;

            for (int i = 1; i <= num; i++)
            {
                result *= i;

                //Console.WriteLine($"{i,2}! = {result,20}");
                Console.WriteLine("{0, 2}! = {1, 20}", i, result);
            }

            Console.WriteLine("----------");
            Console.WriteLine("----------");
        }

        //Erstelle eine Funktion, die von 0 bis 100 in 0.1er Schritten zählt, und alle werte ausgibt.
        public static void zaehlenDezimalSchritten(int num)
        {
            double fakt = num * 10;

            for (int i = 0; i <= fakt; i++)
            {
                Console.WriteLine(i / 10.0);
            }

            Console.WriteLine("----------");
            Console.WriteLine("----------");


            int z = 1;
            double fakt2 = num * 10;

            while (z <= fakt2)
            {
                Console.WriteLine(z / 10.0);
                z++;
            }

            Console.WriteLine("----------");
            Console.WriteLine("----------");

        }

        public static void zaehlenDezimalSchrittenErweitert(int num)
        {
            double fakt = num * 10;

            for (double i = 0; i <= fakt; i++)
            {
                Console.Write("Result 1 digit = ");
                Console.WriteLine("{0,-3:0.0}", i / 10);   //Ausgabe soll 3 spalten nach links rücken + 1 Kommazahl anzeigen
                Console.Write("Result 2 digit = ");
                Console.WriteLine("{0,7:0.00}", i / 10);    // Ausgabe soll 7 spalten nach rechts rücken + 2 Kommazahlen anzeigen   
            }

            Console.WriteLine("----------");
            Console.WriteLine("----------");
        }

        public static int teilenUndHerrschen(int count)
        {

            int five = 5;

            for (int x = 0; x <= count; x++)
            {
                double fived = five;

                Console.Write(x + " / " + five + " = ");
                Console.WriteLine(x / five);
                Console.Write($"{x} / {fived:0.0} = ");
                Console.WriteLine(x / fived);
            }
            return count;
        }

        public static void berechnungPi()
        {
            double pi = 0;

            for (int i = 1; i < 1000000000; i = i + 4)
            {
                pi = pi + (4.0 / i);
                pi = pi - (4.0 / (i + 2));
            }

            Console.WriteLine(pi);

        }

    }
}
