using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Jovo.Week02
{
    internal class UebenPrimitiveDatentypen
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




            Console.WriteLine();

            Console.WriteLine("Aufgabe Summe");
            PrintSummeGanzzahlen(20, 50);
            Console.WriteLine("");

            Console.WriteLine("Aufgabe Faktorial");
            PrintFaktorial(20);
            Console.WriteLine(" ");

            Console.WriteLine("Aufgabe FaktorialBonus");
            PrintFaktorialBonus(1, 20);

            Console.WriteLine("Aufgabe Count");
            PrintCount(0, 100);
            Console.WriteLine(" ");

            Console.WriteLine("Aufgabe Count2");
            PrintCount2(0, 100);
            Console.WriteLine(" ");

            Console.WriteLine("Aufgabe Teilen");
            Printdevide(0, 20);
            Console.WriteLine(" ");

            Console.WriteLine("Aufgabe Pi");
            PrintPi(2, 3);


            Console.WriteLine("Aufgabe GeheimeReihe");
            PrintGeheimeReihe();


            Console.WriteLine("Aufgabe Wurzel");
            PrintWurzel();

            Console.WriteLine("Aufgabe Wurzel2");
            PrintWurzel2();








        }


        //Aufgabe Summe

        public static int PrintSummeGanzzahlen(int number1, int number2)
        {
            int summ = 0;
            for (int i = number1; i <= number2; i++)
            {
                summ = summ + i;

            }
            Console.WriteLine(summ);
            return summ;

        }

        //Aufgabe Faktorial
        
        public static long PrintFaktorial(long number2)
        {
            long summ = 1;
            for (long i= 1; i <= number2; i++)
            {
                summ = summ * i;

            }
            return summ;

        }

        //Aufgabe FaktorialBonus

        public static long PrintFaktorialBonus(long number1, long number2)
        {
            for ( long i = number1; i <= number2; i++)
            {


                Console.WriteLine("{0, 2}! = {1, 20}", i, PrintFaktorial(i));
            }
            return 0;


        }


        //Aufgabe Zählen von 0 bis 100 in 0.1er Schritten

        public static double PrintCount(double number1, double number2)
        {
            for (double i = number1; i <= number2; i += 0.1)
            {
                Console.WriteLine("Result  {0:N1}", i);
                Console.WriteLine($"Result  {i:0.00}");
            }
            return number2;
        }

        // 2.Aufgabe Zählen von 0 bis 100 in 0.1er Schritten

        public static double PrintCount2(int number1, int number2)
        {
            int result = 0;
            for (int i = number1; i < number2 * 10; i++)
            {
                result = result + 10;
                Console.WriteLine(result/100.0);
            }
            return number2;


        }

        //Aufgabe Teilen und Herrschen


        public static double Printdevide(int number1,int number2)
        {
            double result = 0;
            for(int i = number1; i <= number2; i++)
            {
                Console.Write("{0, 3} / {1:0.0} =", i, 5);
                Console.WriteLine(i / 5.0);
                Console.Write("{0, 3} / {1, -3} =", i, 5);
                Console.WriteLine(i / 5);
            }
            return result;

        }


        public static double PrintPi(int number1, int number2)
        {


            double end = 3;
            for(int i = 0; i < 100000; i++)

            {
                double result1 = 4.0 / (number1 * (number1 + 1) * (number1 + 2));
                if (i % 10000 == 0)
                {
                    Console.WriteLine(number1*(number1+1) * (number1 + 2));
                }
                number1++;
                number1++;
                double result2 = 4.0 / (number1 * ( number1 +1 ) * (number1 +2));
                number1++;
                number1++;



                end = end + (result1 - result2);

               

            }


            Console.WriteLine(end);
            return number1;

        }

        public static double PrintGeheimeReihe()
        {
            double result = 1;

            for (int i = 0; i < 20; i++)
            {
                result = (result / 2.0 + 1.0 / result);
                Console.WriteLine(result);

                // Wurzel von 2
            }
            return result;


        }

        public static double PrintWurzel()
        {
            double random = new Random().Next(10000) + 1;
            Console.WriteLine(random);

            for (int i = 0; i<10; i++)
            {



                random = Math.Sqrt(random);
               
                Console.WriteLine(random);


            }
            return random;








        }
        public static double PrintWurzel2()
        {
            double random = new Random().Next(10000) + 1;
            Console.WriteLine(random);
            for ( int i = 0; i < 1; i++)
            {
                random = random / 2;
                Console.WriteLine("hallo" + random);
                random = random * random;
                Console.WriteLine("hallo2" + random);

            }

            return random;


        }

       
        





    }
















    



  

}
