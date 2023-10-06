using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace David.Week02
{
    public class DataTypes
    {
        public static void StartDataTypes()

        {

            //Beispiele von Gyula nochmals selbst wiederholt.


            //True,False abfrage. +1 und -1 ist nicht das Selbe. 
            int e = 1;
            int f = -1;
            Console.WriteLine("ist gleiich: " + (e == f));


            // geht bis max. 127,
            // dann trifft es sich in der Mitte,
            // wie ein Kreis und beginnt rückwerts zu zählen.

            sbyte tes = 120;
            for (int g = 0; g < 20; g++)
            {
                Console.WriteLine("tes2 = " + tes);
                ++tes;
            }

            // mit Komma (US= "." nicht ",")
            // ACHTUNG! Es kann nicht "Wirtschaftlich" gerechnet werden,
            // aufgund der Oben veranschaulichten "Schleife" wird nur das Warscheinlichste Ergebnis angezeigt
            // viele Kommastellen. Je komplezer die Rechnungen, desto größer die Fehler.

            double h = 5.0;
            Console.WriteLine("double = " + h);
            for (int i = 0; i < 20; i++)
            {
                h = h + 0.1;
                Console.WriteLine("double = " + h);
            }

            // Um diese Fehler der Nachnkommastellen zu vermeiden.
            // Rechnen wir mit großen Zahlen UM ein genaues Ergebnis zu erhalen.

            int h2 = 500; //500 statt 5
            for (int i = 0; i < 20; i++) // 
            {
                h2 = h2 + 10; // 10 statt 0,1
                Console.WriteLine("h2 = " + (h2 / 100.0));
            }



            Console.WriteLine("-----------");
            // Kopie von Gyula, Erklärung am Board

            int a = 1;
            int b = -1;

            Console.WriteLine("ist gleich: " + (a == b));

            sbyte test = 120;
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("test2 = " + test);
                ++test;
            }

            double d = 5.0;
            Console.WriteLine("d = " + d);
            for (int i = 0; i < 20; i++)
            {
                d = d + 0.1;
                Console.WriteLine("d = " + d);
            }

            int d2 = 500;
            for (int i = 0; i < 20; i++)
            {
                d2 = d2 + 10;
                Console.WriteLine("d2 = " + (d2 / 100.0));
            }



            Console.WriteLine("a + 1 = " + (a + 1)); // Addition
            Console.WriteLine("a - 3 = " + (a - 3)); // Substraktion
            Console.WriteLine("a * 5 = " + (a * 5)); // Multiplikation
            Console.WriteLine("a / 5 = " + (a / 5)); // Division (integer)
            Console.WriteLine("a % 5 = " + (a % 5)); // Modulo (Restwert)


            d = 5.25;
            Console.WriteLine("d + 1 = " + (d + 1)); // Addition
            Console.WriteLine("d - 3 = " + (d - 3)); // Substraktion
            Console.WriteLine("d * 5 = " + (d * 5)); // Multiplikation
            Console.WriteLine("d / 5 = " + (d / 5)); // Division (double)

            Console.WriteLine("a = " + a);
            ++a;
            Console.WriteLine("a = " + a);
            a++;
            Console.WriteLine("a = " + a);


            Console.WriteLine("a!!! = " + (a++));
            Console.WriteLine("a!!! = " + (++a));


            a += 5; // a = a + 5
            Console.WriteLine("a = " + a);
            a -= 8; // a = a - 8
            Console.WriteLine("a = " + a);
            a *= 2; // a = a * 2
            Console.WriteLine("a = " + a);
            a /= 5; // a = a / 5
            Console.WriteLine("a = " + a);


            // Ab hier Lösung der Beispiele von ccwiki


            Console.WriteLine("----------------");
            Console.WriteLine("Beispiele:");
            Console.WriteLine();

            // "Erstelle eine Funktion, die von 20 bis 50 alle Ganzzahlen nimmt und deren Summe ausrechnet."

            int sum = 0;
            for (a = 20; a <= 50; a++)
            {
                sum += a;
            }

            Console.WriteLine(sum);

            //    //Console.WriteLine(sum += a);
            //}
            //Console.WriteLine("...");

            //int k = 20;
            //{
            //    Console.WriteLine(k + (k + 1))=l;l <= 50;
            //}

            Console.WriteLine(".........1");

            //Aufgabe Summe / Ausgabe untereinander
            // Funktion, die von 20 bis 50 alle Ganzzahlen nimmt und deren Summe ausrechnet.

            int summe = 0;
            for (a = 20; a <= 50; a++)
            {
                Console.WriteLine(summe += a);
            }

            Console.WriteLine("--------2");

            //Fraktorial / Nur Ausgabe vom Ergebnis 

            long fak = 1;

            for (a = 1; a <= 20; a++)
            {
                fak *= a;
            }
            Console.WriteLine(fak);

            Console.WriteLine("--------3");

            //Aufgabe Fraktorial (mit Formatierung)
            // 1*2*3*4*5*6.....

            long zz = 1;

            for (a = 1; a <= 20; a++)
            {
                zz *= a;
                Console.Write($"{a,2}");
                Console.Write(" ! = ");
                Console.Write($"{zz,20}");
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("--------");
            //Aufgabe: Zählen von 0-100(bis zwei, weil kein platz in ausgabe)
            //variante 1

            int d3 = 0;
            for (int i = 0; i < 20; i++)
            {
                d3 = d3 + 100;
                Console.WriteLine(d3 / 1000.0);
            }

            Console.WriteLine("--------");

            //Aufgabe: Zählen von 0-100(bis zwei, weil kein platz in ausgabe)
            //variante 2
            for (double i = 0; i <= 2; i += 0.1)
            {

                Console.WriteLine(Math.Round(i, 2));
            }



            PrintFactorial();

            Console.WriteLine("Factorial of 10 is " + CalcFactorial(10));

            CalcFactorial(20);


        }

        public static void PrintFactorial()
        {
            long fuck = 1;
            for (int a = 1; a <= 20; a++)
            {
                fuck = fuck * a;
                Console.WriteLine("{0, 20}", fuck);
            }

        }

        public static long CalcFactorial(int calc)
        {
            long fuck = 1;
            for (int a = 1; a <=  calc; a++)
            {
                fuck = fuck * a;
                Console.WriteLine("{0, 20}", fuck);
                
            }
            return fuck;
        }
    }
}
