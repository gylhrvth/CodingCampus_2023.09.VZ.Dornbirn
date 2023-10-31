using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon.Week05.Kalender
{
    internal class Kalender
    {
        public static GregorianCalendar cal = new GregorianCalendar();
        public static void Start()
        {

            PrintKalender(2022, "April");

        }

        public static void PrintKalender(int year, string month)
        {
            Console.WriteLine(year + " " + month);
            string[] weekdays = { "Mo", "Di", "Mi", "Do", "Fr", "Sa", "So" };
            for (int i = 0; i < weekdays.Length; i++)
            {
                Console.Write("| {0,2} |", weekdays[i]);
            }
            Console.WriteLine();
            Print2darr(CreateKal());
        }
        public static void Print2darr(string[][] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write("| {0,2} |", arr[i][j]);
                }
                Console.WriteLine();
            }
        }
        public static string[][] CreateKal()
        {
            string[][] arr = new string[6][];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new string[7];
                for (int j = 0; j < arr[i].Length; j++)
                {
                }
            }

            return arr;
        }

        public static string[][] fill1row(string[][] arr, int year, int month)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                DateTime t = new DateTime(year, month, 1);
                DayOfWeek dayOfWeek = cal.GetDayOfWeek(t);
                //int count = 0;
                while ((int)dayOfWeek % (7 -i) != 0)
                {
                    arr[0][i] = " ";
                    break;
                    //count++;
                }
                
            }
            Console.WriteLine(arr);
            return arr;
        }


    }
}
