using System;
namespace David.Week03
{
    public class Week03Day03RandomArrays
    {
        public static Random rand = new Random(10);


        public static void StartWeek03Day03RandomArrays()
        {
            //----------Random Array 1. 1 - 100 --------------


            Console.WriteLine("Aufgabe Random Number 1 bis 100");
            int[] randarray = RandomA(10); // Hier wird die Methode benennt und die Size definiert.

            Console.WriteLine("");

            //----------Random Array 2. -50 - 50 --------------

            Console.WriteLine("Aufgabe Random Number -50 bis 50");
            int[] Crazy = crazyR(10);
            for (int i = 0; i < 1; i++)
            {
                Console.Write("[{0}]", string.Join(", ", Crazy));
            }
            Console.WriteLine();


            Console.WriteLine("");

            //----------Random Array 3. Zählen--------------

            Console.WriteLine("Aufgabe Random Number Zählen");
            int ergeb = Zaehlen(10);
            Console.WriteLine(ergeb);
            Console.WriteLine();


            //----------Random Array 4. Summe der Werte--------------

            Console.WriteLine("Aufgabe Summe aller Random Zahlen");
            int summe = Summe(10);
            Console.WriteLine(summe);
            Console.WriteLine();

            //--------Aufgabe 5.: Random Number Array Min/Max/Avg------------------

            Console.WriteLine("Random Number Array Min/Max/Avg");
            Console.WriteLine();

            //general, Random numbers from above:

            Console.WriteLine(String.Join(" ", randarray));
            Console.WriteLine();

            // Min
            int min = Min(randarray);
            Console.WriteLine(min);
            int[] test = RandomA(20);

            // Max
            int max = Max(test);
            Console.WriteLine(max);
		
            //indMAX
            int MAXind = indMAX(test);
            Console.WriteLine(MAXind);

            int MINind = indMIN(test);
            Console.WriteLine("new " + MINind);
            

            //Durchscnnitt
            Console.WriteLine();
            int Ave = average(randarray);
            Console.WriteLine(Ave + " = Durchschnitt");
        }

        //----------Random Array 1--------------
        public static int[] RandomA(int size) // Hier wird die Methode und size abgerufen.
        {

            int[] arrayRand1 = new int[size];// Hier wird der eigentliche Arr erstellt und Speicher Reserviert
            for (int i = 0; i < arrayRand1.Length; i++)// Hier werden die Durchläufe festgelegt.
            {
                arrayRand1[i] = rand.Next(0, 101);// Hier wird gesagt was in die Felder kommt.
            }
            foreach (int element in arrayRand1)// für jedes int "element" in Array schreibe ein
            {
                Console.Write(element + ", ");  // element  + ", ".
            }
            Console.WriteLine();
            return arrayRand1;// Hier gitbt "return" den Wert von arrayRanjd1 an die Methode oben zurück.
        }

        // BSP.: Crazy Range -50 - 50

        public static int[] crazyR(int size)
        {
            int[] crazy1 = new int[size];

            for (int i = 0; i < crazy1.Length; i++)
                crazy1[i] = rand.Next(-50, 50);
            return crazy1;
        }

        // BSP.: Anzahl der Werte über 30

        public static int Zaehlen(int size) //Achtung kein "int[]" sondern "int"
        {
            int[] array = new int[size];
            int ergebnis = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(1, 101);

                if (array[i] > 30)
                {
                    ergebnis++;
                }
            }
            return ergebnis;
        }

        // BSP.: Summe aller Werte

        public static int Summe(int size)
        {
            int[] array = new int[size];
            int ergebnis = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(1, 101);
                ergebnis += array[i];
            }

            return ergebnis;
        }

        //--------Aufgabe 5.: Random Number Array Min/Max/Avg------------------

        public static int Min(int[] arr)
        {
            int mindestwert = 101;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < mindestwert)
                {
                    mindestwert = arr[i];
                }
            }
            return mindestwert;
        }
        //--------Aufgabe 5.: Random Number Array MAX------------------

        public static int Max(int[] arr)
        {
            int maximalwert = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > maximalwert)
                {
                    maximalwert = arr[i];
                }
            }
            return maximalwert;
        }

        public static int indMAX(int[] arr)
        {
            int maximalwert = 0;
            int index = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > maximalwert)
                {
                    Console.WriteLine($"Mein Speicher war = {maximalwert}");
                    maximalwert = arr[i];
                    Console.WriteLine($"der neue Speicher ist == {arr[i]}");
                    index = i;
                    Console.WriteLine($"gefunden auf der Postion {i}");
                }

            }
            return index;
        }

        public static int average(int[] arr)
        {
            int summe = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                summe += arr[i];
            }
            summe /= arr.Length;
            return summe;
        }

        public static int indMIN(int[] arr)
        {
            int minimalwert = 0;

            for (int i=0; i <arr.Length; i++)
            {
                if (arr[i] > minimalwert)
                {
                    minimalwert = arr[i];
                }
            }
            return minimalwert;
        }

    }
}
