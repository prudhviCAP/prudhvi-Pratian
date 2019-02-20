using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Emp = new Employee();

            StoreData(Emp);

            ShowData(Emp);
        }

        static void StoreData(Employee Emp)
        {
            Console.Write(" Enter Employee id : ");
            Emp.EmployeeId = CustomConsole.ReadInt();
            Console.WriteLine();

            Console.Write(" Enter Employee Name : ");
            Emp.Name = CustomConsole.ReadString();
            Console.WriteLine();

            Console.Write(" Enter Employee Gender : ");
            Emp.Gender = CustomConsole.ReadChar();
            Console.WriteLine();

            Console.WriteLine(" Enter Employee Address : ");
            Address address = new Address();

            Console.WriteLine("Address1 : ");
            address.Address1 = CustomConsole.ReadString();
            Console.WriteLine();

            Console.WriteLine("Address2 : ");
            address.Address2 = CustomConsole.ReadString();
            Console.WriteLine();

            Console.WriteLine("City : ");
            address.City = CustomConsole.ReadString();
            Console.WriteLine();

            Console.WriteLine("Pincode : ");
            address.PinCode = CustomConsole.ReadInt();
            Console.WriteLine();

            Emp.EmpAddress = address;

        }

        static void ShowData(Employee Emp)
        {

            //----------------Display the employee information
            Console.WriteLine("Employee Id : "+Emp.EmployeeId);
            Console.WriteLine("Employee Name : "+Emp.Name);
            Console.WriteLine("Employee Gender : "+Emp.Gender);

            Console.WriteLine("Employee Address : --------------");
            Console.WriteLine("Address 1 : "+Emp.EmpAddress.Address1);
            Console.WriteLine("Address 2 : "+Emp.EmpAddress.Address2);
            Console.WriteLine("City : "+Emp.EmpAddress.City);
            Console.WriteLine("PinCode : "+Emp.EmpAddress.PinCode);
            Console.WriteLine("----------------------------------");

            Console.ReadLine();
        }
    }
}
