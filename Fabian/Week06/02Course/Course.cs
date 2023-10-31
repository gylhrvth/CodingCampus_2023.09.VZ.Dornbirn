using Fabian.Week06._01Person;
namespace Fabian.Week06._02Course
{
    public class Course
    {
        private string _Title;
        private DateTime _Start;
        private int _CourseHours;
        private int _Price;
        private Person _Trainer;
        public string Title
        {
            get => _Title;
            set
            {
                if (Title == "")
                {
                    Console.WriteLine("title can't be empty");
                }
                else
                {
                    _Title = value;
                }
            }
        }
        public DateTime Start
        {
            get => _Start;
            set => _Start = value;
        }
        public int CourseHours
        {
            get => _CourseHours;
            set => _CourseHours = value;
        }
        public int Price
        {
            get => _Price;
            set => _Price = value;
        }
        public Person Trainer
        {
            get => _Trainer;
            set => _Trainer = value;
        }

        public Course(string title, DateTime start, int courseHours, int price, Person trainer)
        {
            _Title = title;
            _Start = start;
            _CourseHours = courseHours;
            _Price = price;
            _Trainer = trainer;
        }
       
      
        public override string ToString()
        {
            return String.Format("Title: {0}\nStart: {1}\nCourse hours: {2}\nPrice: {3}\nTrainer:\n{4}",
                _Title,
                _Start.ToString("d"),
                _CourseHours,
                _Price,
                _Trainer);
        }
    }
}
