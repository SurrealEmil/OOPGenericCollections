using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGenericCollections
{
    // Employee class
    public class Employee
    {
        // Class properties
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set;}
        public int Salary { get; set;}

        // Assigns input to class "Employee" variables
        public Employee(int id, string name, string gender, int salary)
        {
            Id = id;
            Name = name;
            Gender = gender;
            Salary = salary;
        }

        public void EmployeeInfo()
        {
            Console.WriteLine($"{Id} - {Name} - {Gender} - {Salary}");
        }

        public void EmployeeInfo2()
        {
            Console.WriteLine($"ID = {Id}, Name = {Name}, Gender = {Gender}, Salary = {Salary}");
        }

        // Custom delegate implementation to check if an employee is male
        public static bool IsMale(Employee employee)
        {
            return employee.Gender == "Male";
        }
    }
}
