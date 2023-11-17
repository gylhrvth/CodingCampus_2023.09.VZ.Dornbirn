using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Kerem.Week06
{
    internal class DateTimeExamples
    {
        public static void Start()
        {
            //DateTimeSandbox();
            Birthday("Enter your birthday");
            //WhenIsSunday();
            //GetNumberOfSundays(2000,5);
        }
        public static void DateTimeSandbox()
        {
            DateTime t = DateTime.Now;

            Console.WriteLine(t.ToString("d"));
            Console.WriteLine(t.ToString("t"));
            Console.WriteLine(t.ToString("g"));
        }
        public static string Birthday(string msg)
        {
            Console.WriteLine(msg);
            string input = Console.ReadLine();

            try
            {
                DateTime output = DateTime.Parse(input);
                GregorianCalendar cal = new GregorianCalendar();
                Console.WriteLine("Your birthday is on {0}", cal.GetDayOfWeek(output));
                Console.WriteLine("Senin dogum günün {0}'gününde", output.ToString("dddd", new CultureInfo("tr-TR")));
                Console.WriteLine("あなたの誕生日は今日です{0}", output.ToString("dddd", new CultureInfo("ja-JP")));

            }
            catch (FormatException) 
            {
                Console.WriteLine("Format Exception, please enter the correct type! ");
            }
            return input;
        }

        public static void WhenIsSunday()
        {
            GregorianCalendar cal = new GregorianCalendar();
            DateTime currentDate = DateTime.Now;

            int currentDayOfWeek = (int)currentDate.DayOfWeek;
            int daysUntilNextSunday = 7 - currentDayOfWeek;

            DateTime nextSunday = currentDate.AddDays(daysUntilNextSunday);
            Console.WriteLine("Das Datum des nächsten Sonntags ist: " + nextSunday.ToString("yyyy-MM-dd"));
        }
        public static void GetNumberOfSundays(int years, int months)
        {
           
            const int July = 7;
            const int Feb = 2;

            int daysInJuly = DateTime.DaysInMonth(2001, July);
            Console.WriteLine(daysInJuly);

           
            int daysInFeb = DateTime.DaysInMonth(1998, Feb);
            Console.WriteLine(daysInFeb);

           
            int daysInFebLeap = DateTime.DaysInMonth(1996, Feb);
            Console.WriteLine(daysInFebLeap);


        }
  
    }
}
    


    

