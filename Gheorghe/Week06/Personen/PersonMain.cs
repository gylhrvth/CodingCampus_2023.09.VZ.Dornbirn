namespace Gheorghe.Week06.Personen
{
    public class PersonMain
    {
        public static void Start()
        {
            // Erstelle eine liste von Personen
            List<Person> personen = new List<Person>();






            //Gebe  das kleinstes Element aus
            Person KleinstesElement = PersonStatistik.KleinstesElement(personen);
            Console.WriteLine("KleinstesElement: {0}", KleinstesElement.Name);

        }
    }
}
