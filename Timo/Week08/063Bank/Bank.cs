using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timo.Week08._063Bank
{
    public class Bank
    {
        private string _Name;
        private List<Schalter> _Schalterliste = new();
        int _Kundencount;

        public Bank(string name)
        {
            _Name = name;
        }
        public int Kundencount
        {
            get => _Kundencount;
        }
        public List<Schalter> Schalterliste
        { get => _Schalterliste; }

        public void AddSchalter(Schalter schalter)
        {
            _Schalterliste.Add(schalter);
        }

        public void PrintBank()
        {
            Console.WriteLine("Name: {0}, Anzahl Schalter: {1}", _Name, _Schalterliste.Count);
            foreach (Schalter schalter in _Schalterliste)
            {
                schalter.PrintSchalter();
            }
        }

        public void SchalterBesetzen(Kunde kunde, int i)
        {
            for (int j = 0; j < _Schalterliste.Count; j++)
            {
                if (Schalterliste[j].StatusBesetzt == false && Schalterliste[j].StatusGeschlossen == false)
                {
                    Console.WriteLine("{0} ist am Schalter {1}", kunde.Name, Schalterliste[j].Schalternummer);
                    Schalterliste[j].StatusBesetzt = true;
                    kunde.BankGeschaeft(Schalterliste[j], i);
                    kunde.Pause(Schalterliste[j]);
                    break;

                }
                else if (Schalterliste[j].StatusBesetzt == false && Schalterliste[j].StatusGeschlossen == true)
                {
                    Console.WriteLine("{0} ist am Schalter {1}", kunde.Name, Schalterliste[j+1].Schalternummer);
                    Schalterliste[j + 1].StatusBesetzt = true;
                    kunde.BankGeschaeft(Schalterliste[j + 1], i);
                    kunde.Pause(Schalterliste[j + 1]);
                    break;
                }
                Schalterliste[j].StatusBesetzt = false;
            }


            //foreach (Schalter schalter in _Schalterliste)
            //{
            //    if (schalter.StatusBesetzt == false && schalter.StatusGeschlossen == false)
            //    {
            //        Console.WriteLine("{0} ist am Schalter {1}", kunde.Name, schalter.Schalternummer);
            //        schalter.StatusBesetzt = true;
            //        kunde.BankGeschaeft(schalter, i);
            //        kunde.Pause(schalter);
            //        break;
            //    }
            //    schalter.StatusBesetzt = false;
            //}
        }
    }
}
