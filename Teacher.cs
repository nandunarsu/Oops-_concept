using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    class Teacher:Baseclass
    {
        public List<Courses> Coursesthought { get; }
        public int grade { get; set; }
        public Teacher(string name, string email) : base(name, email)
        {
            Coursesthought = new List<Courses>();
        }

        public void AssignGrade (Student student, int grade)
        {
            student.grade = grade;
        }
    }
}
