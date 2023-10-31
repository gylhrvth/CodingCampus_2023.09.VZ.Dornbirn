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

            DateTime date = new DateTime(1991, 11, 10);

            PrintCalendar(date);
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

        public static void PrintCalendar(DateTime date)
        {
            Console.WriteLine(date.ToString("yyyy MMMM"));
            string[] header = new string[7] { "Mo", "Di", "Mi", "Do", "Fr", "Sa", "So" };
            PrintArrayHeader(header, "|");

            Print2DStringArrayCalendar(FillArrayCalandar(CreateArrayCalendar(date), date));
        }


        public static string[][] CreateArrayCalendar(DateTime date)
        {
            int month = calendar.GetMonth(date);
            int year = calendar.GetYear(date);
            int daysInMonth = calendar.GetDaysInMonth(year, month);
            DateTime firstOfMonth = new DateTime(year, month, 1);


            if (daysInMonth == 28 && calendar.GetDayOfWeek(firstOfMonth) == DayOfWeek.Monday)
            {
                string[][] arr = new string[4][];

                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = new string[7];
                }
                return arr;

            }
            else if ((daysInMonth == 30 || daysInMonth == 31) && calendar.GetDayOfWeek(firstOfMonth) == DayOfWeek.Sunday)
            {
                string[][] arr = new string[6][];

                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = new string[7];
                }
                return arr;
            }
            else if (daysInMonth == 31 && calendar.GetDayOfWeek(firstOfMonth) == DayOfWeek.Saturday)
            {
                string[][] arr = new string[6][];

                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = new string[7];
                }
                return arr;
            }
            else
            {
                string[][] arr = new string[5][];

                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = new string[7];
                }
                return arr;
            }


        }

        public static GregorianCalendar calendar = new GregorianCalendar();

        public static string[][] FillArrayCalandar(string[][] calendarTable, DateTime date)
        {
            int month = calendar.GetMonth(date);
            int year = calendar.GetYear(date);
            int daysInMonth = calendar.GetDaysInMonth(year, month);
            DateTime firstOfMonth = new DateTime(year, month, 1);

            int numberOfFields = 0;

            foreach (string[] field in calendarTable)
            {
                foreach (string field2 in field)
                {
                    numberOfFields++;
                }

            }

            int emptyBeginning = 0;

            switch (calendar.GetDayOfWeek(firstOfMonth))
            {
                case DayOfWeek.Monday:
                    emptyBeginning = 0;
                    break;
                case DayOfWeek.Tuesday:
                    emptyBeginning = 1;
                    break;
                case DayOfWeek.Wednesday:
                    emptyBeginning = 2;
                    break;
                case DayOfWeek.Thursday:
                    emptyBeginning = 3;
                    break;
                case DayOfWeek.Friday:
                    emptyBeginning = 4;
                    break;
                case DayOfWeek.Saturday:
                    emptyBeginning = 5;
                    break;
                case DayOfWeek.Sunday:
                    emptyBeginning = 6;
                    break;
            }

            int emptyEnd = 0;

            emptyEnd = numberOfFields - (emptyBeginning + daysInMonth);



            int i = 0;
            while (i < emptyBeginning)
            {
                calendarTable[0][i] = "";
                i++;

            }

            int days = 1;

            while (days <= daysInMonth)
            {

                for (int k = 0; k < calendarTable.Length; k++)
                {
                    if (k == 0)
                    {
                        for (int l = emptyBeginning; l < calendarTable[k].Length; l++)
                        {
                            calendarTable[k][l] = days.ToString();
                            days++;

                        }
                    }
                    else
                    {
                        for (int l = 0; l < calendarTable[k].Length; l++)
                        {
                            calendarTable[k][l] = days.ToString();
                            days++;

                        }
                    }

                }

            }

            int j = 0;
            if (calendarTable.Length == 6)
            {
                while (j < emptyEnd)
                {
                    calendarTable[5][6 - j] = "";
                    j++;

                }
            }
            else if (calendarTable.Length == 5)
            {
                while (j < emptyEnd)
                {
                    calendarTable[4][6 - j] = "";
                    j++;

                }

            }



            string today = calendar.GetDayOfMonth(date).ToString();



            for (int m = 0; m < calendarTable.Length; m++)
            {
                for (int n = 0; n < calendarTable[m].Length; n++)
                {
                    if (calendarTable[m][n].CompareTo(today) == 0)
                    {
                        calendarTable[m][n] = calendarTable[m][n] + "*";
                    }
                }
            }


            return calendarTable;
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
                    else if (month[i][j].CompareTo("") == 0)
                    {
                        Console.Write("    |", month[i][j]);
                    }
                    else if (month[i][j].Contains("*"))
                    {
                        Console.Write(" {0}|", month[i][j]);
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
