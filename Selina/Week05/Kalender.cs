using System.Globalization;

namespace Selina.Week05
{
    internal class Kalender
    {
        public static CultureInfo austria = new CultureInfo("de-AT");
        public static GregorianCalendar cal = new GregorianCalendar();
        public static void Start()
        {
            //Aufagbe 1:
            PrintDateTime();

            //Aufagbe 2:
            DateTime birthday = DateTime.Now;
            
            birthday = ReadText("\nGib dein Geburtstag ein: ");
            BirthdayOfUser(birthday);
            
            //Aufgabe 3:
            DateTime day = DateTime.Now;
            day = ReadText("\n\nGib das Datum ein: ");
            Sunday(day);
            DateTime sun = Sunday(day);
            Console.WriteLine("{0} - {1}", day.ToString("d"), sun.ToString("d"));

        }

        public static DateTime Sunday(DateTime day)
        {
            int daysUntilNextSunday = 0;
            DayOfWeek currentWeekDay = cal.GetDayOfWeek(day);

            daysUntilNextSunday = (7 - (int)currentWeekDay) % 7;
            day = day.AddDays(daysUntilNextSunday);
        
            return day;
        }
        public static void BirthdayOfUser(DateTime birthay)
        {
            DayOfWeek day = cal.GetDayOfWeek(birthay);
            Day(day);

            Console.Write(birthay.ToString("d", austria));
        }
        public static void PrintDateTime()
        {
            DateTime t = DateTime.Now;

            Console.Write("Datum:                 ");
            Console.WriteLine(t.ToString("d", austria));
            Console.Write("Uhrzeit:               ");
            Console.WriteLine(t.ToString("T", austria));
            Console.Write("Datum und Uhrzeit:     ");
            Console.WriteLine(t.ToString("G", austria));
        }
        public static DateTime ReadText(string prompt)
        {
            Console.Write(prompt);
            while (true)
            {
                try
                {
                    DateTime text = DateTime.Parse(Console.ReadLine());
                    return text;
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                }
            }
        }
        public static DayOfWeek Day(DayOfWeek day)
        {
            switch (day)
            {
                case DayOfWeek.Monday:
                    Console.Write(" Montag ");
                    break;
                case DayOfWeek.Tuesday:
                    Console.Write(" Dienstag ");
                    break;
                case DayOfWeek.Wednesday:
                    Console.Write(" Mittwoch ");
                    break;
                case DayOfWeek.Thursday:
                    Console.Write(" Donnerstag ");
                    break;
                case DayOfWeek.Friday:
                    Console.Write(" Freitag ");
                    break;
                case DayOfWeek.Saturday:
                    Console.Write(" Samstag ");
                    break;
                case DayOfWeek.Sunday:
                    Console.Write(" Sonntag ");
                    break;
            }

            return day;
        }
    }
}
