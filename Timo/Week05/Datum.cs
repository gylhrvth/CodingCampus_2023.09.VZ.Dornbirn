using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timo.Week03;

namespace Timo.Week05
{
    internal class Datum
    {
        public static void Start()
        {
            //Aufgabe 1
            Console.WriteLine("Aufgabe 1: Wann und Wo");
            DateTimeSandbox();
            Console.WriteLine("===============================");

            //Aufgabe 2
            Console.WriteLine("Aufgabe 2: Mein Geburtstag");
            Console.WriteLine(MyBirthday());
            Console.WriteLine("===============================");

        }

        //Aufgabe 1 Wann und wo
        public static void DateTimeSandbox()
        {
            DateTime t = DateTime.Now;
            CultureInfo austrian = new CultureInfo("de-AT");

            Console.WriteLine(t.ToString("d"));
            Console.WriteLine(t.ToString("t"));
            Console.WriteLine(t.ToString("F"));
        }

        //Aufgabe 2 Mein Geburtstag
        public static string MyBirthday()
        {
            Console.WriteLine("Please enter your birthday (dd.mm.yyyy): ");
            string birthdayInput= Console.ReadLine();
            DateTime birthday = DateTime.Parse(birthdayInput);
            string result = birthday.ToString("dddd");

            return result;
        }

    }
}
