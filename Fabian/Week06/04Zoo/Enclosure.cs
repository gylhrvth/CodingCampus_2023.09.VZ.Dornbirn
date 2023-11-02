namespace Fabian.Week06._04Zoo
{
    public class Enclosure
    {
        private string _Name;
        private List<Animal> _Animals;
        public string Name
        {
            get => _Name;
            set => _Name = value;
        }
        public List<Animal> Animals
        {
            get => _Animals;
            set => _Animals = value;
        }

        public Enclosure(string name)
        {
            _Name = name;
            _Animals = new List<Animal>();
        }
        public override string ToString()
        {
            return "Encolure: " + _Name;
        }
    }
}
