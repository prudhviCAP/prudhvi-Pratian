using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeMngrApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();     //employee object created

            Manager mngr1 = new Manager();      //manager object created

            Clerk clrk1 = new Clerk();          //clerk object created

            emp1.BSal = 30000;
            mngr1.BSal = 40000;
            clrk1.BSal = 20000;
            Console.WriteLine("Employee Net Salary: {0} ", emp1.CalcSalary());
            Console.WriteLine("manager Net Salary: {0} ", mngr1.CalcSalary());
            Console.WriteLine("clerk Net Salary: {0} ", clrk1.CalcSalary());
        }
    }
}
