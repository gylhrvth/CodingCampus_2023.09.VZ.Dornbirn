namespace Hassan.Week03
{
    public class rehearsal
    {
        public static Random rand = new Random();

        public static void Start()
        {

            /*
                        Console.WriteLine("Orginal");
                        int[] orginal = Array(10);

                        Console.WriteLine("[{0}]", string.Join(", ", orginal));

                        Console.WriteLine();
                        Console.WriteLine("=========");
                        Console.WriteLine("Copy");
                        int[] copy = MakeACopy(orginal);

                        Console.WriteLine("[{0}]", string.Join(", ", copy));


                        Console.WriteLine();
                        Console.WriteLine("=============");
                        Console.WriteLine("Änderung orginal");
                        orginal[3] = 200;
                        Console.WriteLine("[{0}]", string.Join(", ", orginal));
                        Console.WriteLine();
                        Console.WriteLine("Änderung Copy");

                        Console.WriteLine("[{0}]", string.Join(", ", copy));
                        Console.WriteLine();
            */
            int[] arr = GenerateRandomArray(10);
            Console.WriteLine("[{0}]", string.Join(", ", arr));
        }
        public static void PrintArray(int[] arr)
        {
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
        }

        public static int[] Array(int size)
        {
            int[] arr = new int[size];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + 1;
            }
            return arr;

        }

        public static int[] MakeACopy(int[] orginal)
        {
            int[] copy = new int[orginal.Length];

            for (int i = 0; i < orginal.Length; i++)
            {
                copy[i] = orginal[i];
            }
            return copy;

        }

        public static int[] GenerateRandomArray(int size)
        {
            int[] randomArr = new int[size];

            for (int i = 0; i < size; i++)
            {
                randomArr[i] = rand.Next(-50, 51);
            }

            return randomArr;
        }



        public static int ArraySumme(int[] arr)
        {
            int Summe = 0;
            foreach (int element in arr)
            {
                Summe += element;
            }
            return Summe;
        }

        public static double GetArrayAvg(int[] arr)
        {
            double Avg = 0;
            double Summe = 0;
            foreach (double element in arr)
            {
                Summe += element;
            }
            Avg = Summe / arr.Length;
            return Avg;
        }

        public static int GetArrayMax(int[] arr)
        {
            int Max = Int32.MinValue;
            foreach (int element in arr)
            {
                if (element > Max)
                {
                    Max = element;
                }
            }
            return Max;
        }

        public static int GetArrayMin(int[] arr)
        {
            int Min = Int32.MaxValue;
            foreach (int element in arr)
            {
                if (element < Min)
                {
                    Min = element;
                }
            }
            return Min;
        }

    }
}
