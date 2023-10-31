using System;
namespace Gyula.Week06.CourseList
{
	public class Course
	{
		private string _Title;
		private DateTime _Start;
        private int _Lenght;
		private int _Price;
		private Person _Trainer;
		public Person Trainer
		{
			get => _Trainer;
			set => _Trainer = value;
		}

        public Course(string title, DateTime start, int lenght)
		{
			_Title = title;
			_Start = start;
			_Lenght = lenght;
			_Price = 50 * lenght;
			_Trainer = null;
		}

        public override string ToString()
        {
			return string.Format(
					"Course: {0}. The trainer of this course is {1}",
					_Title,
					(_Trainer != null) ? _Trainer.Name: "N.N."
					); ;
            /*
			string result = "";

			if (_Trainer != null)
			{
				result = string.Format(
					"Course: {0}. The trainer of this course is {1}",
					_Title,
					_Trainer.Name
					);
			}
			else
			{
                result = string.Format(
                    "Course: {0}. This course has not trainer yet.",
                    _Title
                    );
            }
            return result;
			*/
        }
    }
}

