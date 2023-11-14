using Patrick.Week04.ConsoleInputs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week05.Kalender
{
    internal class Kalender
    {
        public static GregorianCalendar cal = new GregorianCalendar();
        public static DateTime time = new DateTime();

        public static void Start()
        {
            //WannUndWo();
            //MyBirthday();
            //Sunday();
            //HowManySundays();
            //HowManyBussinesDays();
            Kalenderr();
        }

        public static void WannUndWo()
        {
            DateTime t = DateTime.Now;
            //Console.WriteLine(t);
            CultureInfo austrian = new CultureInfo("de-AT");
            DayOfWeek dow = austrian.DateTimeFormat.FirstDayOfWeek;
            //Console.WriteLine(dow);

            Console.WriteLine(t.ToString("d"));
            Console.WriteLine(t.ToString("t"));
            Console.WriteLine(t);
        }

        public static void MyBirthday()
        {
            Console.WriteLine("Geben Sie Ihren Geburtsdatum an: ");
            Console.Write(">>>>>");
            DateTime input = DateTime.Parse(Console.ReadLine());
            DayOfWeek day = cal.GetDayOfWeek(input);

            Day(day);
        }

        public static DayOfWeek Day(DayOfWeek day)
        {
            switch (day)
            {
                case DayOfWeek.Monday:
                    Console.Write("Sie Sind an einem Montag geboren");
                    break;
                case DayOfWeek.Tuesday:
                    Console.Write("Sie Sind an einem Dienstag geboren");
                    break;
                case DayOfWeek.Wednesday:
                    Console.Write("Sie Sind an einem Mittwoch geboren");
                    break;
                case DayOfWeek.Thursday:
                    Console.Write("Sie Sind an einem Donnerstag geboren");
                    break;
                case DayOfWeek.Friday:
                    Console.Write("Sie Sind an einem Freitag geboren");
                    break;
                case DayOfWeek.Saturday:
                    Console.Write("Sie Sind an einem Samstag geboren");
                    break;
                case DayOfWeek.Sunday:
                    Console.Write("Sie Sind an einem Sonntag geboren");
                    break;
            }

            return day;
        }

        public static void Sunday()
        {
            DateTime input = DateTime.Now;
            int daysUntilNextSunday = 0;
            DayOfWeek sunday = cal.GetDayOfWeek(input);

            daysUntilNextSunday = (7 - (int)sunday) % 7;
            input = input.AddDays(daysUntilNextSunday);
            Console.WriteLine("Der nächste Sonntag ist am " + input.ToString("d"));
        }

        public static void HowManySundays()
        {
            Console.WriteLine("Geben Sie ein Jahr an: ");
            Console.Write(">>>>>");
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine("Geben Sie einen Monat an: ");
            Console.Write(">>>>>");
            int month = int.Parse(Console.ReadLine());
            //DayOfWeek day = cal.GetDayOfWeek(input1 + input2);

            int daysInMonth = DateTime.DaysInMonth(year, month);
            //Console.WriteLine(daysInMonth);

            int numSunday = 0;
            for (int day = 1; day <= daysInMonth; day++)
            {
                DateTime daysInMonthBet = new DateTime(year, month, day);
                if (daysInMonthBet.DayOfWeek == DayOfWeek.Sunday)
                {
                    numSunday++;
                }
            }
            Console.WriteLine($"In Diesem Monat gibt es {numSunday} Sontage");
        }

        public static void HowManyBussinesDays()
        {
            Console.WriteLine("Geben Sie ein Jahr an: ");
            Console.Write(">>>>>");
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine("Geben Sie einen Monat an: ");
            Console.Write(">>>>>");
            int month = int.Parse(Console.ReadLine());

            DateTime firstDayOfMonth = new DateTime(year, month, 1);
            int daysInMonthInt = DateTime.DaysInMonth(year, month);
            int workingCount = 0;
            int dec = 0;

            for (int day = 1; day <= daysInMonthInt; day++)
            {
                if (firstDayOfMonth.DayOfWeek == DayOfWeek.Sunday || firstDayOfMonth.DayOfWeek == DayOfWeek.Saturday)
                {
                    dec++;
                }
                firstDayOfMonth = firstDayOfMonth.AddDays(1);
            }
            workingCount = daysInMonthInt - dec;
            Console.WriteLine($"Im Monat {month} müssen Sie {workingCount} Tage arbeiten.");
        }

        public static void Kalenderr()
        {
            int year = 2023; // Jahr
            int month = 12;   // Monat
            int day = 20;     // Aktueller Tag

            DateTime today = new DateTime(year, month, day);

            Console.WriteLine($"{year} {today:MMMM}");
            Console.WriteLine("| Mo | Di | Mi | Do | Fr | Sa | So |");

            DateTime firstDayOfMonth = new DateTime(year, month, 1);
            int daysInMonth = DateTime.DaysInMonth(year, month);
            int currentDay = 1;

            DayOfWeek firstDayOfWeek = firstDayOfMonth.DayOfWeek;
            int leadingSpaces = ((int)firstDayOfWeek - 1 + 7) % 7;

            for (int i = 0; i < leadingSpaces; i++)
            {
                Console.Write("|    ");
            }

            Console.Write("|");

            while (currentDay <= daysInMonth)
            {
                if (firstDayOfWeek == DayOfWeek.Monday)
                {
                    Console.Write("|");
                }

                if (currentDay == day)
                {
                    Console.Write($" {currentDay,2}* |");
                }
                else
                {
                    Console.Write($" {currentDay,2} |");
                }

                if (firstDayOfWeek == DayOfWeek.Sunday)
                {
                    Console.WriteLine();
                }

                firstDayOfWeek = (DayOfWeek)(((int)firstDayOfWeek + 1) % 7);
                currentDay++;
            }
            Console.WriteLine();
        }
    }
}


