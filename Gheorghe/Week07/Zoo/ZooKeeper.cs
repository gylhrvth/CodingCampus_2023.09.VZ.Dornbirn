using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Gheorghe.Week07.Zoo
{
    internal class ZooKeeper
    {
      

        private string _Name;
        private List<Enclosure> _Enclosures ;
       

        public List<Enclosure> Enclosures
        {
            get => _Enclosures;
            set => _Enclosures = value;
        }
   

        public ZooKeeper(string name)
        {
            _Name = name;
            _Enclosures = new List<Enclosure>();
           
        }



        public void AddEnclosure(Enclosure enclosure)
        {
            if (!_Enclosures.Contains(enclosure))
            {
                _Enclosures.Add(enclosure);
            }
        }



        public void PrintZooKeeper()
        {
            Console.WriteLine("     ├──Zookeeper: {0}", _Name);
        }
      



        public override string ToString()
        {
            return "Name: " + _Name;
        }


        public void SimulationWork()
        {
            Console.WriteLine($"{_Name} start working");

            foreach(var enclosure in _Enclosures)
            {
                enclosure.CareAnimals();
            }
        }

        public void AnimalObserve()
        {
            Console.WriteLine($"{_Name} Animal Watching");
            foreach(var enclosure in _Enclosures)
            {
                enclosure.AnimalsObserve();
            }
        }



    }
}



 

 



