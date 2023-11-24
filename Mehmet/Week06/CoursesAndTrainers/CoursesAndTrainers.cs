using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kerem
{
    internal class CoursesAndTrainers
    {
        private string _Title;
        private DateTime _Start;
        private int _NumberOfCourrses;
        private int _Cost;
        private Person _Trainer;
        public Person Trainer 
        { 
            get => _Trainer; 
            set => _Trainer = value;
        }



        public CoursesAndTrainers(string Title, DateTime Start, int NumberOfCourses,int Cost, Person Trainer)
        {
            _Title = Title;
            _Start = Start;
            _NumberOfCourrses = NumberOfCourses;
            _Cost = Cost;
            _Trainer = Trainer;
        }
            


        
        public override string ToString()
        {
            return string.Format(
                "Title: {0}\nStart: {1}\nNumber of Courses: {2}\nCost: {3}\nTrainer: {4} ({5})",
                _Title,
                _Start,
                _NumberOfCourrses,
                _Cost,
                _Trainer.Name,
                _Trainer.Age);
        }


        
    }
}
