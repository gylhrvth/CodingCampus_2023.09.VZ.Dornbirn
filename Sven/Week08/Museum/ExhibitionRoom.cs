using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sven.Week08.Museum
{
    internal class ExhibitionRoom : Room
    {
        private List<Artwork> _artworkList = new();
        private static Random _random = new Random();




        public ExhibitionRoom(string name) : base(name) { }



        public void AddArtwork(Artwork artwork)
        {
            _artworkList.Add(artwork);
        }


        public override void RemoveArtwork(Artwork artwork)
        {
            _artworkList.Remove(artwork);
        }


        public override Artwork GetRandomArtwork()
        {
            if (_artworkList.Count == 0)
            {
                return null;
            }

            int indexArtwork = _random.Next(_artworkList.Count);

            return _artworkList[indexArtwork];
        }

    }
}
