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

        private List<EnclosureClass> EnclosureList = new List<EnclosureClass>();
        private List<AnimalClass> AnimalList = new List<AnimalClass>();

        public ZooClass(string Name, int EntstehungsJahr) 
        {
            _EntstehungsJahr = EntstehungsJahr;
            _name = Name;
        }

        public void PrintZoo()
        {
            Console.WriteLine($"Name des Zoo´s : {_name} , Entstehung: {_EntstehungsJahr}");
        }

        public void PrintEnclosures()
        {
            foreach(EnclosureClass item in EnclosureList)
            {
                Console.WriteLine($"|--- ---Gehäge:{item.Name},Art: {item.Type} ");
                item.PrintAnimals();
            }
        }

        public void PrintAnimals()
        {
            foreach(AnimalClass item in AnimalList)
            {
                Console.WriteLine($"|-- ---Tier:{item.Name},Art: {item.Art} ");
            }
        }

        public void AddEnclosure(EnclosureClass item)
        {
            if(!EnclosureList.Contains(item)) //überprüft ob diese gehege schon gibt
            {
                EnclosureList.Add(item);
            }
           
        }


        public void AddAnimal(AnimalClass item)
        {
            if (!AnimalList.Contains(item)) //überprüft ob diese gehege schon gibt
            {
                AnimalList.Add(item);
            }

        }

    }
}
