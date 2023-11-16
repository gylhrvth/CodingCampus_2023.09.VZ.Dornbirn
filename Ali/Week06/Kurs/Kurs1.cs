using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Ali.Week06.Kurs
{
    public class Kurs1
    {
        private string _Titel;
        private string _Begin;
        private int _Hours;
        private int _Price;
        private string _Trainer;
        public string Titel
        {
            get => _Titel;
            set
            {
                Console.WriteLine("The Name of the Person is: " + value);
                _Titel = value;
            }
        }
        public string Begin
        {
            get => _Begin;
            set
            {
                Console.WriteLine("The begin of the Kurs is:" + value);
                _Begin = value;
            }

        }
        public int Hours
        {
            get => _Hours;
            set
            {
                Console.WriteLine("The Hours of the Kurs are:" + value);
                _Hours = value;
            }
        }
        public int Price
        {
            get => _Price;
            set
            {
                Console.WriteLine("The Price for the Kurs is:" + value);
                _Price = value;
            }
        }
        public string Trainer
        {
            get => _Trainer;
            set
            {
                Console.WriteLine("The Trainer for the Kurs is:" + value);
                _Trainer = value;
            }
        }
        public Kurs1(string Titel, string Begin, int Hours, int Price, string Trainer)
        {
            _Titel = Titel;
            _Begin = Begin;
            _Hours = Hours;
            _Price = Price;
            _Trainer= Trainer;
            
        }
        public override string ToString()
        {
            return string.Format("Titel: {0}\nBegin: {1}\nHours: {2}h\nPrice: {3} Euro\nTrainer: {4}",
            _Titel,
            _Begin,
            _Hours,
            _Price,
            _Trainer); 


        }



    }


}
