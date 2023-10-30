using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabienne.Week06
{
    internal class Kalender
    {
        public static void Start()
        {
            //DateTimeSandbox();
            //MyBirthday();
            //WhenIsSunday();
        }
        public static void DateTimeSandbox()
        {
            DateTime t = DateTime.Now;
            CultureInfo austrian = new CultureInfo("de-AT");

            
            Console.WriteLine(t.ToString("d", austrian));
            Console.WriteLine(t.ToString("t", austrian));
            Console.WriteLine(t.ToString("F", austrian));

            Console.WriteLine(t.ToString("yyyy.MM.dd"));
        }
        public static void MyBirthday()
        {
            int abc = 0;
            while (abc == 0)
            {
                Console.WriteLine("When is your birthday? (yyyy.MM.dd)");

                GregorianCalendar cal = new GregorianCalendar();
                try
                {
                    Console.WriteLine("Your birthday is on a " + cal.GetDayOfWeek(DateTime.Parse(Console.ReadLine())));
                    abc++;
                }
                catch
                {
                    Console.WriteLine("That is an invalid Birthday, try again!");
                }
            }
        }
        //public static void WhenIsSunday()
        //{
        //    GregorianCalendar ca1 = new GregorianCalendar();

        //    DateTime t = DateTime.Now;

        //    while()
        //    {
        //        if ()
        //        {
        //            Console.WriteLine(ca1.GetDayOfWeek(t));
        //        }
        //        else
        //        {
        //            t = t.AddDays(1);
        //        }
        //    }                       
        //}
    }
}
