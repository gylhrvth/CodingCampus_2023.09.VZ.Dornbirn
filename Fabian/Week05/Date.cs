using static Fabian.Week02.ConsoleInput;
using System.Globalization;

namespace Fabian.Week05
{
    public class Date
    {
        public static void Start()
        {
            NextSunday();
        }

        public static void TimeNow()
        {
            DateTime t = DateTime.Now;
            CultureInfo austria = new CultureInfo("de-AT");

            Console.WriteLine(t.ToString("d"), austria);
            Console.WriteLine(t.ToString("t"), austria);
            Console.WriteLine(t.ToString("g"), austria);
        }
        public static void Birthday()
        {
            string input = ReadString("Enter your birthday (dd.mm.yyyy): ", @"^[0-9]{1,2}\.[0-9]{1,2}\.[0-9]{4}$");

            DateTime birthday = DateTime.Parse(input);
            GregorianCalendar gc = new GregorianCalendar();

            Console.WriteLine("Your birthday was on a: " + gc.GetDayOfWeek(birthday));
        }
        public static void NextSunday()
        {
            DateTime today = DateTime.Today;
            GregorianCalendar gc = new GregorianCalendar();
            DayOfWeek t = gc.GetDayOfWeek(today);

            int count = 0;
            while (t != DayOfWeek.Saturday + 1)
            {
                count++;
                t++;
            }
            DateTime sunday = gc.AddDays(today, count);

            Console.WriteLine(sunday.ToString("d"));

        }
    }
}
