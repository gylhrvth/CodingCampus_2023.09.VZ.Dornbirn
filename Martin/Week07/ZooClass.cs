using Martin.Week01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martin.Week07
{
    public class ZooClass
    {
        private string _name;
        private int _EntstehungsJahr;

     

        private List<EnclosureClass> _EnclosureList = new List<EnclosureClass>();
        private List<AnimalClass> _AnimalList = new List<AnimalClass>();

        public ZooClass(string Name, int EntstehungsJahr) 
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

             foreach (EnclosureClass item in _EnclosureList)
             {
                    
                Console.WriteLine($"|------Gehäge:{item.Name},Art: {item.Type} ");
                kosten += item.PrintAnimals();
             }

            return kosten;
        }




        public void AddEnclosure(EnclosureClass item)
        {
            if(!_EnclosureList.Contains(item)) //überprüft ob diese gehege schon gibt
            {
                _EnclosureList.Add(item);
            }
           
        }


        public void AddAnimal(AnimalClass item)
        {
            if (!_AnimalList.Contains(item)) //überprüft ob dieses Tier schon gibt
            {
                _AnimalList.Add(item);
            }

        }

        public void PrintFoodReport()
        {
            Dictionary<Futter, int> report = new Dictionary<Futter, int>();

            foreach(EnclosureClass enc in  _EnclosureList)
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
