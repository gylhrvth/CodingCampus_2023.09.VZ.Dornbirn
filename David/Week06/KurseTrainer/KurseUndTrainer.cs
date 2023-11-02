using System.Xml.Linq;
using David.Week06.PersonExample;

namespace David.Week06.KurseTrainer
{
	public class KurseUndTrainer
	{
        private string _Titel;
        private string _Start;
        private string _Preis;
        private int _AnzahlKursstunden;
        private Person _Trainer;

      

        public KurseUndTrainer(string Titel, string Start, string Preis, int AnzahlKursstunden)
		{
            _Titel = Titel;
            _Start = Start;
            _Preis = Preis;
            _AnzahlKursstunden = AnzahlKursstunden;
            
		}
        public override string ToString()
        {
            return string.Format("Titel: {0}\nStart: {1}\nPreis: {2}\nAnzahl Kursstunden: {3}\nTrainer: {4}",
                _Titel,
                _Start,
                _Preis,
                _AnzahlKursstunden,
                _Trainer);
        }
    }
}

