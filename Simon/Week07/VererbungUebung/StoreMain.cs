using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon.Week07.VererbungUebung
{
    internal class StoreMain
    {
        public static void Start()
        {
            List<Clothing> store = new();

            store.Add(new Clothing("TShirt"));
            store.Add(new TShirt("Nike", "cotton", "blue"));
            store.Add(new Clothing("Hose"));
            store.Add(new Clothing("Cap"));
            store.Add(new Clothing("Leggins"));
            store.Add(new Clothing("Hemd"));

            foreach (Clothing cloting in store)
            {
                cloting.PrintClothing();
            }


        }
    }
}
