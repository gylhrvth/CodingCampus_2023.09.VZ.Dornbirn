using System.Data;
using System.Globalization;

namespace Fabian.Selftest_SP
{
    public class Calendar
    {
        public static void Start()
        {
            CurrentDate();
            Console.WriteLine();

            string[] cultureInfo = { "de-DE", "fr-FR", "it-IT", "tr-TR", "hu-HU", "en-US" };
            CurrentDayOfWeek(cultureInfo);
        }

        public static void CurrentDate()
        {
            DateTime t = DateTime.Now;
            Console.WriteLine(t.ToString("ddd") + " " + t.ToString("d"));
        }
        public static void CurrentDayOfWeek(String[] cultureInfo)
        {
            CultureInfo[] cultures = new CultureInfo[cultureInfo.Length];
            DateTime t = DateTime.Now;

            for (int i = 0; i < cultureInfo.Length; i++)
            {
                cultures[i] = new CultureInfo(cultureInfo[i]);
                Console.WriteLine(t.ToString("dddd", cultures[i]));
            }                     
        }
    }
}
