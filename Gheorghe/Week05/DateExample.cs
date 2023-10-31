using System;
using System.Globalization;
namespace Gheorghe.Week05
{
    internal class DateExample
    {
        public static void Start()
        {

            DateTime date1 = new DateTime(2008, 4, 10);
            Console.WriteLine("'d' standard format string:");
            foreach (var customString in DateTimeFormatInfo.CurrentInfo.GetAllDateTimePatterns('d'))
                Console.WriteLine("   {0}", customString);
            Console.WriteLine(date1.ToString("D",
                  CultureInfo.CreateSpecificCulture("ro-RO")));
            DateTime localDate = DateTime.Now;
            DateTime utcDate = DateTime.UtcNow;
            String[] cultureNames = { "en-US", "en-GB", "fr-FR",
                                "de-DE", "ro-RO" };

            foreach (var cultureName in cultureNames)
            {
                var culture = new CultureInfo(cultureName);
                Console.WriteLine("{0}:", culture.NativeName);
                Console.WriteLine("   Local date and time: {0}, {1:G}",
                                  localDate.ToString(culture), localDate.Kind);
                Console.WriteLine("   UTC date and time: {0}, {1:G}\n",
                                  utcDate.ToString(culture), utcDate.Kind);
            }

        }
    }
}
