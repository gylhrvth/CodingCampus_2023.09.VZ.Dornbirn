using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Hassan.Week02
{
    internal class Ecxs
    {
        public static void Start()
        {
            int ergebnis = BerechneSumme();
            Console.WriteLine("Die Summe der Zahlen von 20 bis 50 ist: " + ergebnis);

            long[] result = BerechneFakultaeten();
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine($"{i,2}! = {result[i]}");
            }

            Add2();

        }


        public static int BerechneSumme()
        {
            int summe = 0;

            for (int i = 20; i <= 50; i++)
            {
                summe += i;
            }

            return summe;
        }

        public static long[] BerechneFakultaeten()
        {
            long[] fakultaeten = new long[20];

            for (int i = 1; i <= 20; i++)
            {
                long fakultaet = 1;

                for (int j = 1; j <= i; j++)
                {
                    fakultaet *= j;
                }

                fakultaeten[i - 1] = fakultaet;
            }

            return fakultaeten;
        }

        public static long Add2()
        {
            long summe = 1;

            for(long i =summe; i <= 20; i++)
            {
                summe *= i;
                Console.Write($"{i,2}" + " ");
                Console.Write($"{summe,20}");
                Console.WriteLine();
            }
            return summe;
        }



    }

}
