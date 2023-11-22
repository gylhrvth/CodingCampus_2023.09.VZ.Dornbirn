

namespace Fabian.Week08._05_Museum
{
    public class ExhibitionRoom : Room
    {
        private List<Artwork> _Artworks;
        public List<Artwork> Artworks { get => _Artworks; set => _Artworks = value; }
        public ExhibitionRoom(string name) : base(name)
        { 
            _Artworks = new List<Artwork>();
        }

        protected override void PrintMyself(string prefix)
        {
            Console.Write($"{prefix} Exhibition: {_Name}");
        }
    }
}
