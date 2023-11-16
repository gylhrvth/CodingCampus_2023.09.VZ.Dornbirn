namespace Niklas.Week06.Zoo
{
    internal class TierArzt
    {
        private string _name;
        private int _HealedAnimals;

        public int HealedAnimals
        {
            get => _HealedAnimals;

            set
            {
                _HealedAnimals = value;
            }
        }

        public string Name
        {
            get => _name;
            set
            {
                _name = value;
            }
        }

        public TierArzt(string name)
        {
            _name = name;
        }
    }
}
