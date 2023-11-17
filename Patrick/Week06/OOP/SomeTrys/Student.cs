using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Patrick.Week06.OOP.SomeTrys
{
    internal class Student
    {
        public int _Id { get; private set; }
        public string _Name { get; private set; }
        public float _GradePointAverage { get; private set; }


        public Student(int id, string name, float gradePointAverage)
        {
            _Id = id;
            _Name = name;
            _GradePointAverage = gradePointAverage;
        }
    }


}
