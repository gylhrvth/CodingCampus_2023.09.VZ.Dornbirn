using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cemal.Week07.Zoo
{
    public class ZooMain
    {
        public static void Start()
        {
            Zoo zoo = new("Tiergarten Dornbirn", 2023);

            Enclosures enclosures1 = new Enclosures("Alpenwiese");
            Enclosures enclosures2 = new Enclosures("Ried");
            Enclosures enclosures3 = new Enclosures("Terrarium");

            zoo.addEnclosure(enclosures1);
            zoo.addEnclosure(enclosures2);
            zoo.addEnclosure(enclosures3);

            zoo.PrintStructure();
            

        }

    }
}
