using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timo.Week08._063Bank
{
    public class BankMain
    {
        public static void Start()
        {
            Bank GeldinstitutFeldkirch = new Bank("Geldinstitut Feldkirch");

            Schalter S1 = new Schalter(1, 10000);
            Schalter S2 = new Schalter(2, 36800);
            Schalter S3 = new Schalter(3, 23780);

            GeldinstitutFeldkirch.AddSchalter(S1);
            GeldinstitutFeldkirch.AddSchalter(S2);
            GeldinstitutFeldkirch.AddSchalter(S3);

            List<Kunde> Kundenliste = new()
            {
                new("Doris"),
                new("Günther"),
                new("Johannes"),
                new("Sabine"),
                new("Veronika"),
                new("Winfried"),
                new("Franz")
            };


            foreach (Kunde kunde in Kundenliste)
            {
                Random random = new Random();
                int i = random.Next(-10000, 10000);
                GeldinstitutFeldkirch.SchalterBesetzen(kunde, i);
            }
            foreach (Schalter schalter in GeldinstitutFeldkirch.Schalterliste)
            {
                schalter.PrintSchalterStatistik();
            }
            //GeldinstitutFeldkirch.PrintBank();
        }
    }
}