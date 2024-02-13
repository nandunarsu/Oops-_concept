using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcept
{
    class Student:Baseclass
    {

        public List<Courses> course { get; }
        public int grade { get; set; }
        public  Student(string name,string email):base(name,email)
        {
            course = new List<Courses>();
        }

     
    }
}
