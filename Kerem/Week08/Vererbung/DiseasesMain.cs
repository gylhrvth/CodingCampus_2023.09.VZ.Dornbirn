using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kerem.Week08.Vererbung
{
    internal class DiseasesMain
    {
        public static void Start()
        {
            List<Diseases> diseases = new List<Diseases>();

            diseases.Add(new Aids("Aids", 7.5, true));
            diseases.Add(new Ebola("Ebola", false, 10));


            foreach (Diseases d in diseases)
            {
                d.PrintMe();
            }

        }
    }


}
