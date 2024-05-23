using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Grade
{
    internal class Classroom
    {
        private List<Student> students;

        public Classroom()
        {
            students = new List<Student>();
        }
        public void AddStudent(Student student)
        {
            students.Add(student);
        }
        public double GetClassAverageGrade()
        {
            return students.Select(s => s.GetAverageGrade()).Average();
        }
    }
}
