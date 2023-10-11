using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Michael.Week01
{
    public class DataTypes
    {
        
        public static double piLeibniz(int accuracy)
        {
            double piLeib = 0;
            double difference = 10;
            double targetAccuracy = Math.Pow(10, -accuracy);
            double positiveTerm = 0;
            double negativeTerm = 0;
            int i = 0;

            while (difference > targetAccuracy)
                {
                positiveTerm = 4 / (2 * i + 1.0);
                negativeTerm = 4 / (2 * i + 3.0);

                piLeib = piLeib + positiveTerm - negativeTerm;

                difference = (positiveTerm + negativeTerm)/2;

                i += 2;
            }

            //Console.WriteLine($"target accuracy: {accuracy} \npi Leib: {piLeib} \npi Real: {Math.PI} \ndifference: {Math.Abs(piLeib - Math.PI)} \nrelative difference: {Math.Abs(piLeib - Math.PI)/Math.PI * 100}% \niterations: {i}\n\n");

            //return piLeib;

            return i;
        }


        public static int piNilakantha(int accuracy)
        {
            double piNila = 3;
            double difference = 10;
            double targetAccuracy = Math.Pow(10, -accuracy);
            double positiveTerm = 0;
            double negativeTerm = 0;
            int i = 0;

            while (difference > targetAccuracy)
            {
                positiveTerm = 4 / ((2 * i + 2.0) * (2 * i + 3) * (2 * i + 4));
                negativeTerm = 4 / ((2 * i + 3.0) * (2 * i + 4) * (2 * i + 5));

                piNila = piNila + positiveTerm - negativeTerm;

                difference = (positiveTerm + negativeTerm) / 2;

                i += 2;
            }

            //Console.WriteLine($"target accuracy: {accuracy} \npi Nila: {piNila} \npi Real: {Math.PI} \ndifference: {Math.Abs(piNila - Math.PI)} \nrelative difference: {Math.Abs(piNila - Math.PI) / Math.PI * 100}% \niterations: {i}\n\n");

            //return piNila;

            return i;
        }


        public static int piEuler(int accuracy)
        {
            double piEuler = 0;
            double difference = 10;
            double targetAccuracy = Math.Pow(10, -accuracy);
            int i = 0;

            while (difference > targetAccuracy)
            {
                difference = 1 / ((i + 1.0) * (i + 1.0));
                piEuler += difference;
                i += 1;
            }

            //Console.WriteLine($"target accuracy: {accuracy} \npi Eule: {piEuler} \npi Real: {Math.PI} \ndifference: {Math.Abs(piEuler - Math.PI)} \nrelative difference: {Math.Abs(piEuler - Math.PI) / Math.PI * 100}% \niterations: {i}\n\n");

            //return piEuler;

            return i;
        }


        public static double sqrtTwo(int steps)
        {   
            double secretSum = 1.0;

            for (int i = 0; i<steps; i++)
            {
                secretSum = (secretSum / 2) + (1 / secretSum);
            }

            return secretSum;
        }


        public static int sumFromTo(int start, int end)
        {
            int sum = 0;

            for (int i = start; i <= end; i++)
            {
                sum += i;
            }

            return sum;
        }


        public static string showFactorial(int argument)
        {
            long product = 1;
            string returnString = "";

            for (int i = 1; i <= 20; i++)
            {
                product *= i;
                returnString += $"{i,2}! = {product,20}\n";
            }

            return returnString;
        }


        public static void comparePiSeries(int iterations)
        {
            Console.WriteLine($"{"Leibniz",14}" + $"{"leib root",18}" + $"{"Nikalantha",14}" + $"{"Euler",14}" + $"{"euler root",14}");

            for (int i = 0; i < iterations; i++)
            {
                Console.WriteLine($"{piLeibniz(i),14}" + "    " + $"{Math.Pow(piLeibniz(i), 1.0 / 3) / 1.5,14:N5}" + $"{piNilakantha(i),14}" + $"{piEuler(i),14}" + $"{Math.Pow(piEuler(i), 1.0 / 2) * 3,14:N5}");
            }
        }


        public static double calculateSqrt(double input, int iterations)
        {
            double root = input;
            double max = root;
            double min = 0;
            double average = (max + min) / 2;
            double square = 0;

            for (int i = 0; i < iterations; i++)
            {
                average = (max + min) / 2;
                square = Math.Pow(average, 2);

                if (square > root)
                {
                    max = average;
                }
                else
                {
                    min = average;
                }
            }
            return average;
        }


        public static void testSqrt()
        {
            Console.WriteLine($"test for the number {1297419,13}");

            double root = 1297419;
            double max = root;
            double min = 0;
            double average = (max + min) / 2;
            double square = 0;

            int j = 0;
            while (Math.Abs(((average - Math.Sqrt(root)) / Math.Sqrt(root))) >= 0.0001)
            {
                average = (max + min) / 2;
                square = Math.Pow(average, 2);

                if (square > root)
                {
                    max = average;
                }
                else
                {
                    min = average;
                }

                j++;
            }

            Console.WriteLine($"current value: {average,18:N5} \ncorrect value: {Math.Sqrt(root),18:N5} \nerror in %: {Math.Abs(((average - Math.Sqrt(root)) / Math.Sqrt(root)) * 100),20:N5}% \nnach {j} Durchläufen");
        }


        public static void countsFrom0To100()
        {
            //0.1 steps from 0 to 100
            Console.WriteLine("\n\n\n 0.1 steps from 0 to 100\n");

            for (double count = 0; count <= 100; count += 0.1)
            {
                Console.WriteLine("{0:N1}", count);
            }



            //0.1 steps from 0 to 100, different formats
            Console.WriteLine("\n\n\n 0.1 steps from 0 to 100, different formats \n");

            for (double count = 0.1; count <= 100; count += 0.1)
            {
                Console.WriteLine($"{count,-3:0.0}", count);
                Console.WriteLine($"{count,7:0.00}", count);
                Console.WriteLine($"{count,-3:N1}", count);
                Console.WriteLine($"{count,7:N3}", count);
            }


            //0.1 steps from 0 to 100, percentage
            Console.WriteLine("\n\n\n 0.1 steps from 0 to 100, percentage \n");

            double counter = 0;
            while (counter <= 100)
            {
                Console.WriteLine($"Fortschritt: {counter,8:N1}%");
                counter += 0.1;
            }

            for (int i = 0; i <= 20; i++)
            {
                Console.WriteLine($"{i} , {i / 5} , {i / 5.0}");
            }
        }


        public static bool isPrimeSlow(int number)
        {
            for (int i = number-1; i > 1; i--)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }


        public static bool isPrimeFast(int number)
        {
            for (int i = number/2; i > 1; i--)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }


        public static bool isPrimeFaster(int number)
        {
            for (int i = 2; i < number/2+1; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }


        public static bool isPrimeFastest(int number)
        {
            for (int i = 2; i < Math.Sqrt(number)+1; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }


        public static int nthTwinPrimeSlow(int number)
        {
            int twinPrimeCount = 0;
            int prime = 1;

            while (twinPrimeCount < number)
            {
                prime++;
                if (isPrimeSlow(prime) && isPrimeSlow(prime + 2))
                {
                    twinPrimeCount++;
                }
            }
            return prime;
        }


        public static int nthTwinPrimeFast(int number)
        {
            int twinPrimeCount = 0;
            int prime = 1;

            while (twinPrimeCount < number)
            {
                prime++;
                if (isPrimeFast(prime) && isPrimeFast(prime + 2))
                {
                    twinPrimeCount++;
                }
            }
            return prime;
        }


        public static int nthTwinPrimeFaster(int number)
        {
            int twinPrimeCount = 0;
            int prime = 1;

            while (twinPrimeCount < number)
            {
                prime++;
                if (isPrimeFaster(prime) && isPrimeFaster(prime + 2))
                {
                    twinPrimeCount++;
                }
            }
            return prime;
        }


        public static int nthTwinPrimeFastest(int number)
        {
            int twinPrimeCount = 0;
            int prime = 1;

            while (twinPrimeCount < number)
            {
                prime++;
                if (isPrimeFastest(prime) && isPrimeFastest(prime + 2))
                {
                    twinPrimeCount++;
                }
            }
            return prime;
        }


        public static void comparePrimeBoundaries(int number)
        {
            Stopwatch sw = new Stopwatch();
            Console.WriteLine("test slow (full length and backwards)");
            sw.Start();
            int resultSlow = nthTwinPrimeSlow(1000);
            sw.Stop();
            TimeSpan ts = sw.Elapsed;
            Console.WriteLine("Run time {0:00}:{1:00}:{2:00}.{3:000}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
            Console.WriteLine($"{resultSlow} and {resultSlow + 2}\n");

            Console.WriteLine("test fast (half length and backwards)");
            sw.Reset();
            sw.Start();
            int resultFast = nthTwinPrimeFast(1000);
            sw.Stop();
            ts = sw.Elapsed;
            Console.WriteLine("Run time {0:00}:{1:00}:{2:00}.{3:000}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
            Console.WriteLine($"{resultFast} and {resultFast + 2}\n");

            Console.WriteLine("test faster (half length and forwards)");
            sw.Reset();
            sw.Start();
            int resultFaster = nthTwinPrimeFaster(1000);
            sw.Stop();
            ts = sw.Elapsed;
            Console.WriteLine("Run time {0:00}:{1:00}:{2:00}.{3:000}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
            Console.WriteLine($"{resultFaster} and {resultFaster + 2}\n");

            Console.WriteLine("test fastest (sqrt length and forwards)");
            sw.Reset();
            sw.Start();
            int resultFastest = nthTwinPrimeFastest(1000);
            sw.Stop();
            ts = sw.Elapsed;
            Console.WriteLine("Run time {0:00}:{1:00}:{2:00}.{3:000}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds);
            Console.WriteLine($"{resultFastest} and {resultFastest + 2}\n");
        }

        public static void Start()
        {
            int i = 2;
            int n = 0;
            while (true)
            {
                if (isPrimeFast(i))
                {
                    if(true)
                    {
                        Console.WriteLine(i);
                    }
                    n++;
                }
                i++;

            }

        }

    }

}