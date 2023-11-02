using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarioLuis.Week06
{
    public class Kurs
    {
        private string Title { get; set; }

        public DateOnly Start { get; set; }

        private int Hours { get; set; }

        private int Costs { get; set; }

        private string Trainer { get; set; }

        public Kurs(string title, DateOnly start, int hours, int costs, string trainer) 
        {
            Title = title;
            Start = start;
            Hours = hours;
            Costs = costs;
            Trainer = trainer;
        }
        public override string ToString()
        {
            return "Course: " + Title + " " + Start + " " + Hours + "h" + " " + Costs + " € " + Trainer;
        }
    }
}
