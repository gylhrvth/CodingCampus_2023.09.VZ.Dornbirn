using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kerem.Exercises
{
    internal class Conversions
    {
        public static void main()
        {
            //implizite Konvertierung
            int num = 213902;
            long longnum = num;

            float myfloat = 13.37f;
            double mynewdouble = myfloat;


            //explizite Konvertierung
            double mydouble = 13.37f;
            int myint;
            myint = (int)mydouble;

            //typ Konvertierung
            string myString = mydouble.ToString(); //"13.37"
            string myFloatString = myfloat.ToString();

            bool sunIsShining = true;
            string myBoolString = sunIsShining.ToString();


            Console.WriteLine(sunIsShining);
            Console.Read();
        }
    }
}
