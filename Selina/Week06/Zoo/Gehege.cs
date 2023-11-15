using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Selina.Week06.Zoo
{
    public class Gehege
    {
        private string _Description;
        private string _Climate;
        private string _Name;
        private List<Animals> _AnimalsList;
        private List<Nurse> _Nurse;

        public string Name
        {
            get => _Name;
            set => _Name = value;
        }

        public Gehege(string name, string climate, string description) 
        {
            this._Description = description;
            this._Climate = climate;
            this._Name = name;
            this._AnimalsList = new List<Animals>();
            this._Nurse = new List<Nurse>();
        }
        public void AddAnimals(Animals animals)
        {
            if (!_AnimalsList.Contains(animals))
            {
                _AnimalsList.Add(animals);
            }
        }
        public void AddNurse(Nurse nurse)
        {
            if (!_Nurse.Contains(nurse))
            {
                _Nurse.Add(nurse);
            }
        }
        public void PrintZoo()
        {
            foreach (Nurse nurse in _Nurse)
            {
                nurse.PrintZoo();
            }
            foreach (Animals animals in _AnimalsList)
            {
                animals.PrintZoo();
            }
        }
    }
}
