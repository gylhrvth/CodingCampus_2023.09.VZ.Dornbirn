namespace DarioLuis.Museum
{
    public class Gast
    {

        public string _Name;
        public bool _IsThief;
        public Raum Aufenthaltsort;

        public Gast(string Name, bool IsThief)
        {
            _Name = Name;
            _IsThief = IsThief;
            Aufenthaltsort = null;
        }
        public string Name { get; set; }
        public bool IsThief { get; set; }

        public void Ortwechsel(Raum Raum)
        {
            if (Raum == Aufenthaltsort)
            {
                return;
            }
            
            if (Aufenthaltsort != null)
            {
                Aufenthaltsort.GebaeudeVerlassen(this);
            }
        }

        internal void Ortwechsel(List<Raum> raeume)
        {
            return;
        }
    }
}
