using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Department.Models;

namespace Department.Models
{
    public class Department
    {

        Employee[] employees = new Employee[0];
        Employee employee;
        public string Name { get; set; }
        public int SalaryLimit { get; set; } = 250;
        public int EmployeeLimit { get; set; } = 2;
        public void AddEmployee()
        {
            for (int i = 0; i <= EmployeeLimit; i++)
            {
                Console.Write("Isci adi daxil edin:  ");
                string name = Console.ReadLine();
                while (!char.IsUpper(name[0]) || name.Any(char.IsDigit) || name.Any(char.IsSymbol))
                {
                    Console.Write("Ad daxil etdikde reqemlerden istifade qadagandir ve ya 1ci herfi boyuk daxil edin:  ");
                    name = Console.ReadLine();
                }
                Console.Write("Isci soyadi daxil edin:  ");
                string surname = Console.ReadLine();
                while (!char.IsUpper(surname[0]) || surname.Any(char.IsDigit) || surname.Any(char.IsSymbol))
                {
                    Console.Write("Soyad daxil etdikde reqemlerden istifade qadagandir ve ya 1ci herfi boyuk daxil edin:  ");
                    surname = Console.ReadLine();
                }
                Console.Write("Isci maasi daxil edin:  ");
                int salary = int.Parse(Console.ReadLine());
                while (salary < SalaryLimit) 
                {
                    Console.Write("Minimum maas 250AZN-dir,duzgun deyer daxil edin:  ");
                    salary = int.Parse(Console.ReadLine());
                }
                if (employees.Length < EmployeeLimit)
                {
                    employee = new Employee(name, surname, salary);
                    Array.Resize(ref employees, employees.Length + 1);
                    employees[employees.Length - 1] = employee;

                }
                else
                {
                    Console.WriteLine("Max ischi sayina chatmisiniz");
                }
            }



        }
        public void ShowEmployee()
        {
            foreach (var employee in employees)
            {
                Console.WriteLine($"Name: {employee.Name}   Surname: {employee.Surname}   Salary: {employee.Salary}");
            }
        }
    }
}