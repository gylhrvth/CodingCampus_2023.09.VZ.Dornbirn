using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Simon.Week06.PersonExample
{
    public class Kurse
    {
        private string _Titel;
        private DateTime _Start;
        private int _AnzahlKursstunden;
        private double _Preis;
        private Person _Trainer;

        public string Titel {get => _Titel;}
        public DateTime Start { get => _Start; }
        public int AnzahlKursstunden { get => _AnzahlKursstunden; }
        public double Preis { get => _Preis; }
        public Person Trainer { get => _Trainer; }


        public Kurse(string Titel, DateTime Start, int AnzahlKursstuden, double Preis, Person Trainer)
        {
            _Titel = Titel;
            _Start = Start;
            _AnzahlKursstunden = AnzahlKursstuden;
            _Preis = Preis;
            _Trainer = Trainer;
        }

        public override string ToString()
        {
            return string.Format("Titel: {0}\nStart: {1}\nAnzahl Kursstunden: {2} Presi für diese {3}\nTrainer: {4}", _Titel, _Start, _AnzahlKursstunden, _Preis, _Trainer);
        }

    }
}
