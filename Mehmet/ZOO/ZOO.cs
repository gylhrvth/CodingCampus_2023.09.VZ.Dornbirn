using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mehmet.Zoo
{
    internal class Zoo
    {
        private string _Name;
        private int _Founded;
        private List<Cage> _CageList;
       


        public Zoo(string name, int founded)
        {
            _Name = name;
            _Founded = founded;
            _CageList = cageList;
        }




        public override string ToString()

        {
            return string.Format("├── Zoo: Tiergarten {0}, gegründet {1}",
                _Name, 
                _Founded);
        }





    }
}
