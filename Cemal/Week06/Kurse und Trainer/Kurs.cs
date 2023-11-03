using Cemal.Week06.NmsPerson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Cemal.Week06.Kurse_und_Trainer
{
    public class Kurs
    {
        private string _Titel;
        private DateTime _Start;
        private int _Kursstunden;
        private double _Preis;
        private Person _Trainer;

        public string Titel
        {
            get => _Titel;
            set => _Titel = value;
        }

        public int Kursstunden
        {
            get => _Kursstunden;
            set => _Kursstunden = value;
        }

        public double Preis
        {
            get => _Preis;
            set => _Preis = value;
        }

        public Person Trainer
        {
            get => _Trainer;
            set => _Trainer = value;
        }

        public Kurs(string titel, DateTime start, int kursstunden, double preis, Person trainer)
        {
            _Titel = titel;
            _Start = start;
            _Preis = preis;
            _Kursstunden = kursstunden;
            _Trainer = trainer;

        }

        public override string ToString()
        {
            return string.Format("Titel: {0}\nDatum: {1}\nPreis: {2}\nKursstunden: {3}\nTrainer: {4}", _Titel, _Start, _Preis, _Kursstunden, Trainer);
        }
    }
}
