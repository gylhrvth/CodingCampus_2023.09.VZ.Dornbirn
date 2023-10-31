using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon.Week05.Kalender
{

    public class Time_outputs
    {
        public static GregorianCalendar cal = new GregorianCalendar();
        public static void Start()
        {
            Console.WriteLine("Formate für Datums");
            DateFormats();

            //Console.WriteLine(Dayofweekuserinput());

            Console.WriteLine("Next Sunday is:");
            Console.WriteLine(WhenisnextSunnday());

            Console.WriteLine("\nWieviele Sonntage hat der Monat?");
            Console.WriteLine(GetSundays(2023, 10));
            Console.WriteLine(GetSundays(2023, 9));

            Console.WriteLine("\nWieviele Arbeitstage hat der Monat?");
            Console.WriteLine(GetWorkdays(2021, 6));
            Console.WriteLine(GetWorkdays(2021, 3));
            Console.WriteLine(GetWorkdays(2021, 2));
        }

        public static void DateFormats()
        {
            DateTime t = DateTime.Now;
            CultureInfo austrian = new CultureInfo("de-AT");

            Console.WriteLine(t.ToString("d"), austrian);
            Console.WriteLine(t.ToString("T"), austrian);
            Console.WriteLine(t.ToString("G"), austrian);
        }

        public static DayOfWeek Dayofweekuserinput()
        {
            Console.WriteLine("Input your date of Birth");
            string userinput = Console.ReadLine();
            DateTime t = DateTime.Parse(userinput);
            //string output = t.ToString("dddd");
            DayOfWeek dayofweek = cal.GetDayOfWeek(t);

            return dayofweek;
        }

        public static string WhenisnextSunnday()
        {
            DateTime t = DateTime.Now;
            DayOfWeek nextsunnday = cal.GetDayOfWeek(t);
            int count = 0;
            while (true)
            {
                if (nextsunnday == DayOfWeek.Sunday)
                //DayOfWeek.Saturday +1 viel schneller weils nicht durch komplettest int durch geht.
                {
                    return cal.AddDays(t, count + 7).ToString("d");
                }
                else
                {
                    count++;
                    nextsunnday++;
                }
            }
        }
        // wieso gibt er hier letzten Sonntag aus und nicht nächsten???? nirgendwo - ...

        public static int GetSundays(int year, int month)
        {
            DateTime t = DateTime.Parse("01." + month + "." + year);
            // alternativ auch DateTime t = new DateTime(year, month, 1);
            DayOfWeek dayOfWeek = cal.GetDayOfWeek(t);
            int daysinmonth = cal.GetDaysInMonth(year, month);
            int countsundays = 0;
            for (int i = 0; i < daysinmonth; i++)
            {
                if (dayOfWeek == DayOfWeek.Sunday)
                {
                    countsundays++;
                }
                t = t.AddDays(1);
                dayOfWeek = cal.GetDayOfWeek(t);
            }

            //string output = DateTime.Parse(year + "-" + month).ToString("d");
            return countsundays;
        }

        public static int GetWorkdays(int year, int month)
        {
            DateTime t = DateTime.Parse("01." + month + "." + year);
            // alternativ auch DateTime t = new DateTime(year, month, 1);
            DayOfWeek dayOfWeek = cal.GetDayOfWeek(t);
            int daysinmonth = cal.GetDaysInMonth(year, month);
            int countworkdays = 0;
            for (int i = 0; i < daysinmonth; i++)
            {
                if (dayOfWeek == DayOfWeek.Monday || dayOfWeek == DayOfWeek.Tuesday || dayOfWeek == DayOfWeek.Wednesday || dayOfWeek == DayOfWeek.Thursday || dayOfWeek == DayOfWeek.Friday)
                {

                    countworkdays++;
                }
                t = t.AddDays(1);
                dayOfWeek = cal.GetDayOfWeek(t);
            }

            //string output = DateTime.Parse(year + "-" + month).ToString("d");
            return countworkdays;
        }




    }
}
