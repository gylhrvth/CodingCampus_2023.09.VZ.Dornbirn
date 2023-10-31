 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Michael.Week06
{
    internal class Course
    {
        private string _Title;
        private DateTime _Start;
        private int _CourseHoursCount;
        private double _Price;
        private Person _Trainer;

        public Course(string title,  DateTime start, int courseHoursCount, double price, Person trainer)
        {
            _Title = title;
            _Start = start;
            _CourseHoursCount = courseHoursCount;
            _Price = price;
            _Trainer = trainer;
        }


        public override string ToString()
        {
            return $"*{_Title}*\n\nStart: {_Start.ToString("dd.MM.yyyy hh.mm")}\nHours: {_CourseHoursCount}\nPrice: {_Price}Є\n\n\n*Trainer*\n\n{_Trainer.ToString()}";
        }
    }
}