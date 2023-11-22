using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week08.MuseumNew
{
    public class ExhibitionRoom : Room
    {
        private List<Artwork> _ArtworkList;

        public ExhibitionRoom(string name) : base (name)
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

        public void Watch()
        {
            if (_ArtworkList.Contains(null))
            {
                Console.WriteLine("ich gehe weiter da ist langweilig");
            }
            else
            {
                foreach (Artwork art in _ArtworkList)
                {
                    Console.WriteLine("Das Kunstwerk " + art.Name + " wird Angeschaut!");
                }
            }

        }




    }
}
