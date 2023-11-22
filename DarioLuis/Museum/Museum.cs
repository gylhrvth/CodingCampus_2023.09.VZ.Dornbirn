namespace DarioLuis.Museum
{
    public class Museum
    {
        private string _Name;
        private int _FoundingYear;
        public List<Raum> Raeume;
        public List<Gang> Gaenge;
        public List<Gast> Gaeste;

        public Museum(string name, int foundingyear)
        {
            _Name = name;
            _FoundingYear = foundingyear;
            Raeume = new List<Raum>();
            Gaenge = new List<Gang>();
            Gaeste = new List<Gast>();
        }

        public void Gasthinzu(Gast gast)
        {
            if (!Gaeste.Contains(gast))
            {
                Gaeste.Add(gast);
                gast.Ortwechsel(Raeume);
            }
        }



        internal static void SimulateGuest()
        {
            return;
        }
    }
}
