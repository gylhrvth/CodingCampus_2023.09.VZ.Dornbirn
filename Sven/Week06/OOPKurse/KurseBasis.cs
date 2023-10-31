using Sven.Week06.OOPPerson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Sven.Week06.OOPKurse
{
    internal class KurseBasis
    {

        private string _Titel;
        private int _Start;
        private int _AnzahlStd;
        private int _Preis;
        public Person _Trainer;
        
        public KurseBasis(string Titel, int Start, int AnzahlStd, int Preis, Person Trainer)
        {
            _Titel = Titel;
            _Start = Start;
            _AnzahlStd = AnzahlStd;
            _Preis = Preis;
            _Trainer = Trainer;
        }
        public override string ToString()
        {
            return string.Format("KursTitel: {0}\nBeginn: {1}\nStunden Anzahl: {2}\nPreis: {3} $,\nTrainer: {4}",
                _Titel,
                _Start,
                _AnzahlStd,
                _Preis,
                _Trainer) ;
        }

    }
}
