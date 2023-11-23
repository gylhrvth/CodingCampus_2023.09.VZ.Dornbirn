namespace Fabian.Week08._05_Museum
{
    public class Artwork
    {
        public string Name { get; set; }
        private double _Weight;

        public Artwork(string name, double weight)
        {
            Name = name;
            _Weight = weight;
        }
    }
}
