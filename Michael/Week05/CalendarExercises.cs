using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Michael.Week05
{
    internal class CalendarExercises
    {
        public static void CurrentTime()
        {
            DateTime now = DateTime.Now;

            Console.WriteLine(now.ToString("dd/MM/yyyy"));
            Console.WriteLine(now.ToString("hh:mm:ss"));
            Console.WriteLine(now.ToString("dd/MM/yy hh:mm:ss"));
        }


        public static void DayOfYourBirth()
        {
            DateTime defaultDay = new DateTime(0);
            DateTime birthday = new DateTime(0);

            Console.WriteLine("please enter your birthday ( dd/mm/yyyy )");

            while (birthday == defaultDay)
            {
                try
                {
                    birthday = DateTime.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("sorry, not a valid date. use ( dd/mm/yyyy )");
                }

            }

            Console.WriteLine("\nthat birthday was on a " + birthday.DayOfWeek);
        }


        public static void NextSunday()
        {
            DateTime currentTime = DateTime.Now;
            currentTime = currentTime.AddDays(1);

            while (currentTime.DayOfWeek != DayOfWeek.Sunday)
            {
                currentTime = currentTime.AddDays(1);
            }

            Console.WriteLine("the next sunday is on " + currentTime.ToString("dd/MM/yyyy"));
        }

        
        public static int GetSundays(int year, int month)
        {
            DateTime testMonth = DateTime.Parse("01/" + month + "/" + year);

            var currentMonth = testMonth.Month;
            int countSundays = 0;

            while (testMonth.Month == currentMonth)
            {
                if (testMonth.DayOfWeek == DayOfWeek.Sunday)
                {
                    countSundays++;
                }

                testMonth = testMonth.AddDays(1);
            }

            return countSundays;
        }


        public static int GetWorkdays(int year, int month)
        {
            DateTime testMonth = DateTime.Parse("01/" + month + "/" + year);

            var currentMonth = testMonth.Month;
            int countSundays = 0;

            while (testMonth.Month == currentMonth)
            {
                if ((testMonth.DayOfWeek != DayOfWeek.Sunday) &&
                    (testMonth.DayOfWeek != DayOfWeek.Saturday))
                {
                    countSundays++;
                }

                testMonth = testMonth.AddDays(1);
            }

            return countSundays;
        }

        /*
        public static void PrintCalendar(int year, int month)
        {
            DateTime today = DateTime.Today;
            Console.WriteLine($"{year} {month}");

            string[,] calendarEntries = new string[5, 7];
            int start = 0;

            

            }
        }
        */


    }
}
