using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dimitri.Week07._01Mensch
{
    public class Zimmer
    {
        public static void Main()
        {
            List<Human> zimmer = new List<Human>();

            zimmer.Add(new Patient("Dimitri", "male", "deppat"));
            zimmer.Add(new Allgemeinmediziner("Kathi", "female", "Oberarzt", true));
            zimmer.Add(new Doctor("Ralph", "divers", "Turnusarzt"));
            zimmer.Add(new Patient("David", "male", "Cold"));

            foreach(Human human in zimmer)
            {
                human.Print();
            }

        }
    }
}
