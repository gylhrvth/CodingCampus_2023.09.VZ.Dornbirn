using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timo.Week04
{
    internal class Rekursion
    {
        public static void Start()
        {
            //Aufgabe 1: Summe Rekursiv
            Console.WriteLine("Summe:");
            Console.WriteLine(SumRekursiv(5));

            Console.WriteLine("==========================================================");

            //Aufgabe 2: Faktorial Rekursiv
            Console.WriteLine("Faktorial:");
            Console.WriteLine(FakRekursiv(42));
            Console.WriteLine(long.MaxValue);
            Console.WriteLine("==========================================================");

            //Aufgabe 3: Fibonnacci
            Console.WriteLine("Fibonnaci:");
            

            Console.WriteLine(FibonnacciRekursiv(7));
        }

        //Aufgabe 1: Summe Rekursiv
        public static int SumRekursiv(int eingabe)
        {
            if (eingabe == 0) { return 0; }
            int summe = eingabe + SumRekursiv(eingabe - 1);
            return summe;
        }

        //----------------------------------------------------------------------------------------------------------------------------------

        //Aufgabe 2: Faktorial Rekursiv
        public static long FakRekursiv(long eingabe)
        {
           if (eingabe == 1) { return 1; }

            return eingabe * FakRekursiv(eingabe - 1);
        }

        //----------------------------------------------------------------------------------------------------------------------------------

        //Aufgabe 3: Fibonnacci
        public static int FibonnacciRekursiv(int eingabe)
        {
            if (eingabe == 1 || eingabe == 2) { return 1; }
            int fibo = FibonnacciRekursiv(eingabe - 1) + FibonnacciRekursiv(eingabe - 2);
            return fibo;
        }
    }
}
