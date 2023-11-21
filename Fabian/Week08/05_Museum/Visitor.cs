namespace Fabian.Week08._05_Museum
{
    public class Visitor
    {
        private Random rnd = new();
        protected string _Name;

        public IRoom Room { get; set; }
        public string Name { get => _Name; set => _Name = value; }
        public Visitor(string name)
        {
            _Name = name;
            Room = null;
        }

        public void WatchArtwork()
        {
            //int randomArtwork = rnd.Next(Room.Artworks.Count);
            //Console.WriteLine($"{_Name} is spectating the artwork {Room.Artworks[randomArtwork].Name}");
        }
    }
}
