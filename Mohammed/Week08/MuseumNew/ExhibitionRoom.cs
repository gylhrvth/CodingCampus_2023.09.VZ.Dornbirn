using System;
namespace Mohammed.Week08.MuseumNew
{
	public class ExhibitionRoom : Room
	{
        private List<ArtWork> _ArtworkList;

        public ExhibitionRoom(string name) : base(name)
        {
            _ArtworkList = new List<ArtWork>();

        }

        public void AddArtwork(ArtWork artwork)
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
                foreach (ArtWork art in _ArtworkList)
                {
                    Console.WriteLine("Das Kunstwerk " + art.Name + " wird Angeschaut!");
                }
            }

        }
    }
}

