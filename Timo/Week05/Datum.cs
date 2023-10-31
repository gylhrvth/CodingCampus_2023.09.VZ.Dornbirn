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
            Console.WriteLine("Aufgabe 1: Wann und Wo\n");
            //DateTimeSandbox();
            Console.WriteLine("===============================");

            //Aufgabe 2
            Console.WriteLine("Aufgabe 2: Mein Geburtstag\n");
            //Console.WriteLine("Du wurdest an einem >>" + MyBirthday() + "<< geboren");
            Console.WriteLine("===============================");

            //Aufgabe 3 Wann ist Sonntag
            Console.WriteLine("Aufgabe 3: Wann ist Sonntag?\n");
            //Console.WriteLine(WhenSunday(0));                                                                  //int day: 0=Sunday, 1=Monday, 2=Tuesday, 3=Wednesday, 4=Thursday, 5=Friday, 6=Saturday
            Console.WriteLine("===============================");

            //Aufgabe 4 Wie viele Sonntage im Monat
            Console.WriteLine("Aufgabe 4: Wieviele Sonntage hat der Monat?\n");
            //Console.WriteLine("Anzahl des gesuchten Tages im Monat: " + GetSundays(2023, 10, 0));               //int day: 0 =Sunday, 1=Monday, 2=Tuesday, 3=Wednesday, 4=Thursday, 5=Friday, 6=Saturday
            Console.WriteLine("===============================");

            //Aufgabe 4 Wie viele Sonntage im Monat
            Console.WriteLine("Aufgabe 4: Wieviele Sonntage hat der Monat?\n");
            //Console.WriteLine("Anzahl Arbeitstage im Monat: " + GetWorkDays(2023, 10));
            Console.WriteLine("===============================");

            //Aufgabe 5 Kalender
            Console.WriteLine("Aufgabe 5: Kalender\n");
            Calendar(2023, 11, 20);
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

        //-----------------------------------------------------------------------------------------------------------


        //Aufgabe 2 Mein Geburtstag
        public static string MyBirthday()
        {
            Console.WriteLine("Please enter your birthday (dd.mm.yyyy): ");
            string birthdayInput = Console.ReadLine();
            DateTime birthday = DateTime.Parse(birthdayInput);
            string result = birthday.ToString("dddd");

            return result;
        }

        //-----------------------------------------------------------------------------------------------------------


        //Aufgabe 3 Wann ist Sonntag
        public static string WhenSunday(int day)
        {
            DateTime today = DateTime.Today;
            GregorianCalendar gc = new();
            DayOfWeek t = gc.GetDayOfWeek(today);

            int count = 0;
            while ((int)t % 7 != day)
            {
                count++;
                t++;
            }
            DateTime nextSunay = gc.AddDays(today, count);

            return (nextSunay.ToString("d"));
        }

        //-----------------------------------------------------------------------------------------------------------


        //Aufgabe 4 Wie viele Sonntage im Monat
        public static int GetSundays(int year, int month, int day)
        {
            string date = "01." + month + "." + year;
            DateTime time = DateTime.Parse(date);
            GregorianCalendar gc = new();
            DayOfWeek t = gc.GetDayOfWeek(time);
            int count = 0;
            for (int i = 0; i < DateTime.DaysInMonth(year, month); i++)
            {
                if ((int)t % 7 == day)
                {
                    count++;
                }
                t++;
            }
            return count;
        }

        //-----------------------------------------------------------------------------------------------------------


        //Aufgabe 5 Arbeitstage im Monat
        public static int GetWorkDays(int year, int month)
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
            return count;
        }

        //-----------------------------------------------------------------------------------------------------------


        //Aufgabe 5 Kalender

        public static void Calendar(int year, int month, int day)
        {
            GregorianCalendar gc = new();
            string[] headline = { "Mo", "Di", "Mi", "Do", "Fr", "Sa", "So" };
            string currentDate = day + "." + month + "." + year;
            string startDate = "1." + month + "." + year;
            DateTime time = DateTime.Parse(currentDate);
            DateTime startTime = DateTime.Parse(startDate);

            String[,] calendar = new String[6, 7];

            FillBlankCalendar(calendar, gc, startTime);
            PrintTop(year, headline, time);
            PrintCalendar(year, month, day, calendar);


        }
        //Kalender leer füllen bis erster Tag des Monats
        public static void FillBlankCalendar(string[,] calendar, GregorianCalendar gc, DateTime startTime)
        {
            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < ((int)gc.GetDayOfWeek(startTime) + 6) % 7; j++)
                {
                    calendar[i, j] = " ";
                }
            }
        }

        //Monat + Headline
        public static void PrintTop(int year, string[] headline, DateTime time)
        {
            Console.WriteLine(year + " " + time.ToString("MMMM"));

            Console.WriteLine("| {0} | {1} | {2} | {3} | {4} | {5} | {6} |", headline[0], headline[1], headline[2], headline[3], headline[4], headline[5], headline[6]);
        }

        public static void PrintCalendar(int year, int month, int day, string[,] calendar)
        {
            int lastDay = DateTime.DaysInMonth(year, month);
            int count = 1;

            for (int i = 0; i < calendar.GetLength(0); i++)
            {
                for (int j = 0; j < calendar.GetLength(1); j++)
                {
                    if (calendar[i, j] != " ") 
                    {
                        if (count == day)
                        {
                            Console.Write("| {0, 3}", count++ +"*");
                        }
                        else if (count == lastDay+1)
                        {
                            for (int k = 0; k < 7 - j; k++)
                            {
                                Console.Write("| {0, 2} ", " ");
                            }
                            Console.WriteLine("|");
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
