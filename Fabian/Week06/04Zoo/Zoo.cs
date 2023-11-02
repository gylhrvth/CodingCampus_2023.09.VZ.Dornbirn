namespace Fabian.Week06._04Zoo
{
    public class Zoo
    {
        private string _Name;
        private int _FoundingYear;
        private List<Enclosure> _Enclosures;

        public List<Enclosure> Enclosures
        { get => _Enclosures;
          set => _Enclosures = value;
        }
        public string Name
        {
            get => _Name;
            set => _Name = value;
        }
        public int FoundingYear
        {
            get => _FoundingYear;
            set => _FoundingYear = value;
        }

        public Zoo(string name, int foundingYear)
        {
            _Name = name;
            _FoundingYear = foundingYear;
            Enclosures = new List<Enclosure>();
        }
        public override string ToString()
        {
            return "Zoo: " + _Name + ", founded: " + _FoundingYear;
        }
    }
}
