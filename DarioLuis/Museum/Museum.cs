namespace DarioLuis.Museum
{
    public class Museum
    {
        private string _Name;
        private int _FoundingYear;
        //public List<Raum> Raeume;
        private Hallway Eingang;
        public List<Gast> Gaeste;

        public Museum(string name, int foundingyear, Hallway eingang)
        {
            _Name = name;
            _FoundingYear = foundingyear;
            //Raeume = new List<Raum>();
            Gaeste = new List<Gast>();
            Eingang = eingang;
        }

        public void PrintStruktur(string prefix)
        {
            Console.WriteLine($"{prefix} Museum: {_Name}, Founded: {_FoundingYear}");
            List<Raum> besuchteRaeume = new List<Raum>();

            Eingang.PrintStruktur("    " + prefix, besuchteRaeume);
        }
        public void Gasthinzu(Gast gast)
        {
            if (!Gaeste.Contains(gast))
            {
                Gaeste.Add(gast);
                gast.Ortwechsel(Eingang);
            }
        }


        public void Tick()
        {
            foreach (Gast g in Gaeste)
            {
                g.Tick();
            }
        }
    }
}
