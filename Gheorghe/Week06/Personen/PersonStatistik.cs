namespace Gheorghe.Week06.Personen
{
    public static class PersonStatistik
    {
        public static Person KleinstesElement(List<Person> personen)
        {
            Person kleinstesElement = personen[0];
            for (int i = 1; i < personen.Count; i++)
            {
                if (personen[i].Groesse < kleinstesElement.Groesse)
                {
                    kleinstesElement = personen[i];
                }
            }
            return kleinstesElement;
        }

        public static void Start()
        {
            Console.WriteLine("Hello World! :-)");
        }
    }



}

