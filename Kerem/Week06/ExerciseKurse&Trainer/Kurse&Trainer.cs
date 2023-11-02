using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Kerem
{
    public class Kurse_Trainer
    {
        private string _Title;
        private DateTime _Start;
        private int _AmountHours;
        private double _Price;
        private Person _Trainer;



        public Person Trainer  
        {
            get => _Trainer;
            set => _Trainer = value;
        

        }
        public Kurse_Trainer(string Title, DateTime Start, int AmountHours, double Price, Person Trainer)
        {
            _Title = Title;
            _Start = Start;
            _AmountHours = AmountHours;
            _Price = Price;
            _Trainer = Trainer;
        }
        public override string ToString()
        {
            return string.Format("Title: {0}\nStart: {1}\nAmountHours: {2}\nPrice: {3}\nTrainer {4} ",_Title,_Start,_AmountHours, _Price, _Trainer);
        }

    }

 
}
