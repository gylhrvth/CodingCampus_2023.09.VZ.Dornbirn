namespace DarioLuis.Week03
{
    public class PascalDreieck
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Geben Sie die Anzahl der Reihen an");
            int reihen = Convert.ToInt16(Console.ReadLine());
            List<int[]> dreieck = DreieckErstellen(reihen);
            WriteToConsole(dreieck);
            Console.ReadKey();
        }

        public static List<int[]> DreieckErstellen(int reihen)
        {
            List<int[]> dreieck = new List<int[]>();
            dreieck.Add(new int[] { 1 });
            if (reihen > 1)
            {
                int[] lastEntry = new int[] { 1, 1 };
                dreieck.Add(lastEntry);
                for (int i = 3; i <= reihen; i++)
                {
                    int[] entry = new int[i];
                    for (int n = 0; n < i; n++)
                    {
                        if (n - 1 < 0)
                            entry[n] = 1;
                        else
                            if (n + 1 > i - 1)
                            entry[n] = 1;
                        else
                            entry[n] = lastEntry[n - 1] + lastEntry[n];
                    }
                    lastEntry = entry;
                    dreieck.Add(entry);
                }
            }
            return dreieck;
        }

        public static void WriteToConsole(List<int[]> dreieck)
        {
            for (int i = 0; i < dreieck.Count; i++)
            {
                foreach (int wert in dreieck[i])
                    Console.Write(wert);
                Console.Write("\n");
            }
        }

        internal static void Main()
        {
            throw new NotImplementedException();
        }
    }
}
