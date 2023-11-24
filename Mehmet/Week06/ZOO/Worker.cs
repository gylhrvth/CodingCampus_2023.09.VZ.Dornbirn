<<<<<<< HEAD:Mehmet/ZOO/Worker.cs
﻿using Kerem.Zoo;
using System;
=======
﻿using System;
>>>>>>> cef7d42f6d1ac56725b97fa9b906b80feba585f7:Mehmet/Week06/ZOO/Worker.cs
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

<<<<<<< HEAD:Mehmet/ZOO/Worker.cs
namespace Kerem.ZOO
=======
namespace Mehmet.Week06.ZOO
>>>>>>> cef7d42f6d1ac56725b97fa9b906b80feba585f7:Mehmet/Week06/ZOO/Worker.cs
{
    internal class Worker
    {
        private string _Name;
        private string _Workplace;
        private List<Cage> _CageList;

        public Worker(string name, string workplace)
        {
            _Name = name;
            _Workplace = workplace;
            _CageList = new List<Cage>();
        }

        public void AddCage(Cage cage)
        {
            _CageList.Add(cage);
        }

        public void PrintStrukture()
        {
            Console.WriteLine("   └──┤ Mitarbeiter: {0},  ArbeitsPlatz: {1}",
                _Name,
                _Workplace);
        }

        public void SimulateDay()
        {
            Console.WriteLine("  {0} startet  mit der Arbeit", _Name);
            foreach (Cage cage in _CageList)
            {
                cage.SimulateDay();
            }
        }
    }
}