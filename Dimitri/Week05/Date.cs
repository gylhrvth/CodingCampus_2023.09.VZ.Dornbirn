using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Text.RegularExpressions;
using System.IO.Compression;
using Microsoft.VisualBasic;
using Dimitri.Week01;

namespace Dimitri.Week05
{
    internal class Date
    {
        public static void Main()
        {
            //    FormatTime();
            //MyBirthday();
            //Console.WriteLine(DateOfNextDay("Friday"));
            //DateTime dateOfToday = DateTime.Now;
            //for (int i = 0; i < 7; i++)
            //{
            //    Console.WriteLine(dateOfToday.AddDays(i).ToString("f"));
            //}

            //DayOfWeek day = DayOfWeek.Sunday;

            //Console.WriteLine(DateOfNextWeekday(day).ToString("d"));

            //Console.WriteLine(GetSundays(2023, 10));

            //Console.WriteLine(GetWorkdays(2023,10));

            //Console.WriteLine(GetWorkdays(2021, 3));

            //Console.WriteLine(GetWorkdays(2021, 2));

            PrintCalendar(FillArrayCalandar(CreateArrayCalendar()), DateTime.Now);
        }

        public static void FormatTime()
        {
            DateTime t = DateTime.Now;
            CultureInfo austria = new CultureInfo("de-AT");

            Console.WriteLine("print date:");
            Console.WriteLine(t.ToString("d", austria));

            Console.WriteLine("Print time:");
            Console.WriteLine(t.ToString("t", austria));


            Console.WriteLine("Print time:");
            Console.WriteLine(t.ToString("g", austria));

            Console.WriteLine("custom date/time format:");
            Console.WriteLine(t.ToString("yyyyMMdd-Thh:mm"));
        }

        public static void MyBirthday()
        {
            CultureInfo austria = new CultureInfo("de-AT");
            Console.WriteLine("Write down your birthday in the format dd.MM.yyyy");
            string birthDay = string.Empty;
            DateTime birthDate = DateTime.MinValue;
            while (birthDate == DateTime.MinValue)
            {
                birthDay = Console.ReadLine();
                try
                {
                    birthDate = DateTime.Parse(birthDay, austria);

                }
                catch (FormatException fe)
                {
                    Console.WriteLine("Not a valid Date format. Please Try again with the format dd.MM.yyyy:");
                }
                catch (ArgumentNullException fe)
                {
                    Console.WriteLine("Not a valid Date format. Please Try again with the format dd.MM.yyyy:");
                }

            }

            Console.WriteLine(birthDate.ToString("dddd", austria));
        }

        public static string DateOfNextDayWithStrings(string day)
        {


            DateTime dateOfToday = DateTime.Now;
            DateTime nextDay = DateTime.MinValue;
            for (int i = 0; i < 7; i++)
            {
                //Console.WriteLine(dateOfToday.ToString("f"));
                if (dateOfToday.AddDays(i).ToString("f").Contains(day))
                {
                    nextDay = dateOfToday.AddDays(i);
                    return nextDay.ToString("d");
                }

            }

            return DateTime.Now.ToString("d");
        }

        public static DateTime DateOfNextWeekday(DayOfWeek weekDay)
        {
            GregorianCalendar calendar = new GregorianCalendar();


            for (int i = 0; i < 7; i++)
            {

                if (calendar.GetDayOfWeek(DateTime.Now.AddDays(i)) == weekDay)
                {
                    return DateTime.Now.AddDays(i);
                }
            }

            return DateTime.Now;
        }

        public static int GetSundays(int year, int month)
        {

            int count = 0;

            GregorianCalendar calendar = new GregorianCalendar();

            int daysInMonth = DateTime.DaysInMonth(year, month);

            DateTime firstDayOfMonth = new DateTime(year, month, 1);

            for (int i = 0; i < daysInMonth; i++)
            {
                if (calendar.GetDayOfWeek(firstDayOfMonth.AddDays(i)) == DayOfWeek.Sunday)
                {
                    count++;
                }

            }

            return count;
        }

        public static int GetSaturdays(int year, int month)
        {

            int count = 0;

            GregorianCalendar calendar = new GregorianCalendar();

            int daysInMonth = DateTime.DaysInMonth(year, month);

            DateTime firstDayOfMonth = new DateTime(year, month, 1);

            for (int i = 0; i < daysInMonth; i++)
            {
                if (calendar.GetDayOfWeek(firstDayOfMonth.AddDays(i)) == DayOfWeek.Saturday)
                {
                    count++;
                }

            }

            return count;
        }

        public static int GetWorkdays(int year, int month)
        {
            return DateTime.DaysInMonth(year, month) - GetSaturdays(year, month) - GetSundays(year, month);
        }

        public static void PrintCalendar(string[][] month, DateTime date)
        {
            Console.WriteLine(date.ToString("yyyy MMMM"));
            string[] header = new string[7] { "Mo", "Di", "Mi", "Do", "Fr", "Sa", "So" };
            PrintArrayHeader(header, "|");
            Print2DStringArrayCalendar(month);
        }


        public static string[][] CreateArrayCalendar()
        {
            string[][] arr = new string[4][];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new string[7];
            }

            return arr;
        }

        public static string[][] FillArrayCalandar(string[][] month)
        {
            string[][] arr = CreateArrayCalendar();

            int day = 1;


            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[0].Length; j++)
                {
                    arr[i][j] = day.ToString();
                    day++;
                }
            }

            return arr;
        }

        public static void Print2DStringArrayCalendar(string[][] month)
        {
            for (int i = 0; i < month.Length; i++)
            {
                Console.Write("|");
                for (int j = 0; j < month[i].Length; j++)
                {
                    if (month[i][j].Length == 1)
                    {
                        Console.Write("  {0:1} |", month[i][j]);
                    }
                    else
                    {
                        Console.Write(" {0} |", month[i][j]);
                    }

                }
                Console.WriteLine();
            }


        }

        public static void PrintArrayHeader(string[] arr, string delimiter)
        {


            Console.Write("{0}", delimiter);

            for (int i = 0; i < arr.Length; i++)
            {

                Console.Write(" {0} {1}", arr[i], delimiter);
            }
            Console.WriteLine();
        }
    }
}
