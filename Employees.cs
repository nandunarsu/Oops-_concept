using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeWageComputation
{
   public abstract class Employees
    {
        public String name;
        public double hourlywage;
        public int totalhours;
        public int totaldays;

        public Employees(String name,double hourlywage,int totalhours,int totaldays)
        {
            this.name = name;
            this.hourlywage = hourlywage;
            this.totalhours = totalhours;
            this.totaldays = totaldays;
        }

       public abstract double Calculatemonthlywage();

        public void displaywage()
        {
            Console.WriteLine(name + " monthly wage " + Calculatemonthlywage() + " rupees");
        }
    }
}
