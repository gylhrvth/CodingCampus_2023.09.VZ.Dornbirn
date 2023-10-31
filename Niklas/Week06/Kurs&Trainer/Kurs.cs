using System;

namespace Niklas.Week06.Kurs
{
    internal class Kurs
    {
        private string _Titel;
        public string Titel
        {
            get => _Titel;

            set
            {
                Console.WriteLine("Title is: " + value);
                _Titel = value;
            }
        }
        private string _Start;
        public string Start
        {
            get => _Start;

            set
            {
                Console.WriteLine("Start is at: " + value);
                _Start = value;
            }
        }
        private int _Stunden;
        public int Stunden
        {
            get => _Stunden;

            set
            {
                Console.WriteLine("Hours are: " + value);
                _Stunden = value;
            }
        }
        //453 stunden
        private int _Preis;
        public int Preis
        {
            get => _Preis;

            set
            {
                Console.WriteLine("Price is: " + value + " Euro");
                _Preis = value;
            }
        }

        private string _Trainer;
        public string Trainer
        {
            get => _Trainer;

            set
            {
                Console.WriteLine("Trainer is " + value);
                _Trainer = value;
            }
        }
        public Kurs(string titel, string start, int stunden, int preis, string trainer)
        {
            Titel = titel;
            Start = start;
            Stunden = stunden;
            Preis = preis;
            Trainer = trainer;
        }

        public override string ToString()
        {
            return string.Format("Kurs: {0} {(1)}", _Titel, _Trainer);
        }
    }
}
