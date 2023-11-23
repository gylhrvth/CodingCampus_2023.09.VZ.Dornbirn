namespace Gheorghe
{
    public class Kurs
    {
        private string _Titel;
        private DateTime _Date;
        private int _AnzahlKursStunden;
        private double _Preis;
        private Mensch _Trainer;


        public Kurs(string Titel, DateTime date, int anzahlkursstunden, double preis, Mensch trainer)
        {
            _Titel = Titel;
            _Date = date;
            _AnzahlKursStunden = anzahlkursstunden;
            _Preis = preis;
            _Trainer = trainer;


        }

        public override string ToString()
        {
            return String.Format("Titel: {0}\nDate: {1}\nAnzahlkursstunden: {2}\nPreis: {3}\nTrainer: \"{4}\"", _Titel, _Date, _AnzahlKursStunden, _Preis, _Trainer.Name);
        }

    }


}
