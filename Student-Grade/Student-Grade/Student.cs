using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Grade
{
    internal class Student
    {
        private string Name;
        private List<int> Grades;

        public Student(string name)
        {
            this.Name = name;
            Grades = new List<int>();
        }
        public void AddGrade(int grade)
        {
            Grades.Add(grade);
        }

        public double GetAverageGrade()
        {
            return Grades.Average();
        }
    }
}
