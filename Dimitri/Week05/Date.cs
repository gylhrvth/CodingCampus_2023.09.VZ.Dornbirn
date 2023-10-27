using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Text.RegularExpressions;
using System.IO.Compression;

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

            Console.WriteLine(CountDays(2023, 09));
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
                if (dateOfToday.AddDays(i).ToString("f").Contains(day)) {
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

        public static int CountDays(int year, int month)
        {

            int count = 0;


            return count; 
        }
    }
}
