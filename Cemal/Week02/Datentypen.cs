using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cemal.Week02
{
    internal class Datentypen
    {
        public static void StartDatentypen()
        {
            Console.WriteLine("Aufgabe Summe");
            int sum = Summe(20, 50);
            Console.WriteLine("Summe: " + sum);
        }


        //public static void Summe(int first, int second)
        //{
        //    int result = 0;
        //    for (int i = first; i <= second; i++)
        //    {
        //        result += i;
        //    }
        //    Console.Write(result);
        //}
        public static int Summe(int first, int second)
        {
            int result = 0;
            for (int i = first; i <= second; i++)
            {
                result += i;
            }

            return result;
        }
    }
}
