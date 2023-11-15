using Patrick;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrick.Week06.PersonOne
{
    internal class KurseUndTrainer
    {
        private string _Title;
        private DateTime _Start;
        private int _Kursstunden;
        private double _Preis;
        private Person _Trainer;


        public KurseUndTrainer(string title, DateTime start, int kursstunden, double preis, Person trainer)
        {
            _Title = title;
            _Start = start;
            _Kursstunden = kursstunden;
            _Preis = preis;
            _Trainer = trainer;
        }

        public override string ToString()
        {
            return string.Format("Title: {0}\nStart: {1}\nKursstunden: {2}hours\nPreis: {3}$\nTrainer: {4}",_Title, _Start, _Kursstunden, _Preis, _Trainer);
        }
    }
}
