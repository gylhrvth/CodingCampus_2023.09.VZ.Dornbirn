namespace Selina.Week06.Liste
{
    public class List
    {
        public static Random random = new Random();
        public static void Start()
        {
            List<int> listRandomNumbers = new List<int>();

            ListRandomNumbers(listRandomNumbers, 20);
            PrintList(listRandomNumbers);

            int count = CountRandomNumbers(listRandomNumbers);
            Console.WriteLine($"\n\n - Es sind {count,14} gerade Zahlen.");

            int min = FindMin(listRandomNumbers);
            Console.WriteLine($" - Das Minimum ist: {min,5}");

            int max = FindMax(listRandomNumbers);
            Console.WriteLine($" - Das Maximum ist : {max,4}");

            Console.Write(" - Sortiert:         ");
            Sort(listRandomNumbers);
            PrintList(listRandomNumbers);

            Console.Write("\n - Nur Gerade Zahlen:");
            List<int> newList = RemoveNumbers(listRandomNumbers);
            PrintList(newList);

            // Zwei Listen:

            List<int> list1 = new List<int>();
            List<int> list2 = new List<int>();
            List<int> list3 = new List<int>();

            ListRandomNumbers(list1, 20);
            ListRandomNumbers(list2, 20);
            Sort(list1);
            Sort(list2);
            Console.WriteLine("\n\nZeite Liste: ");
            PrintList(list2);
            Console.WriteLine("\nErste Liste: ");
            PrintList(list1);

            list3 = AddList(list1, list2);

            Sort(list3);
            Console.WriteLine("\nAlle Listen: ");
            PrintList(list3);


        }
        public static List<int> ListRandomNumbers(List<int> listRandomNumbers, int size)
        {
            for (int i = 0; i <= size; i++)
            {
                listRandomNumbers.Add(random.Next(0, 100));
            }

            return listRandomNumbers;
        }
        public static void PrintList(List<int> listRandomNumbers)
        {
            foreach (int i in listRandomNumbers)
            {
                Console.Write($"{i,4}");
            }
        }
        public static int CountRandomNumbers(List<int> listRandomNumber)
        {
            int count = 0;
            count = listRandomNumber.Count(num => num % 2 == 0);
            return count;
        }
        public static int FindMin(List<int> listRandomNumbers)
        {
            int min = listRandomNumbers[0];
            for (int i = 0; i < listRandomNumbers.Count; i++)
            {
                if (listRandomNumbers[i] < min)
                {
                    min = listRandomNumbers[i];
                }
            }
            return min;
        }
        public static int FindMax(List<int> listRandomNumbers)
        {
            int max = listRandomNumbers[0];
            for (int i = 0; i < listRandomNumbers.Count; i++)
            {
                if (listRandomNumbers[i] > max)
                {
                    max = listRandomNumbers[i];
                }
            }
            return max;
        }
        public static void Sort(List<int> listRandomNumbers)
        {
            for (int i = 0; i < listRandomNumbers.Count; i++)
            {
                for (int j = 0; j < listRandomNumbers.Count - i - 1; j++)
                {
                    if (listRandomNumbers[j] > listRandomNumbers[j + 1])
                    {
                        int temp = listRandomNumbers[j];
                        listRandomNumbers[j] = listRandomNumbers[j + 1];
                        listRandomNumbers[j + 1] = temp;
                    }
                }
            }
        }
        public static List<int> RemoveNumbers(List<int> listRandomNumbers)
        {
            listRandomNumbers.RemoveAll(number => number % 2 != 0);
            return listRandomNumbers;
        }
        public static List<int> AddList(List<int> list1, List<int> list2)
        {
            List<int> list3 = new List<int>();

            foreach(int i in list1)
            {
                list3.Add(i);
            }
            foreach(int i in list2)
            {
                list3.Add(i);
            }
            return list3;
        }
    }
}

