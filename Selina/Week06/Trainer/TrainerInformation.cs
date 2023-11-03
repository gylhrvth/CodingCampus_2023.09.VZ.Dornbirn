using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using System.Threading.Tasks;

namespace Selina.Week06.Trainer
{
    public class TrainerInformation
    {
        private string _Title;
        private float _Start;
        private int _CourseHours;
        public float _Price;
        public string _Name;
        public float Price
        {
            get => _Price;
            set
            {
                Console.WriteLine("Der Preis ist: " + value);
                _Price = value;
            }
        }
        public TrainerInformation(string title, float start, int coursehours, float price, string name)
        {
            this._Title = title;
            this._Start = start;
            this._CourseHours = coursehours;
            _Price = price;
            this._Name = name;
        }
        public override string ToString()
        {
            return string.Format("{0} startet um {1} und wird {2} Stunden dauern, es wird {3}€ kosten und der Trainer heißt: {4}", _Title, _Start, _CourseHours, _Price, _Name);
        }
    }
}
