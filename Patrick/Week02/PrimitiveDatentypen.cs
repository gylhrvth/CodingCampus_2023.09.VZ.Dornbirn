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
            summe();
            faktorial(20);
            faktorialErweitert(20);
            zaehlenDezimalSchritten(100);
            zaehlenDezimalSchrittenErweitert(100);
        }

        //Erstelle eine Funktion, die von 20 bis 50 alle Ganzzahlen nimmt und deren Summe ausrechnet
        public static void summe()
        {
            int result = 0;

            for( int i = 20; i <=50; i++)
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

            for( int i = 1; i <= num; i++)
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

                Console.Write($"{i,2}");
                Console.Write("! = ");
                Console.WriteLine($"{result,20}");
            }

            Console.WriteLine("----------");
            Console.WriteLine("----------");
        }

        //Erstelle eine Funktion, die von 0 bis 100 in 0.1er Schritten zählt, und alle werte ausgibt.
        public static void zaehlenDezimalSchritten(int num)
        {
            double fakt = num * 10;

            for( int i = 0; i <= fakt; i++)
            {
                Console.WriteLine(i / 10.0);
            }
            Console.WriteLine("----------");
            Console.WriteLine("----------");
        }

        public static void zaehlenDezimalSchrittenErweitert(int num)
        {

        }

    }
}
