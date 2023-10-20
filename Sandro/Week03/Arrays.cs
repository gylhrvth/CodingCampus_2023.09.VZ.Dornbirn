using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandro.Week03
{
    internal class Arrays
    {
        public static void Start() {
            string NL = Environment.NewLine; // shortcut
            string NORMAL = "\x1b[39m";
            string RED = "\x1b[91m";
            string GREEN = Console.IsOutputRedirected ? "" : "\x1b[92m";
            string YELLOW = Console.IsOutputRedirected ? "" : "\x1b[93m";
            string BLUE = Console.IsOutputRedirected ? "" : "\x1b[94m";
            string MAGENTA = Console.IsOutputRedirected ? "" : "\x1b[95m";
            string CYAN = Console.IsOutputRedirected ? "" : "\x1b[96m";
            string GREY = Console.IsOutputRedirected ? "" : "\x1b[97m";
            string BOLD = Console.IsOutputRedirected ? "" : "\x1b[1m";
            string NOBOLD = Console.IsOutputRedirected ? "" : "\x1b[22m";
            string UNDERLINE = Console.IsOutputRedirected ? "" : "\x1b[4m";
            string NOUNDERLINE = Console.IsOutputRedirected ? "" : "\x1b[24m";
            string REVERSE = Console.IsOutputRedirected ? "" : "\x1b[7m";
            string NOREVERSE = Console.IsOutputRedirected ? "" : "\x1b[27m";

            int arrayspace = 40;

            Random random = new Random();

            Console.WriteLine("Increasig Array");
            Console.WriteLine("Print function string.Join");
            PrintStringJoin(CreateIncreasingArray(arrayspace));
            Console.WriteLine("Print function for i");
            PrintForI(CreateIncreasingArray(arrayspace));
            Console.WriteLine("Print function forEach");
            PrintForEach(CreateIncreasingArray(arrayspace));
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Decreasig Array");
            Console.WriteLine("Print function string.Join");
            PrintStringJoin(CreateDecreasingArray(arrayspace));
            Console.WriteLine("Print function for i");
            PrintForI(CreateDecreasingArray(arrayspace));
            Console.WriteLine("Print function forEach");
            PrintForEach(CreateDecreasingArray(arrayspace));
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Random Array");
            Console.WriteLine("Print function string.Join");
            PrintStringJoin(CreateRandomNumberArray(arrayspace));
            Console.WriteLine("Print function for i");
            PrintForI(CreateRandomNumberArray(arrayspace));
            Console.WriteLine("Print function forEach");
            PrintForEach(CreateRandomNumberArray(arrayspace));
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Crazy Random Array");
            Console.WriteLine("Print function string.Join");
            PrintStringJoin(CreateCrazyRandomNumberArray(arrayspace));
            Console.WriteLine("Print function for i");
            PrintForI(CreateCrazyRandomNumberArray(arrayspace));
            Console.WriteLine("Print function forEach");
            PrintForEach(CreateCrazyRandomNumberArray(arrayspace));
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Count 30 Plus");
            int[] RandomArray = CreateRandomNumberArray(arrayspace);
            Print30Plus(RandomArray);
            int count = Count30Plus(RandomArray);
            int rest = arrayspace - count;
            Console.WriteLine($"{GREEN}{BOLD}{count,3} {NORMAL} Zahlen sind über 30");
            Console.WriteLine($"{RED}{BOLD}{rest,3} {NORMAL} Zahlen sind {RED} nicht {NORMAL} über 30");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Sum of All");
            PrintForEach(RandomArray);
            int sum = SumofAll(RandomArray);
            Console.WriteLine("Die Summe aller zahlen dieser Array ist = " + sum);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Min/Max/Avg");
            int min = MinCount(RandomArray);
            int max = MaxCount(RandomArray);
            int avg = AvgCount(RandomArray);
            PrintMinMaxAvg(RandomArray, min, max, avg);
            Console.WriteLine($"{GREEN}{min,3} = {NORMAL} ist die kleinste Zahl \n" +
                $"{RED}{max,3} = {NORMAL} ist die größte Zahl \n" +
                $"{YELLOW}{avg,3} = {NORMAL} ist der Durchschnitt aller Zahlen");
            PrintAllIndexMin(AllIndexOf(RandomArray, min));
            PrintAllIndexMax(AllIndexOf(RandomArray, max));
            PrintAllIndexAvg(AllIndexOf(RandomArray, avg));
            Console.WriteLine("-----------------------------------");

        }
        static int[] CreateIncreasingArray(int arrayspace)
        {
            int[] arr = new int[arrayspace];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = 1 + i;
            }

            return arr;
        }
        static int[] CreateDecreasingArray(int arrayspace)
        {
            int[] arr = new int[arrayspace];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = arrayspace - i;

            }
            return arr;
        }
        static int[] CreateRandomNumberArray(int arrayspace)
        {
            Random random = new Random();
            int[] arr = new int[arrayspace];

            for (int i = 0; i < arrayspace; i++)
            {
                arr[i] = random.Next(101); //upper bound eine zahl, für max wert +1
            }
            return arr;
        }
        static int[] CreateCrazyRandomNumberArray(int arrayspace)
        {
            Random random = new Random();
            int[] arr = new int[arrayspace];

            for (int i = 0; i < arrayspace; i++)
            {
                arr[i] = random.Next(-50, 51); //bei 2 inputs, erster für min(kein + oder - 1), zweite für max wert
            }
            return arr;
        }
        static int Count30Plus(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 30)
                {
                    count++;
                }
            }
            return count;
        }
        static int SumofAll(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        static int MinCount(int[] arr)
        {

            int min = 0;
            if (arr.Length > 0)
            {
                min = arr[0];
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            return min;
        }
        static int MaxCount(int[] arr)
        {
            int max = 0;
            if (arr.Length > 0)
            {
                max = arr[0];
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }
        static int AvgCount(int[] arr)
        {
            int avg = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                avg = avg + arr[i];
            }
            return avg / arr.Length;
        }
        static int[] AllIndexOf(int[] arr, int search)
        {
            int counter = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == search)
                {
                    counter++;
                }
            }

            if (counter == 0)
            {
                return null;
            }

            int[] index = new int[counter];
            int pos = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == search)
                {
                    index[pos] = i;
                    pos++;
                }
            }
            return index;
        }

        static void PrintForI(int[] arr)
        {
            Console.Write("[");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]);
                if (i < arr.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.Write("]");
            Console.WriteLine();
        }
        static void Print30Plus(int[] arr)
        {

            Console.Write("[");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 30)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }

                Console.Write(arr[i]);
                if (i < arr.Length - 1)
                {
                    Console.ResetColor();
                    Console.Write(", ");
                }
                Console.ResetColor();
            }
            Console.Write("]");
            Console.WriteLine();
        }
        static void PrintMinMaxAvg(int[] arr, int min, int max, int avg)
        {

            Console.Write("[");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == min)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else if (arr[i] == max)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else if (arr[i] == avg)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }

                Console.Write(arr[i]);
                if (i < arr.Length - 1)
                {
                    Console.ResetColor();
                    Console.Write(", ");
                }
                Console.ResetColor();
            }
            Console.Write("]");
            Console.WriteLine();
        }
        static void PrintStringJoin(int[] arr)
        {
            Console.WriteLine("[{0}]", string.Join(", ", arr));
        }
        static void PrintForEach(int[] arr)
        {
            bool first = true;
            Console.Write("[");
            foreach (int number in arr)
            {
                if (first != true)
                {
                    Console.Write(", ");
                }
                first = false;
                Console.Write(number.ToString());
            }
            Console.WriteLine("]");
        }
        static void PrintAllIndexMin(int[] arr)
        {
            if (arr.Length <= 1)
            {
                Console.Write("Ich habe für den MIN Wert nur einen Index gefunden auf der Position " + arr[0].ToString());
                Console.WriteLine("!");
            }
            else
            {
                bool first = true;
                Console.Write("Ich habe für den MIN Wert mehr als einen Index gefunden auf der Position ");
                foreach (int number in arr)
                {
                    if (first != true)
                    {
                        Console.Write(" und ");
                    }
                    first = false;
                    Console.Write(number.ToString());
                }
                Console.WriteLine("!");
            }
        }
        static void PrintAllIndexMax(int[] arr)
        {
            if (arr.Length <= 1)
            {
                Console.Write("Ich habe für den MAX Wert nur einen Index gefunden auf der Position " + arr[0].ToString());
                Console.WriteLine("!");
            }
            else
            {
                bool first = true;
                Console.Write("Ich habe für den MAX Wert mehr als einen Index gefunden auf der Position ");
                foreach (int number in arr)
                {
                    if (first != true)
                    {
                        Console.Write(" und ");
                    }
                    first = false;
                    Console.Write(number.ToString());
                }
                Console.WriteLine("!");
            }
        }
        static void PrintAllIndexAvg(int[] arr)
        {
            if (arr == null)
            {
                Console.WriteLine("Ich habe für den Avg Wert keinen Index gefunden :(");
            }
            else if (arr.Length <= 1)
            {
                Console.Write("Ich habe für den Avg Wert nur einen Index gefunden auf der Position " + arr[0].ToString());
                Console.WriteLine("!");
            }
            else
            {
                bool first = true;
                Console.Write("Ich habe für den Avg Wert mehr als einen Index gefunden auf der Position ");
                foreach (int number in arr)
                {
                    if (first != true)
                    {
                        Console.Write(" und ");
                    }
                    first = false;
                    Console.Write(number.ToString());
                }
                Console.WriteLine("!");
            }
        }

    }
}
