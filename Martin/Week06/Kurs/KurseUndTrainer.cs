using Martin.Week06.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Martin.Week06.Kurs
{
    public class KurseUndTrainer
    {
        private string _Title;
        private string _start;
        private int _KursStunden;
        private PersonAufgabe _Trainer;
        public KurseUndTrainer(string Title, int KursStunden, string start, PersonAufgabe Trainer)
        {

           _Title = Title;
           _start = start;
           _KursStunden = KursStunden;
           _Trainer = Trainer;
        }



        public override string ToString()
        {
           
            return string.Format("Title: {0}\n Start: {1}\n KursStunden: {2}\n Trainer: {3}", _Title, _start, _KursStunden,_Trainer.Name);
        }
























    }
}
