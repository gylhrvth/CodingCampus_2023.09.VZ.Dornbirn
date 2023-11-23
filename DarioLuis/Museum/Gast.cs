namespace DarioLuis.Museum
{
    public class Gast
    {
        private static Random rand = new Random();

        private string _Name;
        public bool _IsThief;
        public Raum Aufenthaltsort;
        private int ZeitZuWarten;

        public Gast(string Name, bool IsThief)
        {
            _Name = Name;
            _IsThief = IsThief;
            Aufenthaltsort = null;
        }
        public string Name { get => _Name; }
        public bool IsThief { get; set; }

        public void Ortwechsel(Raum raum)
        {
            if (raum == Aufenthaltsort)
            {
                return;
            }
            
            if (Aufenthaltsort != null)
            {
                Aufenthaltsort.RaumVerlassen(this);
            }
            Aufenthaltsort = raum;
            Aufenthaltsort.RaumEintreten(this);
            ZeitZuWarten = rand.Next(3);
            
        }


        public void Tick()
        {
            if (ZeitZuWarten > 10)
            {
                --ZeitZuWarten;
                Console.WriteLine($"{_Name} macht NIX");
            }
            else
            {
                Raum ziel = Aufenthaltsort.GibEinNachbarRaum();
                if (ziel == null)
                {
                    Console.WriteLine("Es ist nirgendwo zu gehen!!!");
                }
                else
                {
                    Ortwechsel(ziel);
                }
            }
        }
    }
}
