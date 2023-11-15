using Simon.Week06.Zoosim;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon.Week06.Zoosim2
{
    internal class Zoo
    {
        private string _Name;
        private int _FoundingYear;
        private List<Enclosure> _EnclosureList;
        private string _Foundingcity;

        public Zoo(string name, int foundingyear, string foundingcity)
        {
            _Name = name;
            _FoundingYear = foundingyear;
            _Foundingcity = foundingcity;

        }

        public void AddEnclosures(Enclosure enclosure)
        {
            _EnclosureList.Add(enclosure);
        }






    }
}
