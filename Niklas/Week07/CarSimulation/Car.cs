using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Niklas.Week07.CarSimulation
{
    internal class Car
    {
        private string _Hersteller;
        private string _Modell;
        private int _kW;
        private double _Tankinhalt;
        private Antriebsart _Antrieb;
        private int _Gewicht;


        public string Hersteller
        {
            get => _Hersteller;
            set
            {
                Console.WriteLine($"Hersteller ist {value}");
                _Hersteller = value;
            }

        }
        public string Modell
        {
            get => _Modell;
            set
            {
                Console.WriteLine($"Modell ist {value}");
                _Modell = value;
            }

        }
        public Antriebsart Antrieb
        {
            get => Antrieb;
            set
            {
                Console.WriteLine($"antriebsart ist {value}");
                _Antrieb = value;
            }

        }
        public int kW
        {
            get => _kW;
            set
            {
                Console.WriteLine($"kW sind {value}");
                _kW = value;
            }

        }
        public double Tankinhalt
        {
            get => _Tankinhalt;
            set
            {
                Console.Write("");
                _Tankinhalt = value;
            }

        }
        public int Gewicht
        {
            get => _Gewicht;
            set
            {
                Console.WriteLine($"Gewicht ist {value}");
                _Gewicht = value;
            }

        }
        public Car(string hersteller, string modell, int kw, double tankinhalt, Antriebsart antriebsart, int gewicht)
        {
            _Hersteller = hersteller;
            _Modell = modell;
            _kW = kw;
            _Tankinhalt = tankinhalt;
            _Antrieb = antriebsart;
            _Gewicht = gewicht;
        }

        public Car(string hersteller, string modell, int kw, int tankinhalt, int gewicht)
        {
            _Hersteller = hersteller;
            _Modell = modell;
            _kW = kw;
            _Tankinhalt = tankinhalt;
            _Antrieb = Antriebsart.Benzin;
            _Gewicht = gewicht;
        }


    }
}
