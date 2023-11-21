using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Timo.Week08._063Bank
{
    public class Schalter
    {
        private int _SchalterNummer;
        private bool _StatusGeschlossen = false;
        private bool _StatusBesetzt = false;
        private int _VerfuegbareGeldsumme;
        private int _AddGelsumme;
        private List<Kunde> _KundenlisteSchalter = new();
        private int _StatEinzahlung;
        private int _StatAuszahlung;


        public Schalter(int schalterNummer, int verfuegbareGeldsumme)
        {
            _SchalterNummer = schalterNummer;
            _VerfuegbareGeldsumme = verfuegbareGeldsumme;
            _AddGelsumme = verfuegbareGeldsumme;
        }
        public bool StatusBesetzt
        {
            get => _StatusBesetzt;
            set => _StatusBesetzt = value;
        }
        public bool StatusGeschlossen
        {
            get => _StatusGeschlossen;
            set => _StatusGeschlossen = value;
        }
        public int Schalternummer
        { get => _SchalterNummer; }
        public List<Kunde> KundenlisteSchalter
        { get => _KundenlisteSchalter; }
        public int VerfuegbareGeldsumme
        {
            get => _VerfuegbareGeldsumme;
            set => _VerfuegbareGeldsumme = value;
        }
        public int AddGelsumme
        { get => _AddGelsumme; }


        public void PrintSchalter()
        {
            Console.WriteLine("Schalter: {0}, Status: {1}, Verfügbare Summe im Schalter: {2}€, Liste an Kunden des Tages:",
                _SchalterNummer,
                _StatusGeschlossen == false ? "Geöffnet" : "Geschlossen",
                _VerfuegbareGeldsumme);
            foreach (Kunde kunde in _KundenlisteSchalter)
            {
                kunde.PrintKunde();
            }
        }

        public void PrintSchalterStatistik()
        {
            Console.WriteLine("Schalter \"{0}\" bediente folgende Kunden: ", Schalternummer);
            foreach(Kunde kunde in _KundenlisteSchalter)
            {
                Console.WriteLine("Name: {0}, Bankgeschäft: {1}", kunde.Name, kunde.Bankgeschaeft < 0 ? "Abhebung: " + kunde.Bankgeschaeft * -1 + "€" : "Einzahlung: " + kunde.Bankgeschaeft + "€");
                if (kunde.Bankgeschaeft < 0)
                {
                    _StatAuszahlung += -1 * kunde.Bankgeschaeft;
                }
                else
                {
                    _StatEinzahlung += kunde.Bankgeschaeft;
                }
            }
            Console.WriteLine("Gesammteinzahlungen: {0}€, Gesamtauszahlungen: {1}€, Kassenstand am Schalter: {2}€\n", _StatEinzahlung, _StatAuszahlung, _VerfuegbareGeldsumme);
        }


        public void Pause()
        {
            Random random = new Random();
            int i = random.Next(101);
            if (i <= 20)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Der Schalter ist für eine Pause geschlossen");
                Console.ResetColor();
                _StatusGeschlossen = true; //ToDo geschlossen für 3 Kunden
            }
        }

        //public void AddKunde(Kunde kunde)
        //{
        //    _Kundenliste.Add(kunde);
        //}

        //public int TakeABreak() 
        //{
        //    Random random = new Random();
        //    int i = random.Next(101);
        //    if (i <= 20)
        //    {
        //        Console.WriteLine("Der Schalter ist für eine Pause geschlossen!");
        //        return Kundencount + 1;
        //    }
        //}
    }
}