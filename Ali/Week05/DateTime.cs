using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ali.Week05
{
    public class DateTimeEX
    {
        public static void Start()
        {


            //Console.WriteLine("Aufgabe Wann und wo?");
            //Console.WriteLine("");
            //DatetimeSandbox();
            //Console.WriteLine();

            Console.WriteLine("Mein Geburtstag");
            Console.WriteLine("");
            BirthDay();
            Console.WriteLine();

            //Console.WriteLine("Aufgabe: Wann ist Sonntag?");
            //Console.WriteLine();



        }
        public static void DatetimeSandbox()
        {
            DateTime t = DateTime.Now;
            Console.WriteLine(t.ToString("d"));
            Console.WriteLine(t.ToString("t"));
            Console.WriteLine(t.ToString("g"));
        }
        public static void BirthDay()
        {
            Console.WriteLine("Geben Sie ihr Geburstag ein");
            DateTime t = DateTime.Now;
            string input = Console.ReadLine();
            try
            {
                DateTime userinput = DateTime.Parse(input);
                GregorianCalendar cal = new GregorianCalendar();
                Console.WriteLine("Your birthday is on {0}",cal.GetDayOfWeek(userinput));
                Console.WriteLine("dein geburtstag wäre am {0}" ,userinput.ToString("dddd", new CultureInfo("de-CH")));
            }
            catch(Exception)
            {
                Console.WriteLine("Falscher Formatstyp. Gebe Sie ein Datum ein: Tag/Monat/Jahr (in Zahlen)");
            }

        }
        public static void Sunday()
        {

        }
        
            
        
    }
    
    

    
}
