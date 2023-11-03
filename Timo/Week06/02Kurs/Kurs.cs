using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timo.Week06._01Person;

namespace Timo.Week06._02Kurs
{
    public class Kurs
    {
        private string _Title;
        private DateTime _Start;
        private int _HoursOfCourse;
        private double _Price;
        private Person _Trainer;

        public Kurs(string Title, DateTime Start, int HoursOfCourse, double Price, Person Trainer)
        {
            _Title = Title;
            _Start = Start;
            _HoursOfCourse = HoursOfCourse;
            _Price = Price;
            _Trainer = Trainer;
        }

        public string Title
        {
            get { return _Title; }
            set
            {
                if (value != " ") { Console.WriteLine("Title is changing to : " + value); _Title = value; }
                else { Console.WriteLine("Title mustn't be empty!"); }
            }
        }
        public DateTime Start
        {
            get { return _Start; }
            set { Console.WriteLine("Title is changing to : " + value); _Start = value; }
        }
        public int HoursOfCourse
        {
            get { return _HoursOfCourse; }
            set
            {
                if (value > 0) { Console.WriteLine("Hours of the Course are changing to: " + value); _HoursOfCourse = value; }
                else { Console.WriteLine("Hours of the Course can't be lower than 0"); }
            }
        }
        public double Price
        {
            get { return _Price; }
            set
            {
                if (value > 0) { Console.WriteLine("Age is changing to: " + value); _Price = value; }
                else { Console.WriteLine("Age can't be lower than 0"); }
            }
        }
        public Person Trainer
        {
            get { return _Trainer; }
        }


        public override string ToString()
        {
            return string.Format("Title of course: \t{0}\nStartdate of course: \t{1}\nTotal Hours of course: \t{2}h\nPrice of course: \t{3}€\nTrainer: \n{4}",
                Title,
                Start.ToString("d"),
                HoursOfCourse,
                Price,
                Trainer);
        }
    }
}
