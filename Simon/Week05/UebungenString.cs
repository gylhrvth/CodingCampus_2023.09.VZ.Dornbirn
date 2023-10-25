using Simon.Week03;

namespace Simon.Week05
{
    internal class UebungenString
    {
        public static Random random = new Random();
        public static void Start()
        {
            string[] names = new string[] { "Jovo", "Mehmet", "Sven", "Martin", "Selina", "Niklas", "Ali", "Fabienne", "Lukas", "Sandro", "Hassan", "Berna", "Gyula", "Dimitri", "Patrick", "Kerem", "Timo", "Gheorghe", "Mohammed", "Cemal", "Simon", "Fabian", "Dario", "Michael", "Erik", "David", "Riccardo", "Eren" };

            //Console.WriteLine("Bubblesort mit Strings");
            //PrintArrnice(BubbleSortasc(names));

            //Console.WriteLine("\nBubblesort desc");
            //PrintArrnice(BubbleSortdesc(names));

            //Console.WriteLine("\nBubblesort Alphabet asc");
            //PrintArrnice(BubbleSortascabc(names));

            //Console.WriteLine("\nBubblesort Alphabet desc");
            //PrintArrnice(BubbleSortdescabc(names));

            //Console.WriteLine("Bubblesort mit Strings Extended");
            //ChooseBubbleSort(names, true);

            //Console.WriteLine("\nBubblesort mit Strings und Character Index");
            //PrintArrnice(BubbleSortdescindex(names, 2));

            //Console.WriteLine("\nAufgabe Reverse");
            //Console.WriteLine(ReverseString(Console_Input.ReaduserinputString("Gib ein Belibiges Wort ein, welches umgedreht werden soll.")));

            Console.WriteLine("\nAufgabe Randomize");
            Console.WriteLine(RandomString(Console_Input.ReaduserinputString("Gib ein Belibiges Wort ein, welches random ausgegeben wird.")));

            //Console.WriteLine("Test");
            //Console.WriteLine();

        }
        //Aufgabe Bubblesort mit Strings
        public static void PrintArrnice(string[] arr)
        {
            Console.WriteLine("[{0}]", string.Join(", ", arr));
        }
        public static string[] BubbleSortasc(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j].Length > arr[j + 1].Length)
                    {
                        string temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            return arr;
        }
        public static string[] BubbleSortdesc(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j].Length < arr[j + 1].Length)
                    {
                        string temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                    else if (arr[j].Length == arr[j + 1].Length && arr[j].CompareTo(arr[j] + 1) < 0)
                    {
                        string temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            return arr;
        }
        public static string[] BubbleSortascabc(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j].CompareTo(arr[j + 1]) > 0)
                    {
                        string temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            return arr;
        }
        public static string[] BubbleSortdescabc(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j].CompareTo(arr[j + 1]) < 0)
                    {
                        string temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            return arr;
        }
        public static void ChooseBubbleSort(string[] arr, bool asc)
        {
            if (!asc)
            {
                PrintArrnice(BubbleSortdescabc(arr));
            }
            else
            {
                PrintArrnice(BubbleSortascabc(arr));
            }
        }
        public static string[] BubbleSortdescindex(string[] arr, int charIndex)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j][charIndex].CompareTo(arr[j + 1][charIndex]) < 0)
                    {
                        string temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            return arr;
        }
        // Aufgabe Reverse
        public static string ReverseString(string input)
        {
            char[] arr = input.ToCharArray();
            for (int i = 0; i < arr.Length / 2; i++)
            {
                (arr[arr.Length - i - 1], arr[i]) = (arr[i], arr[arr.Length - i - 1]);
            }
            string output = new string(arr);
            return output;
        }
        //Aufgabe Randomize
        public static string RandomString(string input)
        {
            char[] arr = input.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                int j = random.Next(0, arr.Length);
                (arr[j], arr[i]) = (arr[i], arr[j]);
            }
            string output = new(arr);
            return output;
        }
        
        
        
    }
}
