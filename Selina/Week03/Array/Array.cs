namespace Selina.Week03
{
    using Selina.Week04.Ausagbe;
    using System;


    internal class Array
    {
        public static Random rand = new Random();


        public static void Start()
        {
            // Aufagbe 1:
            Ausgabe.Output("Number Array\n", ConsoleColor.Red);
            int size = CreateArray.ReadNumber("Geben Sie die Größe des Arrays ein:", "Sie müssen eine Zahl eingeben!");     //Input User wir in size gespeichert
            int[] randomArray = new int[size];

            int[] resultArray1 = CreateArray1(size);    //Input User wird in einem Array gespeichert und geordnet ausgegeben 
            int[] resultArray2 = CreateArray2(size);

            Console.WriteLine("\nDas Array ist:");  //Output für den User
            Ausgabe.OutputForUser(resultArray1);
            Ausgabe.OutputForUser(resultArray2);
            Console.WriteLine("\n----------------------------------------------------------");


            // Aufagbe 2:
            Ausgabe.Output("Kopie", ConsoleColor.Yellow);
            int[] copyArray = MakeCopy(resultArray1);       //resultArray1 wird kopiert und in copyArray gespeichert
            MakeCopy(resultArray1);
            Ausgabe.OutputForUser(copyArray);   //Output für den User
            Console.WriteLine("\n----------------------------------------------------------");


            // Aufagbe 3:
            Ausgabe.Output("Random Number Array", ConsoleColor.Green);
            randomArray = CreateArray.CreateRandomArray(size, 0, 101 );  //macht Array mit random Zahlen von 0 bis 100
            Ausgabe.OutputForUser(randomArray);     //Output für User

            Console.WriteLine("\n\nJeder Zweiter Wert:");   //Gibt jeden zweiten Wert von dem Array aus
            for (int i = 1; i < randomArray.Length; i += 2)
            {
                Console.Write("[{0}] ", string.Join(", ", randomArray[i]));
            }

            Console.WriteLine("\n\nZweite Wert, Fünfte Wert und Zehnte Wert:");     //Gibt den 2, 5 und den 10 Wert eines Arrays aus
            if (randomArray.Length >= 1)
            {
                Console.Write($"Array 2  : [{randomArray[1]}]");
            }
            if (randomArray.Length >= 5)
            {
                Console.WriteLine($"\nArray 5  : [{randomArray[4]}]");
            }
            if (randomArray.Length >= 9)
            {
                Console.WriteLine($"Array 10  : [{randomArray[9]}]");
            }
            else
            {
                Console.WriteLine();
            }
            Console.WriteLine("\n----------------------------------------------------------");


            //Aufagbe 4:
            Ausgabe.Output("Random Number Array Crazy Range", ConsoleColor.Blue);
            randomArray = CreateArray.CreateRandomArray(size, -50, 51);     //macht Array mit random Zahlen von -50 bis 50
            Ausgabe.OutputForUser(randomArray);     //Output für User
            Console.WriteLine("\n----------------------------------------------------------");


            //Aufagbe 5:
            Ausgabe.Output("Random Number Array Zählen\n", ConsoleColor.Magenta);
            randomArray = CreateArray.CreateRandomArray(size, 1, 101);  //macht Array mit random Zahlen von 1 bis 100
            int count = CreateArray.CountOver30(randomArray);
            Console.WriteLine($"{count} Werte sind über 30");
            Ausgabe.OutputForUser(randomArray);     //Output für User
            Console.WriteLine("\n----------------------------------------------------------");


            //Aufagbe 6:
            Ausgabe.Output("Random Number Array Summe", ConsoleColor.DarkBlue);
            int[] randomArraySum = CreateArray.CreateRandomArray(size, 1, 101);     //macht Array mit random Zahlen von 1 bis 100

            bool first = true;
            Console.Write("\n[ ");
            foreach (int num in randomArraySum)     //Output für User
            {
                if (!first)
                {
                    Console.Write(" + ");
                }
                Console.Write(num);
                first = false;
            }
            Console.Write(" ]");
            Console.WriteLine(" = " + Summe(randomArraySum));   //Output Summe für User
            Console.WriteLine("----------------------------------------------------------");


            //Aufgabe 7:
            Ausgabe.Output("Random Number Array Min / Max / Avg\n", ConsoleColor.Cyan);

            randomArray = CreateArray.CreateRandomArray(size, 1, 101);  //macht Array mit random Zahlen von 1 bis 100
            int min = RandomNumberArrayMin(randomArray);     //RandomNumberArrayMin gibt das Min von Array
            int max = RandomNumberArrayMax(randomArray);    //RandomNumberArrayMax gibt das Max von Array
            double avg = RandomNumberArrayAvg(randomArray);  //RandomNumberArrayAvg gibt das Avg von Array
            Ausgabe.OutputForUser(randomArray);
            Console.Write($"Das Min ist = [{min}]\nDas Max ist = [{max}]\nDer Avg ist = [{avg}]"); //Output for User
            Console.WriteLine("\n----------------------------------------------------------");

        }
        // Aufgabe 1: Number Array
        public static int[] CreateArray2(int size)
        {
            int[] newArray = new int[size];
            for (int i = 0; i < size; i++)
            {
                newArray[i] = size - i;
            }
            return newArray;
        }
        public static int[] CreateArray1(int size)
        {
            int[] newArray = new int[size];
            for (int i = 0; i < size; i++)
            {
                newArray[i] = i + 1;
            }
            return newArray;
        }

        //Aufagbe 2: KOPIE
        public static int[] MakeCopy(int[] original)
        {
            int[] copyArray = new int[original.Length];
            for (int i = 0; i < original.Length; i++)
            {
                copyArray[i] = original[i];
            }
            return copyArray;
        }

        //Aufagbe 6: Random Number Array Summe
        public static int Summe(int[] randomArraySum)
        {
            int sum = 0;
            for (int i = 0; i < randomArraySum.Length; i++)
            {
                sum += randomArraySum[i];
            }
            return sum;
        }

        //Aufagbe 7: Random Number Array Min/Max/Avg
        public static int RandomNumberArrayMin(int[] randomArray)
        {
            int min = randomArray[0];
            for (int i = 1; i < randomArray.Length; i++)
            {
                if (randomArray[i] < min)
                {
                    min = randomArray[i];
                }
            }
            return min;
        }
        public static int RandomNumberArrayMax(int[] randomArray)
        {
            int max = randomArray[0];
            for (int i = 1; i < randomArray.Length; i++)
            {
                if (randomArray[i] > max)
                {
                    max = randomArray[i];
                }
            }

            return max;
        }
        public static double RandomNumberArrayAvg(int[] randomArray)
        {
            double avg = 0.0;
            int sum = Summe(randomArray);
            avg = (double)sum / randomArray.Length;
            return avg;
        }
    }
}



