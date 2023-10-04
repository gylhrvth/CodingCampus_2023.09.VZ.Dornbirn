using System;
namespace David.Week02
{
    public class DataTypes
    {
        public static void StartDataTypes()

        {
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
            for (int i = 0; i < 20; i++) ; // 
            {
                h2 = h2 + 10; // 10 statt 0,1
                Console.WriteLine("h2 = " + (h2 / 100.0));
            }



            Console.WriteLine("-----------");

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

            Console.WriteLine(".........");

            int summe = 0;
            for (a = 20; a <= 50; a++)
            {
                Console.WriteLine(summe += a);
            }

            Console.WriteLine("--------");

            long fak = 1;

            for (a = 1; a <= 20; a++)
            {
                fak *= a;
            }
            Console.WriteLine(fak);

            Console.WriteLine("--------");

            long fakto = 1;

            for (a = 1; a <= 20; a++)
            {
                fakto *= a;
                Console.Write($"{a,2}");
                Console.Write(" ! = ");
                Console.Write($"{fakto,20}");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}

