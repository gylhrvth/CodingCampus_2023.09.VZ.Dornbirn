using System.Globalization;

namespace DarioLuis.Selbsttest.Calender
{
    public class Calender_Aufgabe
    {
        //Aufgabe 1 Start
        public static void PrintCalender()
        {
            CalenderTime();
            CalenderDate();
            CalenderBoth();
            CalenderDay();
        }
        public static void CalenderTime()
        {
            Console.WriteLine(TimeOnly.FromDateTime(DateTime.Now));
        }
        public static void CalenderDate()
        {
            Console.WriteLine(DateOnly.FromDateTime(DateTime.Now));
        }
        public static void CalenderBoth()
        {
            Console.WriteLine(DateTime.Now);
        }
        //Aufgabe 1 Ende
        ///////////////////////////////////////
        //Aufgabe 2 Start

        public static void CalenderDay()
        {
            DateTime t = DateTime.Now;
            CultureInfo austrian = new CultureInfo("de-AT");
            CultureInfo france = new CultureInfo("fr-Fr");
            CultureInfo italian = new CultureInfo("it-IT");
            CultureInfo spanish = new CultureInfo("es-ES");
            CultureInfo english = new CultureInfo("en-US");


            Console.WriteLine(t.ToString("yyyy.MM.dd"));

            Console.WriteLine(t.ToString(""));

            Console.WriteLine(t.ToString("f", austrian));
            Console.WriteLine(t.ToString("f", france));
            Console.WriteLine(t.ToString("f", italian));
            Console.WriteLine(t.ToString("f", spanish));
            Console.WriteLine(t.ToString("f", english));
        }
    }
}
