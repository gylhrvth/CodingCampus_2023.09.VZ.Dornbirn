using System;
using System.Collections.Generic;
using System.Globalization;


namespace Erik.Week05
{
    public class DateTimeEx
    {
        public static void Start()
        {
            GetDateTime();
            Console.WriteLine();
            GetUserBirthday();
            DateToNextSunday();
        }

        public static void GetDateTime()
        {
            DateTime date = DateTime.Now;
            Console.WriteLine("Today is: " + date.ToString("yyyy, MM, d, h:m:s"));
            //Console.WriteLine(date.ToString("F"));
            //Console.WriteLine(date.ToString("M"));
            //Console.WriteLine(date.ToString("G"));

        }

        public static void GetUserBirthday()
        {
            Console.Write("Enter your Birthday: ");
            DateTime birthday = CheckUserInputValid("Enter your birthday: ");
            Console.WriteLine(birthday.ToString("dddd"));
        }

        public static void DateToNextSunday()
        {
            DateTime dateNow = DateTime.Now;
            dateNow.AddDays(1);

            while (dateNow.DayOfWeek != DayOfWeek.Sunday)
            {
                dateNow = dateNow.AddDays(1);
            }
            Console.WriteLine("Next Sunday is: " + dateNow.ToString("d"));
        }

        //public static int GetSundays(string year, string month)
        //{
        //    DateTime userInputYear = DateTime.Parse(year);
        //    DateTime userInputMonth = DateTime.Parse(month);

        //}

        public static DateTime CheckUserInputValid(string bedinung)
        {
            string userInput = "";
            while (userInput.Length == 0)
            {
                try
                {
                    return DateTime.Parse(Console.ReadLine());
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Invalid input!");
                    Console.Write(bedinung);
                }
            }
            return new DateTime(0);
        }
    }
}
