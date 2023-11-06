namespace Fabian.Week06._04Zoo
{
    public class AnimalDoctor
    {
        private string _Name;

        public string Name
        {
            get => _Name;
            set => _Name = value;
        }

        public AnimalDoctor(string name)
        {
            _Name = name;
        }
    }
}
