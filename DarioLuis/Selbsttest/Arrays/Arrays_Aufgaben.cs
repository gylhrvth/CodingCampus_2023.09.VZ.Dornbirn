namespace DarioLuis.Selbsttest.Arrays
{
    public class Arrays_Aufgaben
    {

        int[] arr3 = new int[] { 478199, 7812973, 12387123, 12, 3, 123, 12, 3, 1, 3, 1, 3, 1, 8, 9, 15, 1, 5, 1, 5, 1, 5, 15, 1, 5, 0 };

        public static void Start()
        {
            PrintFirstandLast();
            MinMax();
            PrintAuf3();
            Bubblesort();

        }
        public static void PrintFirstandLast()
        {

            Console.WriteLine("Aufgabe 1");
            Console.WriteLine();

            int[] arr = new int[] { 0, 1, 23, 5, 12, 4, 4, 2, 5, 2, 10 };

            if (arr.Length > 0)
            {
                int firstNum = arr.First();     //Erste Nummer
                int lastNum = arr.Last();       // Letzte Nummer

                Console.WriteLine("First: " + firstNum);
                Console.WriteLine("Last: " + lastNum);
            }
            Console.WriteLine("===================================");
        }
        public static void MinMax()
        {
            Console.WriteLine("Aufgabe 2");
            Console.WriteLine();

            int[] arr2 = new int[] { 123, 19471, 1, 4, 15715, 15, 1, 5, 15, 1, -10, -100 };

            if (arr2.Length > 0)
            {
                int minNum = arr2.Min();    //Minimum Number
                int maxNum = arr2.Max();    //Maximum Number

                Console.WriteLine("Minimum: " + minNum);
                Console.WriteLine("Maximum: " + maxNum);
            }
            Console.WriteLine("===================================");
        }



        static int[] CreateAndPopulateArray(int n)
        {
            int[] arr = new int[n + 1]; // Erstelle ein Array mit der Größe n + 1

            for (int i = 0; i <= n; i++)
            {
                arr[i] = i; // Fülle das Array mit den Zahlen von 0 bis n
            }

            return arr;
        }

        static void PrintAuf3()
        {
            Console.WriteLine("Aufgabe 3");
            Console.WriteLine();

            int n = 10; // Der gewünschte Wert
            int[] arr = CreateAndPopulateArray(n);

            // Ausgabe mit einer for-Schleife
            Console.WriteLine("Ausgabe mit for-Schleife:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            // Ausgabe mit einer foreach-Schleife
            Console.WriteLine("Ausgabe mit foreach-Schleife:");
            foreach (int num in arr)
            {
                Console.WriteLine(num);
            }

            // Ausgabe mit Console.WriteLine und string.Join
            Console.WriteLine("Ausgabe mit Console.WriteLine und string.Join:");
            Console.WriteLine("[{0}]", string.Join(", ", arr));

            Console.WriteLine("===================================");
            
        }

        //Bubble Sort Anfang
        static void Bubblesort()
        {
            int[] numbers = GenerateRandomNumbers(100);

            Console.WriteLine("Aufgabe 4:");
            Console.WriteLine();

            Console.WriteLine("Unsortierte Zahlen:");
            PrintNumbers(numbers);

            Console.WriteLine("\nAufsteigend sortierte Zahlen:");
            BubbleSortAscending(numbers);
            PrintNumbers(numbers);

            Console.WriteLine("\nAbsteigend sortierte Zahlen:");
            BubbleSortDescending(numbers);
            PrintNumbers(numbers);
            Console.WriteLine("===================================");
            Console.WriteLine();
        }

        static int[] GenerateRandomNumbers(int count)
        {
            Random random = new Random();
            int[] numbers = new int[count];

            for (int i = 0; i < count; i++)
            {
                numbers[i] = random.Next(1, 100); // Zufällige Zahlen von 1 bis 99
            }

            return numbers;
        }

        static void BubbleSortAscending(int[] arr)
        {
            int n = arr.Length;
            bool swapped;

            do
            {
                swapped = false;

                for (int i = 0; i < n - 1; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        // Tausche die beiden Zahlen, falls sie in der falschen Reihenfolge sind
                        int temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                        swapped = true;
                    }
                }

            } while (swapped);
        }

        static void BubbleSortDescending(int[] arr)
        {
            int n = arr.Length;
            bool swapped;

            do
            {
                swapped = false;

                for (int i = 0; i < n - 1; i++)
                {
                    if (arr[i] < arr[i + 1])
                    {
                        // Tausche die beiden Zahlen, falls sie in der falschen Reihenfolge sind (absteigend)
                        int temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                        swapped = true;
                    }
                }

            } while (swapped);
        }

        static void PrintNumbers(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
                if ((i + 1) % 10 == 0)
                {
                    Console.WriteLine(); // Neue Zeile nach jeder Gruppe von 10 Zahlen
                }
            }
        }
        //Bubblesort Ende
    }
}



