using System;
using System.Collections.Generic;

namespace OopsConcept
{
   

    class Courses
    {
        public string Name { get; }
        public Teacher Teacher { get; }
        public List<Student> Students { get; }
        public Courses(string name, Teacher teacher)
        {
            Name = name;
            Teacher = teacher;
            Students = new List<Student>();

        }
        public void AddStudent(Student student)
        {
            Students.Add(student);
        }
    }
}
