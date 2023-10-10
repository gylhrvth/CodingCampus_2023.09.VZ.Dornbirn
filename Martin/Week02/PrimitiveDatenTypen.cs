using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Martin.Week02
{
    internal class PrimitiveDatenTypen
    {
        public static void StartDatenTypen()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            //int Result = Ausrechnen(20);
            //long Resutl = Faktorial(20);
            //ZeroToHunderd();
            //BeisSpielMitRunden();
            //ZeroToHunderdErweitert();
            //TeilenUndHerrschen();
            //BerechnungVonPI();
            //Console.WriteLine(Math.PI);
            //BerechnungVonPINilkantka();
            //Console.WriteLine(Math.PI);
            //GeheimeReihe(20);
            WurzelRechnung(20.0);
        }

        //Aufgame: Summe
        public static int Ausrechnen(int number)
        {

            int result = 0; // ergebnis

            for (int i = number; i <= 50; i++)
            {


                result += i;
                Console.WriteLine(result);
            }


            return result;

        }

        //Aufgabe: Faktorial + Erweiterert(Bonus)

        public static long Faktorial(long Number)
        {
           long result = 1;

            for (long i = 1; i <= Number; i++)
            {

                result = result * i;

                Console.WriteLine("{0,-2} != {1,20} test",i,result);

            }

            return result;

        }

        //Aufgabe: Von 0 bis 100 Zählen in 0.1er Schritten

        public static void ZeroToHunderd()
        {
            //erste Variante

            double number = 0.0;

            for(int i = 0; i <= 1000; i++)
            {
                number += 0.1;
                Console.Write(i + "= ");
                Console.WriteLine(Math.Round(number,1));

            }

            //zweite Variante

            int Counter = 0;
            double ZeroOneSchritt = 0.0;
            
            while (Counter < 1000)
            {
                ZeroOneSchritt += 0.1;
                Console.Write( Counter + "= ");
                Console.WriteLine(Math.Round(ZeroOneSchritt,1));
                Counter++;
            }

        }

        //Aufgabe: Von 0 bis 100 Zählen in 0.1er Schritten (Erweitert)

        public static void ZeroToHunderdErweitert()
        {
            double number = 0.0; 

            for (int i = 0; i <= 1000; i++)
            {

                Console.WriteLine("Result 1 digit = {0:N1}",number); // N1 eine nachkomma stelle
                Console.WriteLine("Result 2 digit = {0,9:N2}",number); // N2 zwei nachkomma stelle

                number += 0.1;
            }
            Console.WriteLine();
        }

        //Aufgabe: Teilen und Herrschen //

        public static void TeilenUndHerrschen()
        {
            for(int x = 0; x <= 20; x++)
            {
                Console.WriteLine(x + " / " + "5" +" = "+ x/5 );
                Console.WriteLine(x + " / " + "5.0" + " = " + x/5.0);

                Console.WriteLine();
            }
        }

        // Aufgabe: Berechnung von PI(Leibniz Reihe)

        public static void BerechnungVonPI()
        {
            double PI = 0;


            for (long x = 1;x <= 100000;x+= 2)
            {

                PI += 4.0 / x;

                PI *= -1;

            }

            Console.WriteLine();

            Console.WriteLine("PI ist: "+PI);
        }

        // Aufgabe: Berechnung von PI(Nilakantha Reihe)

        public static void BerechnungVonPINilkantka()
        {
            
                double PINilakantha = 3;

                double Number1 = 2;

                for(int x = 0;x <= 100000001 ; x++)
                {


                     PINilakantha = PINilakantha + 4.0/(Number1 * (Number1 + 1) * (Number1 + 2)); 


                     PINilakantha *= -1;

                     Number1+= 2;
                    

                }



            Console.WriteLine(PINilakantha);


        }

        //Geheime Reihe //sie hat als anfangszahl 1,41

        public static void GeheimeReihe(double number)
        {

            double secret = 1.0;


            for(double i = 1.0; i < number; i++)
            {

                secret = secret / 2 + 1 / secret;

            }

            Console.WriteLine(secret);

        }

        //Wurzelannäherung

        public static void WurzelRechnung(double number)
        {
            double RandomNumber = new Random().Next((int)number) + 1;
            double WurzelVonZahl = Math.Sqrt(RandomNumber);

            Console.WriteLine(RandomNumber);
            Console.WriteLine(Math.Sqrt(RandomNumber));

            Console.WriteLine("Wurzel von "+RandomNumber+" ist "+ WurzelVonZahl);

            double minimum = 0;
            double maximum = RandomNumber;

            double newNumber = RandomNumber / 2;
            newNumber *= newNumber;
                

            if (newNumber < maximum)
            {
                maximum = newNumber;
            }

        }

        //Beispiel//
        public static void BeisSpielMitRunden()
        {

            Console.WriteLine();

            double a = 1.9999999;

            Console.WriteLine((int)a); // wird zur einem Int umgewandelt und die coma zahlen fallen weg
            Console.WriteLine((int)Math.Ceiling(a)); // rundet die komma zahle auf und wird zur einer ganzen Zahl
        }
    }
}
