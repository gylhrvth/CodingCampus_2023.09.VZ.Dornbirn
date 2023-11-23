using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Niklas.Week07.Vererbung
{
    public class OceanMain
    {
        public static void Start()
        {
            List<Fish> list = new List<Fish>();

            list.Add(new Specialise("Shark", false, "hunting animal"));
            list.Add(new Fish("Hering", true));
            list.Add(new Fish("Barsch", true));
            list.Add(new Fish("Lachs", true));
            list.Add(new Specialise("Dolphin", false, "mammal"));

            foreach (Fish fish in list)
            {
                fish.PrintMe();
            }
        }
    }
}
