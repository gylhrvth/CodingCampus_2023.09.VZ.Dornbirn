using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timo.Week08._063Bank
{
    public class Kunde
    {
        private string _Name;
        private int _KundenID;
        private int _Bankgeschaeft;

        public Kunde(string name)
        {
            _Name = name;
        }
        public string Name
        { get => _Name; }
        public int Bankgeschaeft
        { get => _Bankgeschaeft; }

        public void PrintKunde()
        {
            //Console.WriteLine("Name: {0}, Bankgeschäft: {1}",
            //_Name,
            //_Bankgeschäft < 0 ?  "Abhebung: " + _Bankgeschäft * -1 + "€" : "Einzahlung: " + _Bankgeschäft + "€") ;
            //ToDo Farben!
        }

        public void BankGeschaeft(Schalter schalter, int i)
        {
            _Bankgeschaeft  = i; 
            if (schalter.VerfuegbareGeldsumme + i > 0)
            {
                schalter.VerfuegbareGeldsumme = schalter.VerfuegbareGeldsumme + i;
                schalter.KundenlisteSchalter.Add(this);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Der Schalter hat zu wenig Geld und muss neu befüllt werden");
                Console.ResetColor();
                schalter.StatusGeschlossen = true; //ToDo geschlossen für 1 Kunde
                schalter.VerfuegbareGeldsumme += schalter.AddGelsumme;
            }
            Console.WriteLine("Name: {0}, Bankgeschäft: {1}", _Name, i < 0 ? "Abhebung: " + i * -1 + "€" : "Einzahlung: " + i + "€");
        }

        
    }
}