using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dimitri.Week06._01Person;

namespace Dimitri.Week06._02Course
{
    public class Course
    {
        private string _Title;
        private string _Start;
        private int _CourseHours;
        private double _Price = 7840;
        private Person _Trainer;

        public string Title
        {
            get => _Title;

            set
            {
                Console.WriteLine("Course Title is changing to: " + value);
                _Title = value;
            }
        }

        public Course(string Title, string Start, int CourseHours, double Price, Person trainer)
        {
            _Title = Title;
            _Start = Start;
            _CourseHours = CourseHours;
            _Price = Price;
            _Trainer = trainer;
        }

        public Course(string Title, string Start, int CourseHours, Person trainer)
        {
            _Title = Title;
            _Start = Start;
            _CourseHours = CourseHours;
            _Trainer = trainer;
        }

        public override string ToString()
        {
            return string.Format("Titel: {0}\nStart: {1}\nAnzahl Kursstunden: {2} Stunden\nPreis: {3} Euro\n\nTrainer:\n{4}", _Title, _Start, _CourseHours, _Price, _Trainer);
        }

        //public override string ToString()
        //{
        //    return string.Format("Titel: {0}\nStart: {1}\nAnzahl Kursstunden: {2} Stunden\nPreis: {3} Euro\n\nTrainer:\n{4}", _Title, _Start, _CourseHours, Price1, _Trainer);
        //}

    }


}
