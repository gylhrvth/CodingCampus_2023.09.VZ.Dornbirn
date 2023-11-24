namespace Timo.Week08._053Museum
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
