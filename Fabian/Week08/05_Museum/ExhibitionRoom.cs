using System.Security.Cryptography;

namespace Fabian.Week08._05_Museum
{
    public class ExhibitionRoom : IRoom
    {
        private List<Artwork> _Artworks;

        public List<IRoom> Neighbours { get; set; }
        public List<Artwork> Artworks { get => _Artworks; set => _Artworks = value; }
        public string Name { get; set; }
        public ExhibitionRoom(string name)
        {
            Name = name;
            _Artworks = new List<Artwork>();
            Neighbours = new List<IRoom>();
        }


    }
}
