using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Foods;

namespace Employees
{
    internal class Employee
    {
        //propertys
        private string name;
        private int employeeId;

        //encapsulation
        public string Name
        {
            get { return name; }
            internal set { name = value; }
        }

        public int EmployeeId
        {
            get { return employeeId; }
        }

        //constructor
        public Employee(String name, List<Employee> Staff)
        {
            this.name = name;
            this.employeeId = IdNumber(Staff);
        }

        //private methood
        private int IdNumber(List<Employee> Staff)
        {

            employeeId = 1;

            foreach (Employee e in Staff)
            {
                if (employeeId == e.employeeId)
                {
                    employeeId++;
                }
                else
                {
                    return employeeId;
                }
            }
            return employeeId++;
        }
        internal string NewName(string Name)
        {
            return Name;
        }

        //Override ToString
        public override string ToString()
        {
            return name;
        }
    }
}
