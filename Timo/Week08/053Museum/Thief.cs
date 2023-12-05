
namespace Timo.Week08._053Museum
{
    public class Thief : Visitor
    {
        private int _Speed;
        private double _MaxCapacity;
        private List<Artwork> _Backpack;

        public Thief(string name, int speed, double maxCapacity) : base(name)
        {
            _Name = name;
            _Speed = speed;
            _MaxCapacity = maxCapacity;
            _Backpack = new List<Artwork>();
        }

        public override void Steal()
        {
            Artwork artwork = _CurrentLocation.GetRandomArtwork();

            if (_CurrentLocation.Visitors.Count == 1 && artwork != null && _Backpack.Count != _MaxCapacity)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine($"{_Name} is alone and steals {artwork.Name} in {_CurrentLocation.Name}.");
                _CurrentLocation.Artworks.Remove(artwork);
                _Backpack.Add(artwork);
                Console.ResetColor();
            }
        }
    }
}
