namespace Fabian.Week06._04Zoo
{
    public class Animal
    {
        private string _Name;
        private string _Type;

        public string Name
        {
            get => _Name;
            set => _Name = value;
        }
        public string Type
        {
            get => _Type;
            set => _Type = value;
        }

        public Animal(string name, string genus)
        {
            _Name = name;
            _Type = genus;
        }
        public override string ToString()
        {
            return _Name + ", " + _Type;
        }
    }
}
