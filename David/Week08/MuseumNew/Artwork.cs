using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week08.MuseumNew
{
    public class Artwork
    {
        private string _Name;

        public string Name
        {
            get => _Name;
        }

        public Artwork(string name)
        {
            _Name = name;
        }


    }
}
