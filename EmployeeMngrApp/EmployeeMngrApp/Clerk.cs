using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeMngrApp
{
    class Clerk:Employee
    {
        public int EmpId { get; set; }

        public string EmpName { get; set; }

        public string Address { get; set; }

        public int BSal { get; set; }

        public override double CalcSalary()
        {
            return BSal*1.2;

        }
    }
}
