using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Simon.Selbsttest
{
    internal class Kalender
    {
        public static void Start()
        {
            DateTime todaydate = DateTime.Now;
            Console.Write(todaydate.ToString("ddd") + " ");
            Console.WriteLine(todaydate.ToString("d"));

            string[] cultureInfo = { "de-DE", "fr-FR", "it-IT", "tr-TR", "hu-HU", "en-US" };

            PrinToday(cultureInfo);


        }

        public static void PrinToday (string[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                CultureInfo test = (CultureInfo.GetCultureInfo(arr[i]));
                Console.WriteLine(DateTime.Now.ToString("dddd",test));
                
            }            
        }


    }
}
