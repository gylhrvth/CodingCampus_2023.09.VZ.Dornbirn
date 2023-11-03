using System;
namespace Gyula.Week06
{
	public class EnumExample
	{
		public enum WeekDays
		{
			MONDAY,
			TUESDAY,
			WEDNESDAY,
			THURSDAY,
			FRIDAY,
			SATURDAY,
			SUNDAY
		}

		public static void Start()
		{
			WeekDays w = 22;
			for (int i = 0; i < 7; i++)
			{
				PrintName(w);
				++w;
			}
		}

		public static void PrintName(WeekDays wd)
		{
			Console.Write(wd + " ");
			switch (wd)
			{
				case WeekDays.MONDAY:
					Console.WriteLine("Kein Kurs");
				break;
                case WeekDays.TUESDAY:
				case WeekDays.WEDNESDAY:
				case WeekDays.THURSDAY:
				case WeekDays.FRIDAY:
					Console.WriteLine("Es gibt Kurs");
                break;
				default:
					Console.WriteLine("Wochenende");
				break;
            }
        }
	}
}

