using System;
using System.Collections.Generic;
namespace OopsConcept
{
    class Person
    {
        static void Main()
        {
            Teacher teacher = new Teacher("Physics", "praveen");
            Student student1= new Student("Nandini", "nandu@gmail.com");

            Courses courses = new Courses("Physics", teacher);

            courses.AddStudent(student1);

            teacher.AssignGrade(student1, 10);

            Console.WriteLine($"{courses.Name},{student1.grade}");


        }
    }
}