using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon.Week06.Zoosim
{
    public class Zoo
    {
        private string _Name;
        private int _FoundingYear;
        private List<Gehege> _Gehege;
        private string _Locality;
        private int _Capacity;

        public Zoo(string name, int year)
        {
            _Name = name;
            _FoundingYear = year;
        }

        public Zoo(string name, int foundingyear, string locality, int capacity)
        {
            _Locality = locality;
            _Capacity = capacity;
            _Name = name;
            _FoundingYear = foundingyear;
            _Gehege = new List<Gehege>();
        }

        //public void AddGehege(Gehege gehege)
        //{
        //    if (!_Gehege.Contains(gehege))
        //    {
        //        _Gehege.Add(gehege);
        //    }
        //}

        public void PrintZoo()
        {
            Console.WriteLine(" ---> Gehege: {0} {1}", _Name, _FoundingYear);

            foreach (Gehege gehege in _Gehege)
            {
                gehege.PrintZoo();
            }
        }


    }
}
