using System;
using System.Globalization;


namespace David.Week05
{
	public class Calendar
	{
		public static void Start()
		{
            DateTime time = DateTime.Now;
            CultureInfo austria = new CultureInfo("de-AT");

			OnlyTheDate(austria, time);

			OnlyTheTime(austria, time);

            DateNTime(austria, time);

            MyBirthday(austria, time);

            WhenIsSunday(austria, time);


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
            Console.WriteLine();
            Console.WriteLine("Wann ist Sonntag?");

            // Erstelle eine neue GregorianCalendar Instanz
            GregorianCalendar calendar = new GregorianCalendar();

            // Bekomme das Datum des heutigen Tages
            DateTime today = DateTime.Now;

            // Berechne den Tag der Woche des heutigen Tages
            DayOfWeek dayOfWeek = today.DayOfWeek;
            Console.WriteLine(dayOfWeek);

            // Berechne die Anzahl der Tage bis zum nächsten Sonntag
            int daysToNextSunday = 7 - (int)dayOfWeek;
            Console.WriteLine(daysToNextSunday);

            // Berechne das Datum des nächsten Sonntags
            DateTime nextSunday = today.AddDays(daysToNextSunday);

            // Gebe das Datum des nächsten Sonntags aus
            Console.WriteLine("Der nächste Sonntag ist: " + nextSunday.ToString("d", austria));
        }

        
    }
}

