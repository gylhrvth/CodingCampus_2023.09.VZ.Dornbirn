namespace Gheorghe.Week02
{
    internal class Testen2
    {

        public static void Start()
        {
            Console.WriteLine("Aufgabe Summe ist :");
            Summe(5, 10);
            Console.Write("===========================");
            Console.WriteLine();



            Console.Write("Aufgabe Faktorial :");
            PrintFaktorial(20);
            Console.Write("=============================");
            Console.WriteLine();

            Console.WriteLine("Aufgabe FaktorialPlus :");
            PrintFaktorialPlus(1, 20);
            Console.Write("==============================");
            Console.WriteLine();

            Console.WriteLine("Aufgabe Zählen in 0.1");
            PrintCounter(100);
            Console.Write("===========================");
            Console.WriteLine();

            Console.WriteLine("Aufgabe Zählen in 0.1 float");
            PrintCounter2(100);
            Console.Write("==============================================");
            Console.WriteLine();

            Console.WriteLine("Aufgabe Teilen und Herrschen");
            TeilenUndHerrschen(0, 20);
            Console.Write("=============================================");
            Console.WriteLine();

            Console.WriteLine("Aufgabe Leibniz Reihe");
            NilakanthaReihe(2);
            Console.Write("============================================");
            Console.WriteLine();

            Console.WriteLine("Aufgabe Secret Number");
            SecretNumber(10);
            Console.Write("============================================");
            Console.WriteLine();

            Console.WriteLine("Aufgabe Wurzel :");
            Wurzel(10);
            Console.WriteLine("=============================================");
            Console.WriteLine();



        }

        public static int Summe(int number1, int number2)
        {
            int summ = 0;
            for (int i = number1; i <= number2; i++)
            {
                summ += i;
            }
            Console.WriteLine(summ);
            return summ;


        }

        public static long PrintFaktorial(long number2)
        {
            long faktorial = 1;
            for (long i = 1; i <= number2; i++)
            {
                faktorial *= i;
            }
            Console.WriteLine(faktorial);
            return faktorial;
        }

        public static long PrintFaktorialPlus(long number1, long number2)
        {

            for (long i = number1; i <= number2; i++)
            {

                Console.WriteLine("{0, 20}! = {0, -25}", i, PrintFaktorial(i));

            }

            return 0;
        }

        public static double PrintCounter(double number)
        {

            for (double i = 0; i <= number; i += 0.1)
            {

                Console.WriteLine("Result  {0:N1}", i);
                Console.WriteLine($"result {i:N2}");
            }

            return number;
        }

        public static float PrintCounter2(int number)
        {
            int result = 0;
            for (int i = number; i < number * 10; i++)
            {
                result += 10;
                Console.WriteLine(result / 100.0);
                Console.WriteLine("Resultdigit 1 = {0,-3:0.0}", i);
                Console.WriteLine("Resultdigit 2 = {0,7:N2}", i);
            }
            return number;
        }

        public static int TeilenUndHerrschen(int number1, int number2)
        {
            double result = 1.0;
            for (int i = number1; i <= number2; i++)
            {
                result += 10;

                Console.Write("{0, 3} / {1:0.0} =", i, 5);
                Console.WriteLine(i / 5.0);
                Console.Write(" {0, 3} / {1, -3 } =", i, 5);
                Console.WriteLine(i / 5);
            }
            return number2;

        }
        public static int NilakanthaReihe(int number1)
        {
            double pi = 3.0;
            for (int i = 1; i <= 10; i++)
            {
                pi += 4.0 / (2 * i * (i + 1) * (i + 2));


            }

            Console.WriteLine("Pi = {0}", pi);
            return number1;

        }

        public static void Pi2(int number)
        {
            double result = 3;
            for (long index = 2; index < 50000000; index += 2)
            {

                result += (4.0 / (index * (index + 1) * (index + 2)));
                index += 2;
                result -= (4.0 / (index * (index + 1) * (index + 2)));
            }
            Console.WriteLine(result);

        }

        public static double SecretNumber(int number)
        {
            double wert = 1.0;
            for (int i = 0; i < 10; i++)
            {
                wert = wert / 2 + 1 / wert;
                Console.WriteLine($"Wert = {wert,20} / 2 + 1 / {wert}");

            }
            Console.WriteLine();
            return wert;
        }

        static void RandomDouble()
        {
            double random = new Random().Next(10000) + 1;
            Console.WriteLine("rando int ist    = " + random);

            double root = new Random().NextDouble() + 1;
            Console.WriteLine("rando double ist = " + root);

            Console.WriteLine("----------------");

        }
        static double Wurzel(double input)
        {
            // Initialisiere die Anfangswerte
            double mitte = input / 2;
            double minimum = 0;
            double maximum = input;

            // Initialisiere den Index
            int i = 0;

            // Wiederhole den folgenden Schritt, bis die Differenz zwischen der Mitte und der Quadratwurzel kleiner als das Toleranzintervall ist oder die maximale Anzahl der Iterationen erreicht ist
            while (mitte != Math.Sqrt(input))
            {
                // Quadriere die Mitte
                mitte = mitte * mitte;

                // Wenn die Mitte größer als die Zahl ist, dann ist die Wurzel kleiner
                if (mitte > input)
                {
                    maximum = mitte;
                }
                // Wenn die Mitte kleiner als die Zahl ist, dann ist die Wurzel größer
                else
                {
                    minimum = mitte;
                }

                // Setze die Mitte auf die Mitte der beiden Werte
                mitte = (maximum + minimum) / 2;

                // Erhöhe den Index
                i++;
            }

            // Wenn die Schleife noch nicht beendet wurde, dann ist die Zahl nicht reell

            if (i == maximum)
            {
                return -1;
            }
            Console.WriteLine("Die Wurzel der Zahl ist: {0}", Wurzel(input));

            return mitte;
        }



    }

}

