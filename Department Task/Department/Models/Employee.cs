using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Department.Models
{
    internal class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Salary { get; set; }
        public Employee(string name, string surname, int salary)
        {
            Name = name;
            Surname = surname;
            Salary = salary;
        }
    }
}