using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Niklas.Week08.Museum
{
    public class Gaeste
    {
        private string _Name;
        private bool _IsThief;
        private Ausstellungsraum _AufenthaltsOrt;

        public Gaeste(string name, bool isThief)
        {
            _Name = name;
            _IsThief = isThief;
            _AufenthaltsOrt = null;
        }
        public string Name { get; set; }
        public bool IsThief { get; set; }

        public void Ortwechsel(Ausstellungsraum ausstellungsraum)
        {
            if (ausstellungsraum == _AufenthaltsOrt)
            {
                return;
            }
            if (_AufenthaltsOrt != null)
            {

            }
        }
    }

}