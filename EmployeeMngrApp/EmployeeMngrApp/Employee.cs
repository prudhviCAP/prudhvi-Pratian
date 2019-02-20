using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeMngrApp
{
    class Employee
    {
        public int EmpId { get; set; }

        public string EmpName { get; set; }

        public string Address { get; set; }

        public int BSal { get; set; }

        public virtual double CalcSalary()
        {
            return BSal + 15000;

        }
    }
}
