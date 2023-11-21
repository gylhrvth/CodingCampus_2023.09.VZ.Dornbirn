using System.Security.Cryptography;

namespace Fabian.Week08._05_Museum
{
    public class ExhibitiomRoom
    {
        private string _Name;
        private List<Artwork> _Artworks;

        public string Name { get => _Name; set => _Name = value; }
        public List<Artwork> Artworks { get => _Artworks; set => _Artworks = value; }
        public ExhibitiomRoom(string name)
        {
            _Name = name;
            _Artworks = new List<Artwork>();
        }


    }
}
