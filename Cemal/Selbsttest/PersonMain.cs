using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cemal.Selbsttest
{
    public class PersonMain
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

            pers1.PrintStructure();
            pers2.PrintStructure();
            pers3.PrintStructure();
            pers4.PrintStructure();
            pers5.PrintStructure();
            pers6.PrintStructure();
            pers7.PrintStructure();
            pers8.PrintStructure();
            pers9.PrintStructure();
            pers10.PrintStructure();



        }
    }
}
