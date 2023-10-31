using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Martin.Week06
{
    internal class Calender
    {

        
        public static void Start()
        {
            ShowWatch();
            //Birthday();
            //Sonntag();
            //CounterMonthSunday(2023, 10);
        }

        public static void ShowWatch()
        {
            
            while (true) 
            {
                DateTime time = DateTime.Now;
                Console.Clear();
                Console.WriteLine(time.ToString());
                Console.WriteLine(time.ToString("T"));
                Thread.Sleep(1000); // wartet eine Sekunde
            }
            
        }

        public static void Birthday()
        {
            while (true)
            { 
                try
                {
                    DateTime date = DateTime.Now;
                    GregorianCalendar g = new GregorianCalendar();

                    Console.WriteLine("Wann hast du Geburtstag?");
                    string Antwort = Console.ReadLine();
                    string Geburtsdatum = DateTime.Parse(Antwort).ToString();

                    Console.WriteLine(g.GetDayOfWeek(DateTime.Parse(Antwort)));

                    Console.WriteLine(" Du hast Geburtstag am: {0}", Geburtsdatum);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Das Datum ist falsch geschrieben bitte wiederhole das nochmal");
                }
            }
        }

        public static void Sonntag()
        {
   
            DateTime Data = DateTime.Now;
            Data.AddDays(1);

            while(Data.DayOfWeek != DayOfWeek.Sunday)
            {
                Data = Data.AddDays(1);
            }
            Console.WriteLine("Der nexte Sonntag ist am: " + Data.ToString("d"));

        }

        public static int CounterMonthSunday(int year, int month)
        {
            DateTime date = DateTime.Now;


            for(int i = 0; i < month;)
            {

            }

            return 0;
        }
    }
}
