using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employees;

namespace Københavns_Zoo
{
    internal class Hr
    {
        //propertys
        private string name;

        //encapsulation
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //constructor
        public Hr(String name)
        {
            this.name = name;
        }
        public void ChangeName(Employee e, string name)
        {
            e.NewName(name);
        }
        //Override ToString
        public override string ToString()
        {
            return name;
        }
    }
}
