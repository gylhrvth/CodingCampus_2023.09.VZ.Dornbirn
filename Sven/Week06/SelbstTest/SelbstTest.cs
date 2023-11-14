using System.Globalization;

namespace Sven.Week06.SelbstTest
{
    internal class SelbstTest
    {

        public static Random random = new Random();

        public static void Start()
        {
            Console.WriteLine("Schleifen 1:");
            Schleifen1();
            Console.WriteLine();

            Console.WriteLine("Schleifen 2:");
            Schleifen2();
            Console.WriteLine();

            Console.WriteLine("Schleifen 3:");
            Schleifen3();
            Console.WriteLine();

            Console.WriteLine("Methoden 1:");
            Methoden1("x", 10);
            Console.WriteLine();

            Console.WriteLine("Methoden 2:");
            Methoden2("x", 4);
            Console.WriteLine();

            Console.WriteLine("Methoden 3:");
            Methoden3("x", 4);
            Console.WriteLine();

            Console.WriteLine("Methoden 4:");
            Methoden4("x", 4);
            Console.WriteLine();

            Console.WriteLine("Methoden 5:");
            Methoden5("x", 4);
            Console.WriteLine();

            //Console.WriteLine("Input 1:");
            //Input1();
            //Console.WriteLine();

            int[] arr = new int[] { 0, 1, 23, 5, 12, 4, 4, 2, 5, 2, 10 };

            int[] arr2 = new int[] { 123, 19471, 1, 4, 15715, 15, 1, 5, 15, 1, -10, -100 };

            int[] arr3 = new int[] { 478199, 7812973, 12387123, 12, 3, 123, 12, 3, 1, 3, 1, 3, 1, 8, 9, 15, 1, 5, 1, 5, 1, 5, 15, 1, 5, 0 };

            Console.WriteLine("Arrays 1:");
            string result1 = PrintFirstAndLast(arr);
            Console.WriteLine(result1);
            string result2 = PrintFirstAndLast(arr2);
            Console.WriteLine(result2);
            string result3 = PrintFirstAndLast(arr3);
            Console.WriteLine(result3);
            Console.WriteLine();


            Console.WriteLine("Arrays 2:");
            Console.WriteLine("\n1:");
            Console.WriteLine(Getmin(arr));
            Console.WriteLine(Getmax(arr));
            Console.WriteLine(Getavg(arr));

            Console.WriteLine("\n2:");
            Console.WriteLine(Getmin(arr2));
            Console.WriteLine(Getmax(arr2));
            Console.WriteLine(Getavg(arr2));

            Console.WriteLine("\n3:");
            Console.WriteLine(Getmin(arr3));
            Console.WriteLine(Getmax(arr3));
            Console.WriteLine(Getavg(arr3));
            Console.WriteLine();

            Console.WriteLine("Arrays 3:");
            Printarray();
            Console.WriteLine();

            int[] randarr = Randomarray(20);

            Console.WriteLine("Arrays 4 Up:");
            SortUp(randarr);
            Console.WriteLine();

            Console.WriteLine("Arrays 4 Down:");
            SortDown(randarr);
            Console.WriteLine();

            Console.WriteLine("Arrays2D:");
            Array2D(0);
            Console.WriteLine();

            Console.WriteLine("Kalender 1:");
            Kalender();
            Console.WriteLine();

            Console.WriteLine("Arrays2D:");
            Print2DArray(Array2D(0));
            Console.WriteLine();
        }

        public static void Schleifen1()
        {

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

        }

        public static void Schleifen2()
        {
            for (int i = -30; i <= 30; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }

            }
        }

        public static void Schleifen3()
        {
            int i = 0;

            while (i <= 10)
            {
                Console.WriteLine(i);

                if (i > 5)
                {
                    Console.Write("\n\n");
                }
                i++;
            }

        }

        public static void Methoden1(string symbol, int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write(symbol);
            }

        }

        public static void Methoden2(string symbol, int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(symbol + "\n");
            }
        }

        public static void Methoden3(string symbol, int size)
        {
            Methoden1("x", 4);
            Methoden2("x", 4);
        }

        public static void Methoden4(string symbol, int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i == j)
                    {
                        Console.Write(symbol);
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
            }
        }

        public static void Methoden5(string symbol, int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = i; j < size; j++)
                {
                    Console.Write(" ");
                }
                Console.Write(symbol);
                Console.WriteLine();
            }
        }

        static string ReadString()
        {
            string input;
            do
            {
                Console.Write("Gib einen String ein: ");
                input = Console.ReadLine();
            }
            while (string.IsNullOrEmpty(input));

            return input;
        }
        public static int ReadNumber()
        {

            int number;
            bool isValid;
            do
            {
                Console.Write("Gib eine Zahl ein: ");
                isValid = int.TryParse(Console.ReadLine(), out number);
            }
            while (!isValid);

            return number;
        }

        private static void Input1()
        {

            string inputString = ReadString();
            int repeatCount = ReadNumber();

            for (int i = 0; i < repeatCount; i++)
            {
                Console.WriteLine(inputString);
            }

        }

        static string PrintFirstAndLast(int[] arr)
        {

            string combinedString = "First: " + arr[0].ToString() + ", Last: " + arr[arr.Length - 1].ToString();

            return combinedString;
        }

        private static int Getmin(int[] arr)
        {
            int min = int.MaxValue;

            foreach (int i in arr)
            {
                if (i < min)
                {
                    min = i;
                }
            }
            return min;
        }

        private static int Getmax(int[] arr)
        {
            int max = int.MinValue;

            foreach (int i in arr)
            {
                if (i > max)
                {
                    max = i;
                }
            }
            return max;
        }

        private static double Getavg(int[] arr)
        {
            int sum = 0;
            foreach (int i in arr)
            {
                sum += i;
            }

            return (double)sum / arr.Length;

        }

        private static int[] FillArray(int count)
        {
            int[] newArray = new int[count + 1];
            for (int i = 0; i <= count; i++)
            {
                newArray[i] = i;
            }
            return newArray;
        }

        private static void Printarray()
        {

            int count = 10;
            int[] resultArray = FillArray(count);

            Console.WriteLine("Ausgabe mit for:");
            for (int i = 0; i < resultArray.Length; i++)
            {
                Console.Write(resultArray[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Ausgabe mit foreach:");
            foreach (int num in resultArray)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Ausgabe string.Join:");
            Console.WriteLine("[{0}]", string.Join(", ", resultArray));

        }

        private static int[] Randomarray(int size)
        {
            int[] arr = new int[size];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(101);

            }
            return arr;
        }

        private static int[] SortUp(int[] arr)
        {
            int temp = 0;

            for (int count = 0; count < arr.Length - 1; count++)
            {
                for (int sort = 0; sort < arr.Length - 1 - count; sort++)
                {
                    if (arr[sort] > arr[sort + 1])
                    {
                        temp = arr[sort + 1];
                        arr[sort + 1] = arr[sort];
                        arr[sort] = temp;
                    }
                }

            }
            Console.WriteLine(String.Join(", ", arr));
            return arr;
        }

        private static int[] SortDown(int[] arr)
        {

            int temp = 0;

            for (int count = 0; count < arr.Length; count++)
            {
                for (int sort = 0; sort < arr.Length - 1; sort++)
                {
                    if (arr[sort] < arr[sort + 1])
                    {
                        temp = arr[sort + 1];
                        arr[sort + 1] = arr[sort];
                        arr[sort] = temp;
                    }
                }
                Console.WriteLine(String.Join(", ", arr));

            }
            return arr;
        }

        private static int[][] Array2D(int count)
        {


            int[][] arr = new int[10][];
            for (int row = 0; row < arr.Length; row++)
            {
                arr[row] = new int[10];
            }

            for (int row = 0; row < arr.Length; row++)
            {
                for (int col = 0; col < arr[row].Length; col++)
                {
                    arr[row][col] = count++;
                }
            }
            return arr;

        }
        private static void Print2DArray(int[][] arr2d)
        {


            for (int row = 0; row < arr2d.Length; row++)
            {
                for (int col = 0; col < arr2d[row].Length; col++)
                {
                    Console.Write(arr2d[row][col] + " ");
                }
                Console.WriteLine();

            }
        }

        private static void Kalender()
        {
            DateTime t = DateTime.Now;
            CultureInfo austrian = new CultureInfo("de-AT");

            Console.WriteLine(t.ToString("ddd d.M.yyyy", austrian));

            string[] cultureInfo = { "de-DE", "fr-FR", "it-IT", "tr-TR", "hu-HU", "en-US" };

            foreach (string culture in cultureInfo)
            {
                DateTime currentDate = DateTime.Now;
                string formattedDate = currentDate.ToString("dddd", new CultureInfo(culture));
                Console.WriteLine($"{culture}: {formattedDate}");
            }
        }



    }
}





