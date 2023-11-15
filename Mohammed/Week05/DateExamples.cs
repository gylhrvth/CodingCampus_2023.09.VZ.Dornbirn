using System;
using System.Globalization;


namespace Mohammed.Week05
{
	public class DateExamples
	{
		public static void Start()
		{
			DateTimeBox();

			DateOfBirthDay();

			//WhenIsSunday();
		}

		public static void DateTimeBox()
		{
			DateTime t = DateTime.Now;
			CultureInfo austrian = new CultureInfo("de-AT");

			Console.WriteLine(t.ToString("d"));
			Console.WriteLine(t.ToString("d", austrian));

			Console.WriteLine(t.ToString("t"));
			Console.WriteLine(t.ToString("T", austrian));// Der unterschied zwischen Größe T und kleine = krige ich auch sekunde....

			Console.WriteLine(t.ToString("f"));
			Console.WriteLine(t.ToString("f", austrian));

			Console.WriteLine(t.ToString("yyyy.MM.dd.", austrian));

        }

		public static void DateOfBirthDay()
		{
		
			Console.WriteLine("Please enter your birthday (dd.MM.yyyy)");
			try
			{

				string birthDay = Console.ReadLine();
				DateTime date = DateTime.Parse(birthDay);

				GregorianCalendar myCal = new GregorianCalendar();   
				DayOfWeek dayOfWeek = myCal.GetDayOfWeek(date);

				Console.WriteLine("Your birthday was on a {0}.", dayOfWeek);
            }
			catch (FormatException)
			{
				Console.WriteLine("Invalid date format");

			}
			
		}
		

		public static void WhenIsSunday()
		{

            DateTime today = DateTime.Today;
            GregorianCalendar gc = new GregorianCalendar();
            DayOfWeek t = gc.GetDayOfWeek(today);

            int count = 0;
            while (t != DayOfWeek.Saturday + 1)
            {
                count++;
                t++;
            }
            DateTime sunday = gc.AddDays(today, count);

            Console.WriteLine(sunday.ToString("d"));





        }

    }
}

