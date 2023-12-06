using System;
namespace Mohammed.Week08.MuseumNew
{
    public class ArtWork
    {
        private string _Name;

        public string Name
        {
            get => _Name;
        }

        public ArtWork(string name)
        {
            _Name = name;
        }
    }
}


