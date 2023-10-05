namespace Selina.Week02
{
    internal class Datentypen
    {
        public static void Start()
        {
            double result = 0;

            //Aufagbe 1 / SUMME --> GREEN
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nAufagabe 1:\n");
            Calculate(result);

            //Aufagbe 2 / FAKTORIAL --> RED
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\nAufagabe 2:\n");
            Factorial(result);

            //Aufagbe 3 / 0,1 Schritte --> MAGENTA
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\nAufagabe 3:\n");
            Count(result);

            //Aufagbe 4 / Teilen und Herrschen --> YELLOW
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\nAufagabe 4:\n");
            DivideAndConquer(result);

            //Aufagabe 5 / Pi Leibniz --> CYAN
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n\nAufagabe 5:\n");
            CalculatePiLeibniz(result);

            //Aufagbe 6 / Pi Nilakantha --> WHITE
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\nAufagabe 6:\n");
            CalculatePiNilakantha(result);

            //Aufagbe 7 / Geheime Reihe --> WHITE
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\nAufagabe 7:\n");
            Row(result);

            // Aufgabe 8 / Wurzel --> Gray
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n\nAufagabe 8:\n");
            Wurzel(result);
        }



        private static double Wurzel(double result)
        {
            double random = new Random().Next(1000) + 1;
            double max = 0;
            double min = 0;
            double number;

            max = random;
            number = random / 2;

            do
            {
                if (Math.Pow(number, 2) > max)
                {
                    max = Math.Pow(number, 2);
                }
                else if (Math.Pow(number, 2) < max)
                {
                    min = Math.Pow(number, 2);
                }

            } while (min == max);

            result = min;

            Console.WriteLine(max);
            Console.WriteLine(min);


            return result;
        }


        /// <summary>
        /// Aufgabe : Starte eine neue Reihe mit dem Wert 0,1 --> WERTN + 1 = WERTN/2 + 1/WERTN
        /// </summary>
        /// <param name="result"></param>
        /// <returns>result</returns>
        private static double Row(double result)
        {
            /* WertN/2 erhöt sich mit 0,5 Schritten!
             * 1/WertN wird immer kleiner und die Nachkommastellen sind meisten nach jeder 3 Rechnung periodisch!
             */

            for (double number1 = 1.0; number1 <= 30; number1++)
            {
                result += number1 + 1;
                result = (number1 / 2) + (1 / number1);
                Console.WriteLine($"{result,-20} =  {number1 / 2,-4}  +  {1 / number1,-7} ");
            }

            return result;
        }


        /// <summary>
        /// Aufgabe : Rechne die Annäherung von Pi mit der Formel π = 3 + 4/(2*3*4) - 4/(4*5*6) + 4/(6*7*8) - 4/(8*9*10) + 4/(10*11*12) - 4/(12*13*14)
        /// </summary>
        /// <param name="result"></param>
        /// <returns>result</returns>
        private static double CalculatePiNilakantha(double result)
        {
            double pi = 3;
            double n = 1000000;
            double number1 = 2.0;

            for (int i = 0; i < n; i++)
            {
                double x = 4 / (number1 * (number1 + 1) * (number1 + 2));
                if (i % 2 == 0)
                {
                    pi += x;
                }
                else
                {
                    pi -= x;
                }
                number1 = number1 + 2;
            }
            result = pi;
            Console.WriteLine("Pi: " + result);
            return result;
        }


        /// <summary>
        /// Aufgabe : Rechne die Annäherung von Pi mit der Formel π = 3 + 4/(2*3*4) - 4/(4*5*6) + 4/(6*7*8) - 4/(8*9*10) + 4/(10*11*12) - 4/(12*13*14)
        /// </summary>
        /// <param name="result"></param>
        /// <returns>result</returns>
        private static double CalculatePiLeibniz(double result)
        {
            double pi = 0.0;
            double n = 1000000;
            double number1 = 1;

            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    pi += (4 / number1);
                }
                else
                {
                    pi -= (4 / number1);
                }
                number1 = number1 + 2;
            }
            result = pi;
            Console.WriteLine("Pi: " + result);
            return result;
        }


        /// <summary>
        /// Aufgabe : Erstelle eine Funktion, die von 0 bis 20 zählt und die folgende Daten ausdruckt.
        /// </summary>
        /// <param name="result"></param>
        /// <returns>result</returns>
        private static double DivideAndConquer(double result)
        {
            double number1 = 5;
            for (double number = 0; number <= 20; number++)
            {
                result = number / number1;
                Console.WriteLine($"{number,3} / {number1} = {result,7:f2}");
                Console.WriteLine($"{number,3} / {number1:N1} = {result,5:f2}");


            }
            return result;
        }


        /// <summary>
        /// Aufagbe : Erstelle eine Funktion, die von 0 bis 100 in 0.1er Schritten zählt, und alle werte ausgibt. 
        /// </summary>
        /// <param name="result"></param>
        /// <returns>result</returns>
        private static double Count(double result)
        {

            for (double number = 0; number <= 1000; number++)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Result 1 ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("digit ");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"= {number / 10.0,9:N1} ");

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Result 2 ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("digit ");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"= {number / 10.0:N2} ");
            }
            return result;
        }


        /// <summary>
        /// Aufagbe : Erstelle eine Funktion, die von 1 bis 20 alle Faktorial ausrechnet und ausgibt.
        /// </summary>
        /// <param name="result"></param>
        /// <returns>result</returns>
        private static double Factorial(double result)
        {
            long number;
            long factorial = 1;
            for (number = 1; number <= 20; number++)
            {
                factorial = factorial * number;
                Console.WriteLine($"{number,5}! =  {factorial,20}");
            }
            return result = (double)factorial;
        }


        /// <summary>
        /// Aufgabe : Erstelle eine Funktion, die von 20 bis 50 alle Ganzzahlen nimmt und deren Summe ausrechnet.
        /// </summary>
        /// <param name="result"></param>
        /// <returns>result</returns>
        private static double Calculate(double result)
        {
            for (int number = 20; number <= 50; number++)
            {
                if (number == 20)
                {
                    Console.Write($"{number}");
                }
                else if (number > 20)
                {
                    Console.Write($" + {number}");
                }

                result = result + number;

            }
            Console.WriteLine($" = {result}");
            return result;
        }
    }
}


