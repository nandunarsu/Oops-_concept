using System;


namespace EmployeWageComputation
{
    class Employeepresence 
    {
        public string Name { get; }
        private Random rand = new Random();
        string[] attendencelist = { "Present","Absent" };
        public string attendence {  get;}
        
        public Employeepresence(string name)
        {
            Name = name;
            attendence = attendencelist[rand.Next(0, 2)];

        }

        public void Employeeattendence(string name)
        {

            Console.WriteLine($"Employee {name} is " + attendence);
        }
    }
}
