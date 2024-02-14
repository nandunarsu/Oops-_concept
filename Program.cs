using System;

namespace EmployeWageComputation
{
    class Employee
    {
        static void Main()
        {
            int totaldays = 20;
            Console.WriteLine("Welcome to Employee Wage Computation program");

            Employeepresence fullem = new Employeepresence("nandu");
            fullem.Employeeattendence("nandu");


            fulltimeemplyee obj = new fulltimeemplyee("nandu", 50, 7, totaldays);
            obj.displaywage();

            Employees obj1 = new PartTimeEmployee("partimeemployee", 35, 7, totaldays);
            obj1.displaywage();


            //PartTimeEmployee obj = new PartTimeEmployee("nandu",50,7,totaldays);
            //obj.Calculatemonthlywage();


        }
    }
}
