using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Michael.Week01
{
    public class Loops
    {
        public static void Loop()
        {


            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("");

            int counter = 0;

            while (counter <= 10)
            {
                Console.WriteLine(counter);
                counter++;
            }

            Console.WriteLine("");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("");

            counter = 0;

            while (counter < 10)
            {
                Console.WriteLine(counter);
                counter++;
            }

            Console.WriteLine("");

            for (int i = 0; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("");

            for (int i = 0; i <= 10; i = i + 2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("");

            for (int i = 10; i >= -10; i--)
            {
                Console.WriteLine(i);
            }


            /* ~Zeitschleife~ Sandro Bonusaufgabe */

            int duration = 600;
            int hourDigitTen = 0;
            int hourDigitOne = 8;
            int minuteDigitTen = 0;
            int minuteDigitOne = 0;

            for (int minutes = 0; minutes <= duration; minutes++)
            {
                Console.WriteLine($"{hourDigitTen}{hourDigitOne}:{minuteDigitTen}{minuteDigitOne}");

                minuteDigitOne++;

                if (minuteDigitOne == 10)
                {
                    minuteDigitOne = 0;
                    minuteDigitTen++;
                }

                if (minuteDigitTen == 6)
                {
                    minuteDigitTen = 0;
                    hourDigitOne++;
                }

                if (hourDigitOne == 10)
                {
                    hourDigitOne = 0;
                    hourDigitTen++;
                }

            }


            Console.WriteLine("\nalternative version \n");


            
            
            /* alt version*/

            duration = 600;
            hourDigitTen = 0;
            hourDigitOne = 8;
            minuteDigitTen = 0;
            minuteDigitOne = 0;

            for (int minutes = hourDigitTen*600 + hourDigitOne*60 + minuteDigitTen*10 + minuteDigitOne; minutes <= duration + hourDigitTen * 600 + hourDigitOne * 60 + minuteDigitTen * 10 + minuteDigitOne; minutes++)
            {
                Console.WriteLine($"{minutes/600 % 10}{minutes/60 % 10}:{minutes/10 % 6}{minutes % 10 % 60 % 10}");
            }




            /* alt alt version*/



        }
    }
}
