using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Michael.ZooSimulation
{
    internal class Zoo
    {
        private string _Name;
        private int _FoundingYear;
        private List<Enclosure> _Enclosures = new List<Enclosure> {};
        private List<Carer> _Carers = new List<Carer> {};
        private List<Veterenarian> _Veterenarians = new List<Veterenarian> {};

        public List<Enclosure> Enclosures { get => _Enclosures; }


        public Zoo(string name, int foundingYear, List<Enclosure> enclosures = null, List<Carer> carers = null, List<Veterenarian> vets = null)
        {
            _Name = name;
            _FoundingYear = foundingYear;

            if (enclosures != null)
            {
                _Enclosures.AddRange(enclosures);
            }

            if (carers != null)
            {
                _Carers.AddRange(carers);
            }

            if (vets != null)
            {
                _Veterenarians.AddRange(vets);
            }
        }


        public void AddEnclosures(Enclosure enc)
        {
            _Enclosures.Add(enc);
        }


        public void AddEnclosures(List<Enclosure> enc)
        {
            _Enclosures.AddRange(enc);
        }


        public void AddVets(Veterenarian vet)
        {
            _Veterenarians.Add(vet);
        }


        public void AddVets(List<Veterenarian> vets)
        {
            _Veterenarians.AddRange(vets);
        }


        public void AddCarers(Carer car)
        {
            _Carers.Add(car);
        }


        public void AddCarers(List<Carer> car) 
        {
            _Carers.AddRange(car);
        }


        public void PrintSelf(string prefix = "")
        {
            Console.WriteLine($"{prefix}├──Zoo: {this}");
            foreach (Enclosure enclosure in _Enclosures)
            {
                enclosure.PrintSelf(prefix + "    ");
            }
        }


        public void SimulateDay(string prefix = "")
        {
            Dictionary<Carer, int> checkedEnclosures = new Dictionary<Carer, int>();
            foreach(Carer carer in _Carers)
            {
                checkedEnclosures.Add(carer, 0);
            }
            bool somethingHappened = true;

            while (somethingHappened) 
            {
                somethingHappened = false;
                foreach(Carer carer in _Carers)
                {
                    somethingHappened = carer.FeedNext(checkedEnclosures, prefix + "    "); 
                }
            }

            Console.WriteLine();

            foreach (Enclosure enclosure in _Enclosures)
            {
                if (enclosure.Animals.Count > 1)
                {
                    enclosure.AnimalsFight();
                }

            }

            foreach(Veterenarian vet in _Veterenarians)
            {
                vet.GoesHealing(this);
            }

            Console.WriteLine();

            _Veterenarians[0].CleanDeadAnimals(this);
        }


        public void SimulateMultipleDays(int daysCount, string prefix = "")
        {
            for (int day = 1; day <= daysCount; day++)
            {
                PrintSelf();
                Console.WriteLine($"\nday {day}\n");
                SimulateDay();
                Console.WriteLine("------------------------------");
                Console.ReadLine();
            }
        }
        


        public override string ToString()
        {
            return $"{_Name}, gegründet {_FoundingYear}";
        }

    }
}
