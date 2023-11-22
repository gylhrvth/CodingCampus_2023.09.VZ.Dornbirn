namespace DarioLuis.Museum
{
    public class Museum
    {
        private string _Name;
        private int _FoundingYear;
        public List<Raum> Raeume;
        private Hallway Gaenge;
        public List<Gast> Gaeste;

        public Museum(string name, int foundingyear)
        {
            _Name = name;
            _FoundingYear = foundingyear;
            Raeume = new List<Raum>();
            Gaeste = new List<Gast>();
        }

        public void PrintStructur(string prefix)
        {
            Console.WriteLine($"{prefix} Museum: {_Name}, Founded: {_FoundingYear}");
            List<Raum> besuchteRaeume = new List<Raum>();
            _
        }
        public void Gasthinzu(Gast gast)
        {
            if (!Gaeste.Contains(gast))
            {
                Gaeste.Add(gast);
                gast.Ortwechsel(Raeume);
            }
        }
    }
}
