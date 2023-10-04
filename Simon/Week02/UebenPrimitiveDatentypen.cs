using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Simon.Week02
{
    public class UebenPrimitiveDatentypen
    {
        public static void Start()
        {
            bool isNumber = true;
            Console.WriteLine(isNumber);

            bool isBig = false;
            Console.WriteLine(isBig);

            Console.WriteLine("!false : " + !false);
            Console.WriteLine("!true  : " + !true);

            Console.WriteLine("true and true   :" + (true && true));
            Console.WriteLine("true and false  :" + (true && false));
            Console.WriteLine("false and true  :" + (false && true));
            Console.WriteLine("false and false :" + (false && false));

            Console.WriteLine("true or true   :" + (true || true));
            Console.WriteLine("true or false  :" + (true || false));
            Console.WriteLine("false or true  :" + (false || true));
            Console.WriteLine("false or false :" + (false || false));

            int iX = 5;
            Console.WriteLine("i == 5: " + (iX == 5));
            Console.WriteLine("i != 5: " + (iX != 5));
            Console.WriteLine("i <  7: " + (iX < 7));
            Console.WriteLine("i <= 7: " + (iX <= 7));
            Console.WriteLine("i >  7: " + (iX > 7));
            Console.WriteLine("i >= 7: " + (iX >= 7));


            int size = 7;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i == j)
                    {
                        Console.Write("X ");
                    }
                    else
                    {
                        Console.Write(". ");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine("Aufgabe Summe");
            PrintSummeGanzzahlen(20, 25);

            Console.WriteLine("Aufgabe Faktorial");
            PrintFaktorial(1, 20);

        }
        //Aufgabe Summe
        public static void PrintSummeGanzzahlen(int number1, int number2)
        {
            int summ = 0;
            for (int i = number1; i <= number2; i++)
            {
                summ = summ + i;

            }
            Console.WriteLine(summ);
        }
        //Aufgabe Summe
        public static void PrintFaktor(long number1, long number2)
        {
            long summ = 1;
            for (long i = number1; i <= number2; i++)
            {
                summ = summ * i;

            }
            Console.WriteLine(summ);
        }




        //Aufgabe Faktorial
        public static void PrintFaktorial(long number1, long number2)
        {
            //int faktorial = 0;
            for (long i = number1; i <= number2; i++)
            {
                //for(int j = 0; j < i; j++) 
                //{
                Console.Write(i);
                Console.Write("!=");
                PrintFaktor(1, i);
                //}
            }
        }

    }
}
