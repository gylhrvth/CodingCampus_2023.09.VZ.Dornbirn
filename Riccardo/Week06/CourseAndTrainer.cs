using System;
using System.Xml.Linq;
namespace Riccardo.Week06;

    public class CourseAndTrainer
    {

        private string _Title;
        private int _Start;
        private int _CourseHours;
        private int _Price;
        private string _Trainer;

        public CourseAndTrainer(string title, int start, int coursehours, int price, string trainer)
        {
            _Title = title;
            _Start = start;
            _CourseHours = coursehours;
            _Price = price;
            _Trainer = trainer;
        }

        public override string ToString()
        {
            return String.Format("Titel: {0}\nStart: {1} Uhr\nKursstunden: {2}\nPreis: {3}\nTrainer: {4}", _Title, _Start, _CourseHours, _Price, _Trainer);
        }

}