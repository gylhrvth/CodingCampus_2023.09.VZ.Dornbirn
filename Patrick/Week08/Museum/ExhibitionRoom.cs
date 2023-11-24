using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week08.Museum
{
    public class ExhibitionRoom : Room
    {
        List<Artwork> _ArtworkList;

        public ExhibitionRoom(string name) : base(name)
        {
            _ArtworkList = new List<Artwork>();
        }

        public void AddArtwork(Artwork artwork)
        {
            if (!_ArtworkList.Contains(artwork))
            {
                _ArtworkList.Add(artwork);
            }
        }

    }




}
