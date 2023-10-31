using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sven.Week06
{
    internal class KalenderUebungen
    {
        static public void Start()
        {

            WhereAndWhen();
            Console.WriteLine();

            DateOfBirth();
            Console.WriteLine();

            WhenSunday();
            Console.WriteLine();

            CountSundays();
            Console.WriteLine();

        }

        public static void WhereAndWhen()
        {
            DateTime t = DateTime.Now;
            CultureInfo austrian = new CultureInfo("de-AT");

            Console.WriteLine(t.ToString("d", austrian));
            Console.WriteLine();
            Console.WriteLine(t.ToString("T", austrian));
            Console.WriteLine();
            Console.WriteLine(t.ToString("g", austrian));
            Console.WriteLine();

            Console.WriteLine(t.ToString("yyyy.MM.dd"));
        }

        public static void DateOfBirth()
        {
            string datevalue = "";
            
            Console.WriteLine("Please tell me your date of birth: ");
            datevalue = Console.ReadLine();

            
            try
            {
                DateTime dateValue = DateTime.Parse(datevalue);
                GregorianCalendar cal = new GregorianCalendar();
                Console.WriteLine(cal.GetDayOfWeek(dateValue));
            }
            catch (FormatException)
            {

                Console.WriteLine("Please enter a valid Date!");

            }


        }

        public static void WhenSunday()
        {
            GregorianCalendar gcal = new GregorianCalendar();
           
            DateTime currentDate = DateTime.Now;

            int currentDayOfWeek = (int)currentDate.DayOfWeek;
            int daysUntilNextSunday = 7 - currentDayOfWeek;

            DateTime nextSunday = currentDate.AddDays(daysUntilNextSunday);

            Console.WriteLine("Das Datum des nächsten Sonntags ist: " + nextSunday.ToString("yyyy-MM-dd"));
        }

        public static void CountSundays()
        {
            DateTime currentDate = DateTime.Now;

            int currentDayOfMonth = currentDate.Month;
            int sundaysInMonth = 7 - currentDayOfMonth;

            DateTime GetSundays = currentDate.AddDays(sundaysInMonth);

            Console.WriteLine(GetSundays);


        }
    }

}


