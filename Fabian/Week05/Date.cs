using System.Globalization;
using static Fabian.Week02.ConsoleInput;

namespace Fabian.Week05
{
    public class Date
    {
        public static readonly CultureInfo austria = new("de-AT");
        public static void Start()
        {
            //NextSunday();
            //GetSundays(2023, 11);
            //GetWorkDays(2023, 11);
            Calendar(2023, 10, 1);
        }

        public static void TimeNow()
        {
            DateTime t = DateTime.Now;

            Console.WriteLine(t.ToString("d"), austria);
            Console.WriteLine(t.ToString("t"), austria);
            Console.WriteLine(t.ToString("g"), austria);
        }
        public static void Birthday()
        {
            string input = ReadString("Enter your birthday (dd.mm.yyyy): ", @"^[0-9]{1,2}\.[0-9]{1,2}\.[0-9]{4}$");
            DateTime birthday = DateTime.Parse(input);
            GregorianCalendar gc = new();

            Console.WriteLine("Your birthday was on a: " + gc.GetDayOfWeek(birthday));
        }
        public static void NextSunday()
        {
            DateTime today = DateTime.Today;
            GregorianCalendar gc = new();
            DayOfWeek t = gc.GetDayOfWeek(today);

            int count = 0;
            while ((int)t % 7 != 0)
            {
                count++;
                t++;
            }
            DateTime nextSunay = gc.AddDays(today, count);

            Console.WriteLine(nextSunay.ToString("d"), austria);

        }
        public static void GetSundays(int year, int month)
        {
            string date = "01." + month + "." + year;
            DateTime time = DateTime.Parse(date);
            GregorianCalendar gc = new();
            DayOfWeek t = gc.GetDayOfWeek(time);
            int count = 0;
            for (int i = 0; i < DateTime.DaysInMonth(year, month); i++)
            {
                if ((int)t % 7 == 0)
                {
                    count++;
                }
                t++;
            }
            Console.WriteLine(count);
        }
        public static void GetWorkDays(int year, int month)
        {
            string date = "01." + month + "." + year;
            DateTime time = DateTime.Parse(date);
            GregorianCalendar gc = new();
            DayOfWeek t = gc.GetDayOfWeek(time);
            int count = 0;
            for (int i = 0; i < DateTime.DaysInMonth(year, month); i++)
            {
                if ((int)t % 7 >= 1 && (int)t % 7 <= 5)
                {
                    count++;
                }
                t++;
            }
            Console.WriteLine(count);
        }
        public static void Calendar(int year, int month, int day)
        {
            GregorianCalendar gc = new();
            string[] headline = { "Mo", "Di", "Mi", "Do", "Fr", "Sa", "So" };
            string currentDate = day + "." + month + "." + year;
            string startDate = "1." + month + "." + year;
            DateTime time = DateTime.Parse(currentDate);
            DateTime startTime = DateTime.Parse(startDate);

            String[,] calendar = new String[6, 7];

            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < ((int)gc.GetDayOfWeek(startTime) + 6) % 7; j++)
                {
                    calendar[i, j] = " ";
                }
            }

            Console.WriteLine(year + " " + time.ToString("MMMM"));

            Console.WriteLine("| {0} | {1} | {2} | {3} | {4} | {5} | {6} |", headline[0], headline[1], headline[2], headline[3], headline[4], headline[5], headline[6]);
            PrintCalendar(year, month, day, calendar);

        }
        public static void PrintCalendar(int year, int month, int day, string[,] calendar)
        {
            int count = 1;
            for (int i = 0; i < calendar.GetLength(0); i++)
            {
                for (int j = 0; j < calendar.GetLength(1); j++)
                {
                    if (calendar[i, j] != " ")
                    {
                        if (count == day)
                        {
                            Console.Write("| {0, 3}", count++ + "*");
                        }
                        else if (count == DateTime.DaysInMonth(year, month))
                        {
                            Console.WriteLine();
                            return;
                        }
                        else
                        {
                            calendar[i, j] = Convert.ToString(count++);
                            Console.Write("| {0, 2} ", calendar[i, j]);
                        }
                    }
                    else
                    {
                        Console.Write("| {0, 2} ", calendar[i, j]);
                    }
                }
                Console.WriteLine("| ");
            }
        }


    }
}
