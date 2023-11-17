using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Jovo.Week07.NewZoo
{
    internal class Zoo
    {
        private string Name;
        private string Location;
        private int ConstructionYear;
        private int ZooEnclosuresCount;
        private List<Enclosures> EnclosuresList;



        public Zoo(string Name, string Location, int ConstructionYear, int ZooEnclosuresCount, List<Enclosures> enclosuresList)
        {
            this.Name = Name;
            this.Location = Location;
            this.ConstructionYear = ConstructionYear;
            this.ZooEnclosuresCount = ZooEnclosuresCount;
            this.EnclosuresList = enclosuresList;
        }




        public void PrintZoo() 
        {
            Console.WriteLine($"├──ZooName:{Name}, ZooLocation:{Location}, ZooConstructionYear:{ConstructionYear}, ZooEnclosuresCount: {ZooEnclosuresCount}");

            foreach(Enclosures enclosures in EnclosuresList)
            {
                enclosures.PrintZooEnclosures();
            }

        }


    }

   
}
