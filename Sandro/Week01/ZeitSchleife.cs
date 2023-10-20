using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandro.Week01
{
    internal class ZeitSchleife
    {
        public static void Start()
        {
            Console.WriteLine("Aufgabe die Zeitschleife");
            Console.WriteLine();

            //clock1();
            clock2();

        }

        static void clock1()
        {
            for (int i = 0; i <= 600; i++)
            {
                string CurrentHour = (i / 60) + 8 + "";
                string CurrentMinute = i % 60 + "";

                if (CurrentHour.Length < 1)
                {
                    CurrentHour = "00";
                }
                else if (CurrentHour.Length < 2)
                {
                    CurrentHour = "0" + CurrentHour;
                }

                if (CurrentMinute.Length < 1)
                {
                    CurrentMinute = "00";
                }
                else if (CurrentMinute.Length < 2)
                {
                    CurrentMinute = "0" + CurrentMinute;
                }

                string Time = CurrentHour + ":" + CurrentMinute;

                Console.WriteLine("Time: " + Time);

            }

        }

        static void clock2()
        {
            int Hours = 8;
            int MinuteFront = 0;
            int MinuteBack = 0;


            for (int i = 0; i <= 600; i++)
            {
                if (i != 0)
                {
                    if (i % 60 == 0)
                    {
                        Hours++;
                    }

                    if (i % 10 == 0)
                    {

                        MinuteFront += 1;
                        if (MinuteFront == 6)
                        {
                            MinuteFront = 0;
                        }
                    }
                    MinuteBack += 1;

                    if (MinuteBack == 10)
                    {
                        MinuteBack = 0;
                    }
                }

                string Time = Hours + ":" + MinuteFront + MinuteBack;
                Console.WriteLine("Time 1: " + Hours + ":" + MinuteFront + MinuteBack);
                Console.WriteLine("Time 2: " + Time);

            }

            // Console.WriteLine("Time: " + Time);

        }
    }
}
