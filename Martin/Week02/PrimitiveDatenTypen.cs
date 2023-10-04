using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Martin.Week02
{
    internal class PrimitiveDatenTypen
    {
        public static void StartDatenTypen()
        {

            //int Result = Ausrechnen(20);
            //long Resutl = Faktorial(20);
            ZeroToHunderd();

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

                Console.WriteLine("{0,-2} ! = {1,20} test",i,result);

            }

            return result;

        }

        //Aufgabe: Von 0 bis 100 Zählen in 0.1er Schritten

        public static void ZeroToHunderd()
        {
            double number = 0.0;

            for(int i = 0; i < 100; i++)
            {
                number += 0.1;
                Console.WriteLine(number);
            }
        }
    }
}
