using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timo.Week06._04Zoo
{
    public class Zoo
    {
        private string _Name;
        private int _Founded;
        private List<Gehege> _Gehege;
        

        public Zoo(string name, int founded)
        {
            _Name = name;
            _Founded = founded;
            _Gehege = new List<Gehege>();
        }

        public List<Gehege> Gehege
        {  
            get { return _Gehege; }
            set { _Gehege = value; }
        }
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public int Founded
        {
            get { return _Founded; }
            set { _Founded = value; }
        }

        public void PrintZoo()
        {
            Console.WriteLine("├─── Zoo: {0}, gegründet {1}", _Name, _Founded);
            for (int i = 0;  i < _Gehege.Count; i++)
            {
                _Gehege[i].PrintGehege();
            }
        }
    }
    
}
