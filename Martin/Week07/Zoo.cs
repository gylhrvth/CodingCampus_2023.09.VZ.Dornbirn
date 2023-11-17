using Martin.Week01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martin.Week07
{
    public class Zoo
    {
        private string _name;
        private int _EntstehungsJahr;

     

        private List<Enclosure> _EnclosureList = new List<Enclosure>();
        private List<Animal> _AnimalList = new List<Animal>();
        private List<Pfleger> _pflegers = new List<Pfleger>();
        public Zoo(string Name, int EntstehungsJahr) 
        {
            _EntstehungsJahr = EntstehungsJahr;
            _name = Name;
        }

        public void PrintZoo()
        {
            Console.WriteLine($"Name des Zoo´s : {_name} , Entstehung: {_EntstehungsJahr}");
        }

        public int PrintEnclosures()
        {
             int kosten = 0;

             foreach (Enclosure item in _EnclosureList)
             {
                Console.WriteLine($"|------Gehege:{item.Name}, Art: {item.Type} ");
                kosten += item.PrintAnimals();
             }

            return kosten;
        }

        public void AddEnclosure(Enclosure item)
        {
            if(!_EnclosureList.Contains(item)) //überprüft ob diese gehege schon gibt
            {
                _EnclosureList.Add(item);
            }
           
        }

        public void AddPfleger(Pfleger item)
        {
            if (!_pflegers.Contains(item)) //überprüft ob diese gehege schon gibt
            {
                _pflegers.Add(item);
            }

        }
          

        public void AddAnimal(Animal item)
        {
            if (!_AnimalList.Contains(item)) //überprüft ob dieses Tier schon gibt
            {
                _AnimalList.Add(item);
            }

        }

        public void PrintFoodReport()
        {
            Dictionary<Futter, int> report = new Dictionary<Futter, int>();

            foreach(Enclosure enc in  _EnclosureList)
            {
                enc.ReportFoodRequest(report);
            }

            Console.WriteLine("Futter anfrage meldung");   

            foreach(Futter f in report.Keys)
            {
                Console.WriteLine("{0, -20} {1,5} {2,-5}",
                    f.Name,
                    report[f],
                    f.Einheit
                    );
            }



        }

    }
}
