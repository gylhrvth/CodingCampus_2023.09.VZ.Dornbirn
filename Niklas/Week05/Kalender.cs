using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Niklas.Week05
{
    internal class Kalender
    {
        public static void Start()
        {
            When();
            Console.WriteLine();
            Birthday();
            Console.WriteLine();
            Sunday();
            HowManySundays();
            HowManyWorkdays();
            Calendar();
        }
        public static void When()
        {
            try
            {
                DateTime t = DateTime.Now;

                Console.WriteLine("Date only: " + t.ToString("d"));
                Console.WriteLine("Time only: " + t.ToString("t"));
                Console.WriteLine("Both: " + t.ToString("g"));
            }
            catch (Exception ex)
            {

            }
        }
        public static void Birthday()
        {
            try
            {
                Console.Write("Please enter the day you where born: ");
                int d = Convert.ToInt32(Console.ReadLine());

                Console.Write("Please enter the month you where born: ");
                int m = Convert.ToInt32(Console.ReadLine());

                Console.Write("Please enter the year you where born: ");
                int y = Convert.ToInt32(Console.ReadLine());

                string b = y + "." + m + "." + d;

                //DateTime date = new DateTime(y, m, d);
                DateTime a = DateTime.Parse(b);
                GregorianCalendar gre = new GregorianCalendar();
                DayOfWeek dow = gre.GetDayOfWeek(a);
                //Console.WriteLine(gre.ToString("Your w\"h\"ere born on a " + a));
                Console.WriteLine("You where born on a: " + dow);
            }
            catch (Exception exc)
            {

            }

        }
        public static void Sunday()
        {
            DateTime t = DateTime.Now;
            GregorianCalendar cal = new GregorianCalendar();
            Console.WriteLine("Today is: " + cal.GetDayOfWeek(t) + ", " + cal.GetDayOfMonth(t) + ".");

            while (cal.GetDayOfWeek(t) != DayOfWeek.Sunday)
            {
                t = cal.AddDays(t, 1);
            }

            Console.WriteLine("The next sunday is on: " + t.ToString("d"));
            Console.Write("The next sunday is on a: " + cal.GetDayOfMonth(t));

            if (cal.GetDayOfMonth(t) == 1)
            {
                Console.WriteLine("st.");
            }
            else if (cal.GetDayOfMonth(t) == 2)
            {
                Console.WriteLine("nd.");
            }
            else if (cal.GetDayOfMonth(t) == 3)
            {
                Console.WriteLine("rd.");
            }
            else if (cal.GetDayOfMonth(t) > 3 && cal.GetDayOfMonth(t) < 21)
            {
                Console.WriteLine("th.");
            }
            if (cal.GetDayOfMonth(t) == 21)
            {
                Console.WriteLine("st.");
            }
            else if (cal.GetDayOfMonth(t) == 22)
            {
                Console.WriteLine("nd.");
            }
            else if (cal.GetDayOfMonth(t) == 23)
            {
                Console.WriteLine("rd.");
            }
            else if (cal.GetDayOfMonth(t) > 23 && cal.GetDayOfMonth(t) < 31)
            {
                Console.WriteLine("th.");
            }
            else if (cal.GetDayOfMonth(t) == 31)
            {
                Console.WriteLine("st.");
            }
        }
        public static void HowManySundays()
        {
            Console.Write("What year do you choose? ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.Write("What month do you choose? ");
            int m = Convert.ToInt32(Console.ReadLine());

            DateTime date = new DateTime(y, m, 1);
            int sundays = 0;

            GregorianCalendar cal = new GregorianCalendar();

            while (cal.GetMonth(date) == m)
            {
                if (cal.GetDayOfWeek(date) == DayOfWeek.Sunday)
                {
                    sundays++;
                    date = cal.AddDays(date, 7);
                }
                else
                {
                    date = cal.AddDays(date, 1);
                }
            }
            Console.WriteLine("Your month has: " + sundays + " sundays");
        }
        public static void HowManyWorkdays()
        {
            Console.Write("What year do you choose? ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.Write("What month do you choose? ");
            int m = Convert.ToInt32(Console.ReadLine());

            DateTime date = new DateTime(y, m, 1);
            int workdays = 0;

            GregorianCalendar cal = new GregorianCalendar();

            while (cal.GetMonth(date) == m)
            {

                if (cal.GetDayOfWeek(date) == DayOfWeek.Monday)
                {
                    workdays++;
                    date = cal.AddDays(date, 1);
                }
                else if (cal.GetDayOfWeek(date) == DayOfWeek.Tuesday)
                {
                    workdays++;
                    date = cal.AddDays(date, 1);
                }
                else if (cal.GetDayOfWeek(date) == DayOfWeek.Wednesday)
                {
                    workdays++;
                    date = cal.AddDays(date, 1);
                }
                else if (cal.GetDayOfWeek(date) == DayOfWeek.Thursday)
                {
                    workdays++;
                    date = cal.AddDays(date, 1);
                }
                else if (cal.GetDayOfWeek(date) == DayOfWeek.Friday)
                {
                    workdays++;
                    date = cal.AddDays(date, 1);
                }
                else
                {
                    while (cal.GetDayOfWeek(date) == DayOfWeek.Sunday || cal.GetDayOfWeek(date) == DayOfWeek.Saturday)
                    {
                        date = cal.AddDays(date, 1);
                    }
                }
            }
            Console.WriteLine("Your month has: " + workdays + " workdays");
        }
        public static void Calendar()
        {
            Console.Write("What year do you choose? ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.Write("What month do you choose? ");
            int m = Convert.ToInt32(Console.ReadLine());

            DateTime date = new DateTime(y, m, 1);
            int workdays = 0;

            GregorianCalendar cal = new GregorianCalendar();

            string days = ("| Mo | Di | Mi | Do | Fr | Sa | So |");

            string space = new string(Convert.ToChar(" "), 0);
            string underscore = new string(Convert.ToChar("_"), 130);

            Console.WriteLine(days);

            while (cal.GetMonth(date) == m)
            {

                if (cal.GetDayOfWeek(date) == DayOfWeek.Monday)
                {
                    workdays++;
                    date = cal.AddDays(date, 1);
                }
                else if (cal.GetDayOfWeek(date) == DayOfWeek.Tuesday)
                {
                    workdays++;
                    date = cal.AddDays(date, 1);
                }
                else if (cal.GetDayOfWeek(date) == DayOfWeek.Wednesday)
                {
                    workdays++;
                    date = cal.AddDays(date, 1);
                }
                else if (cal.GetDayOfWeek(date) == DayOfWeek.Thursday)
                {
                    workdays++;
                    date = cal.AddDays(date, 1);
                }
                else if (cal.GetDayOfWeek(date) == DayOfWeek.Friday)
                {
                    workdays++;
                    date = cal.AddDays(date, 1);
                }
                else
                {
                    while (cal.GetDayOfWeek(date) == DayOfWeek.Sunday || cal.GetDayOfWeek(date) == DayOfWeek.Saturday)
                    {
                        date = cal.AddDays(date, 1);
                    }
                }
            }
            Console.WriteLine(workdays);

            //for (int i = 0; i < age.Length; i++)
            //{
            //    Console.Write("|{0}", string.Join(space, $"{firstName[i],-25}") + $"{"|"}" + string.Join(space, $"{lastName[i],-12}") + space + $"{"|",16}" + string.Join(space, $"{age[i],-2}") + space + $"{"|",21}" + string.Join(space, $"{place[i],-22}") + space + "|" + string.Join(space, $"{distanceFromCapital[i],-8}") + "\n");
            //}
            //Console.WriteLine(underscore);
        }
    }
}
