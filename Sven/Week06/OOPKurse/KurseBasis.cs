using System;
using System.Collections.Generic;
using System.Linq;
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
        private string _Trainer;
        
        public string Titel
        {
            get => _Titel;

        }
        public int Start
        {
            get => _Start;

        }
        public int AnzahlStd
        {
            get => _AnzahlStd;

        }
        public int Preis
        {
            get => _Preis;

        }
        public KurseBasis(string Titel, int Start, int AnzahlStd, int Preis)
        {
            _Titel = Titel;
            _Start = Start;
            _AnzahlStd = AnzahlStd;
            _Preis = Preis;
        }
        public override string ToString()
        {
            return string.Format("KursTitel: {0}\nBeginn: {1}\nStunden Anzahl: {2}\nPreis: {3} $",
                _Titel,
                _Start,
                _AnzahlStd,
                _Preis);
        }

    }
}
