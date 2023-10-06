
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
            //    summe();
            //    faktorial(20);
            //    faktorialErweitert(20);
            //    zaehlenDezimalSchritten(100);
            //    zaehlenDezimalSchrittenErweitert(100);
            //    teilenUndHerrschen(20);
            //    berechnungPi();
            //    berechnungPiNil();
            //    geheimeReihe(10);
            //    wurzelannäherung(100);
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


        //Gib das Resultat der Float normal aus und ergänze deinen Ausdruck mit formatierter Ausgabe. Verwende die Console.WriteLine() Funktion.  Probiere verschiedenen Formatstrings.
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


        //Erstelle eine Funktion, die von 0 bis 20 zählt und die folgende Daten ausdruckt (siehe Aufgaben)
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


        //Rechne die Annäherung von Pi mit der Formel π = (4/1) - (4/3) + (4/5) - (4/7) + (4/9) - (4/11) + (4/13) - (4/15) ...
        public static void berechnungPi()
        {
            double pi = 0;

            for (int i = 1; i < 100000; i = i + 4)
            {
                pi = pi + (4.0 / i);
                pi = pi - (4.0 / (i + 2));
            }

            Console.WriteLine(pi);

        }

        //Rechne die Annäherung von Pi mit der Formel π = 3 + 4/(2*3*4) - 4/(4*5*6) + 4/(6*7*8) - 4/(8*9*10) + 4/(10*11*12) - 4/(12*13*14)
        public static double berechnungPiNil()
        {
            double pi = 0;

            for (int x = 0; x < 1000; x = x + 4)
            {
                pi = pi + 4 / ((2.0 + x) * (3.0 + x) * (4.0 + x));
                pi = pi - 4 / ((4.0 + x) * (5.0 + x) * (6.0 + x));
            }

            Console.WriteLine(3 + pi);

            return pi;
        }

        //Starte eine neue Reihe mit dem Wert 1.0
        public static double geheimeReihe(int count)
        {

            double wert = 1;

            for(double x = 0; x < count; x++)
            {
                wert = wert / 2 + 1 / wert;

                Console.WriteLine(wert);
            }

            return wert;
        }


        //public static double wurzelannäherung(int count)
        //{
        //    double random = new Random().Next(10000) + 1;
        //    double random1 = random

        //    for (int x = 0; x < count; x++)
        //    {
                
        //        Console.WriteLine(random);
        //        //if ()
        //    }

        //    return random;
        //}

    }
}
