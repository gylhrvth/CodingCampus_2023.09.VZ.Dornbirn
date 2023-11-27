using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cemal.Selbsttest.Aufgabe1
{
    public class HouseMain
    {
        public static void Start()
        {
            Person pers1 = new Person("Cemal", 20, "männlich");
            Person pers2 = new Person("Kerem", 23, "männlich");
            Person pers3 = new Person("Ali", 22, "männlich");
            Person pers4 = new Person("Sven", 20, "männlich");
            Person pers5 = new Person("Fabienne", 16, "weiblich");
            Person pers6 = new Person("Mohammed", 28, "männlich");
            Person pers7 = new Person("David", 34, "männlich");
            Person pers8 = new Person("Erik", 20, "männlich");
            Person pers9 = new Person("Selina", 18, "weiblich");
            Person pers10 = new Person("Dario", 17, "männlich");

            House Einfamilienhaus = new House(5,"Millöckerstraße 1", 10);
            House Wohnung = new House(3, "Robert-Koch-Straße 10a", 7);
            House Villa = new House(8, "Lustenauerstraße 33", 18);


            Einfamilienhaus.addPerson(pers1); Einfamilienhaus.addPerson(pers2);
            Einfamilienhaus.addPerson(pers3);

            Wohnung.addPerson(pers4); Wohnung.addPerson(pers5);

            Villa.addPerson(pers6); Villa.addPerson(pers7); Villa.addPerson(pers8);
            Villa.addPerson(pers9); Villa.addPerson(pers10);

            Einfamilienhaus.PrintStructure();
            Wohnung.PrintStructure();
            Villa.PrintStructure();
        }
    }
}
