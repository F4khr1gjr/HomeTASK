using Department.Models;
using System;

namespace Department.Models
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Department department = new Department();
            department.AddEmployee();
            department.ShowEmployee();
        }
    }
}