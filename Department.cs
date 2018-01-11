using System;
using System.Collections.Generic;

namespace bangazon
{
    // Parent class for all departments
    public class Department
    {
        private string _name;
        private string _supervisor;
        private int _employee_count;

        private List<Employee> _employees = new List<Employee>();
        

        public double baseBudget {get; set;}
        public string Name { get {return _name;}}

        public List<Employee> Employees {get {return _employees;}}
       
        // You can create properties, if needed

        // Constructor method
        public Department(string name, string supervisor, int employees)
        {
            _name = name;
            _supervisor = supervisor;
            _employee_count = employees;
        }

        // Overriding the default toString() method for each object instance
        public override string ToString()
        {
            return $"Dept: {_name} Supervisor: {_supervisor} Number of Employees: {_employee_count}";
        }

        public virtual void meet(DateTime date) 
        {
            DateTime Date = date;
            Console.WriteLine($"New meeting at {Date}.");
        } 

        public virtual void SetBudget(double budget) 
        {
            baseBudget = budget;
            Console.Write($"Budget: ${baseBudget}");
        }

        public void AddEmployee(Employee employee) 
        {
            _employees.Add(employee);
        }

        public void RemoveEmployee(Employee employee) 
        {
            _employees.Remove(employee);
        }
    }   
}