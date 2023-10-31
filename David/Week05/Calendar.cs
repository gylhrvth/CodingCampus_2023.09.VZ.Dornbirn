using System;
using System.Collections.Concurrent;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace David.Week05
{
    public class Calendar
    {
        public static void Start()
        {
            DateTime time = DateTime.Now;
            CultureInfo austria = new CultureInfo("de-AT");

            //OnlyTheDate(austria, time);

            //OnlyTheTime(austria, time);

            //DateNTime(austria, time);

            //MyBirthday(austria, time);

            //WhenIsSunday(austria, time);

            
            Console.WriteLine(HowManySundays(2023, 10));

            Console.WriteLine(HowManySaturdays(2023, 10));
            Console.WriteLine(DateTime.DaysInMonth(2023, 10));
           

            int days = HowManyWorkdays(2023, 10);
            Console.WriteLine(HowManyWorkdays(2023, 10));

            Console.WriteLine(Workdays(2023, 10));

           
           // PrintCalendar(FillArrayCalendar(CreateArrayCalendar(2023, 10, 28)));

        }

        public static void OnlyTheDate(CultureInfo austria, DateTime time)
        {

            //Datum
            Console.WriteLine("Nur das Datum:");
            Console.WriteLine(time.ToString("d", austria));
            Console.WriteLine();

        }

        public static void OnlyTheTime(CultureInfo austria, DateTime time)
        {
            //Uhrzeit
            Console.WriteLine("Nur die Uhrzeit:");
            Console.WriteLine(time.ToString("t", austria));
            Console.WriteLine();
        }

        public static void DateNTime(CultureInfo austria, DateTime time)
        {
            //Datum und Uhrzeit
            Console.WriteLine("Datum und Uhrzeit:");
            Console.WriteLine(time.ToString("s", austria));
            Console.WriteLine();
        }

        public static void MyBirthday(CultureInfo austria, DateTime time)
        {
            //mein Geburtstag
            Console.WriteLine("Mein Geburtstag:");
            Console.WriteLine();


            Console.WriteLine("Please inser your B-Day in the following format, dd.mm.yyyy:");
            try
            {
                DateTime userBday = DateTime.Parse(Console.ReadLine());
                Console.WriteLine();
            }
            catch (FormatException)
            {

                Console.WriteLine("Please re-enter (dd.mm.yyyy):");
            }
        }

        public static void WhenIsSunday(CultureInfo austria, DateTime time)
        {

            //Wann ist Sonntag?
            // Erstelle eine neue GregorianCalendar Instanz
            // Bekomme das Datum des heutigen Tages
            // Berechne den Tag der Woche des heutigen Tages
            // Berechne die Anzahl der Tage bis zum nächsten Sonntag
            // Berechne das Datum des nächsten Sonntags
            // Gebe das Datum des nächsten Sonntags aus

            Console.WriteLine();
            Console.WriteLine("Wann ist Sonntag?");

            GregorianCalendar calendar = new GregorianCalendar();

            DateTime today = DateTime.Now;

            DayOfWeek dayOfWeek = today.DayOfWeek;
            Console.WriteLine(dayOfWeek);

            int daysToNextSunday = 7 - (int)dayOfWeek;
            Console.WriteLine(daysToNextSunday);
            Console.WriteLine((int)dayOfWeek);
            DateTime nextSunday = today.AddDays(daysToNextSunday);

            Console.WriteLine("Der nächste Sonntag ist: " + nextSunday.ToString("d", austria));
        }

        public static int HowManySundays(int year, int month)
        {
            GregorianCalendar calendar = new GregorianCalendar();
            int count = 0;
            int monthLength = DateTime.DaysInMonth(year, month);

            DateTime firstOfMonth = new DateTime(year, month, 1);

            for (int i = 0; i < monthLength; i++)
            {
                if (calendar.GetDayOfWeek(firstOfMonth.AddDays(i)) == DayOfWeek.Sunday)
                {
                    count++;
                }
            }
            return count;
        }

        //Version I:
        public static int HowManyWorkdays(int year, int month)
        {
            GregorianCalendar calendar = new GregorianCalendar();
            int count = 0;
            int monthLength = DateTime.DaysInMonth(year, month);

            DateTime firstOfMonth = new DateTime(year, month, 1);

            for (int i = 0; i < monthLength; i++)
            {
                if (calendar.GetDayOfWeek(firstOfMonth.AddDays(i)) != DayOfWeek.Sunday && calendar.GetDayOfWeek(firstOfMonth.AddDays(i)) != DayOfWeek.Saturday)
                    count++;
            }

            return count;

        }

        //VersionII:
        public static int HowManySaturdays(int year, int month)
        {
            GregorianCalendar calendar = new GregorianCalendar();
            int count = 0;
            int monthLength = DateTime.DaysInMonth(year, month);

            DateTime firstOfMonth = new DateTime(year, month, 1);

            for (int i = 0; i < monthLength; i++)
            {
                if (calendar.GetDayOfWeek(firstOfMonth.AddDays(i)) == DayOfWeek.Saturday)
                {
                    count++;
                }
            }
            return count;
        }

        public static int Workdays(int year, int month)
        {
            return DateTime.DaysInMonth(year, month) - HowManySundays(year, month) - HowManySaturdays(year, month);
        }



        public static void PrintCalendar(string[][] month, DateTime date)
        {
            
            Console.WriteLine(date.ToString("yyyy mmmm"));
           // string[] header = new string[7] {}
            Console.WriteLine("Mo | Di | Mi | Do | Fr | Sa | So |");
            Print2DStringArray(month);
          
        }

        public static string[][] CreateArrayCalendar(int year, int month)
        {
            string[][] calendar = new string[4][];

            for (int i = 0; i < calendar.Length; i++)
            {
                calendar[i] = new string[7];
            }
            return calendar;
        }

        //public static string[][] FillArrayCalendar(string[][] month)
        //{
        //    string[][] arr = CreateArrayCalendar();
        //    int day = 0;

        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        for (int j = 0; j < arr[0].Length; j++)
        //        {
        //            arr[i][j] = day.ToString();
        //            day++;
        //        }
        //    }
        //}

        public static void Print2DStringArray(string[][] month)
        {
            for (int i = 0; i < month.Length; i++)
            {
                Console.WriteLine("| ");
                for (int j = 0; j < month[i].Length; j++)
                {
                    Console.Write("{0}" + month[i][j]);
                }
                Console.Write(" |");
                Console.WriteLine();
            }
        }

    }
}

        
    

