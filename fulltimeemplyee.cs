using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EmployeWageComputation
{
    class fulltimeemplyee : Employees
    {
       

        public fulltimeemplyee(String name, double hourlywage, int totalhours, int totaldays):base(name, hourlywage, totalhours, totaldays)
        {
            
        }
        public override double Calculatemonthlywage()
        {
            return hourlywage * totaldays * totalhours;
        }

    }
}
