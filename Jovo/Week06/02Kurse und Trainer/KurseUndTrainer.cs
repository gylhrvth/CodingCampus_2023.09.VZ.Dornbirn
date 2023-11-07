using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jovo.Week06.Kurse_und_Trainer
{
    public class KurseUndTrainer
    {

        private string _Titel;
        private DateTime _Start;
        private int _Stunden;
        private int _Preis;
        private Person _Trainer;







        public string Titel
        {
            get => _Titel;

            set
            {
                Console.WriteLine("New Titel:" + value);
                _Titel = value;
            }
        }

        public DateTime Start
        {
            get => _Start;


            set
            {
                Console.WriteLine("Neues StartDatum:" + value);
                _Start = value;
            }
        }

        public int Stunden
        {
            get => _Stunden;

            set
            {
                Console.WriteLine("Neue Stunden Anzahl:" + value);
                _Stunden = value;
            }
        }

        public int Preis
        {
            get => _Preis;

            set
            {
                Console.WriteLine("Der Neue Preis ist:" + value);
                _Preis = value;
            }
        }

        public Person Trainer
        {
            get => _Trainer;

            set
            {
                Console.WriteLine("Der Neue Trainer ist:" + value);
            }
        }


        public KurseUndTrainer(string Titel, DateTime Start, int Stunden, int Preis, Person Trainer)
        {
            _Titel = Titel;
            _Start = Start;
            _Stunden = Stunden;
            _Preis = Preis;
            _Trainer = Trainer;



        }


        public override string ToString()
        {
            return string.Format("Titel: {0}\nStart: {1}\nStunden: {2}\nPreis: {3}\nTrainer: {4}",
                _Titel,
                _Start,
                _Stunden,
                _Preis,
                _Trainer.Name);
        }
    }
}
