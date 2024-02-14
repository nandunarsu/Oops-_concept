using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeWageComputation
{
    class PartTimeEmployee : Employees
    {
        public PartTimeEmployee(string name,double hourlywage,int totalhours,int totaldays):base(name,hourlywage,totalhours,totaldays) {
            
        }
        public override double Calculatemonthlywage()
        {
            return hourlywage * totaldays * totalhours;
        }
    }
}
