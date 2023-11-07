namespace Selina.Week05
{
    internal class Daten_tabellarisch_darstellen
    {
        public static void Start()
        {
            int columns = 6;

            string[] firstName = { "Alfonso", "Beatrix-Eleon", "Cecil", "Daniel", "Elmar" };
            string[] lastName = { "Klein", "Kinderdorfer", "Al Elmenar", "Schmidt", "Simma" };
            int[] age = { 40, 78, 5, 18, 81 };
            string[] place = { "Wien", "Schwarzach", "Wiener Neudorf", "Sankt Pölten", "Sankt Pölten" };
            float[] distanceFromCapital = { 0f, 654.4f, 12.457634366f, 120.0f, 119.9999f }; 



            Tabelle(firstName, lastName, age, place, distanceFromCapital);

        }

        public static void AddColumn()
        {

        }
        public static int[] MaxLenghtPerColumn(string[][] table)
        {
            int[] maxWidth = new int[table[0].Length];

            for (int i = 0; i < table.Length; i++)
            {
                for (int j = 0; j < table[i].Length; j++)
                {
                    if (table[i][j].Length > maxWidth[j])
                    {
                        maxWidth[j] = table[i][j].Length;
                    }
                }
            }
            return maxWidth;
        }
        public static void Tabelle(string[] firstName, string[] lastName, int[] age, string[] place, float[] distanceFromCapital)
        {
            Console.WriteLine("{0,-20} {1,-15} {2,-9} {3,-19} {4,-20}", "Vorname", "Nachname", "Alter", "Ort", "Entfernung von Hauptstadt");
            Console.WriteLine(new string('_', 93));
            for (int i = 0; i < firstName.Length; i++)
            {
                Console.WriteLine("{0,-20} {1,-15} {2,-9} {3,-19} {4,-20}", firstName[i], lastName[i], age[i], place[i], distanceFromCapital[i]);
            }
        }
    }
}
