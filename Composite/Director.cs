using System;
using System.Collections.Generic;

namespace Composite

//Composite
{
    public class Director : Employee
    {
        private List<Employee> _subEmployees = new List<Employee>();

        public Director(string name) : base(name)
        {
        }

        public override void ShowEmployeeDetails()
        {
            Console.Write("Director = ");
            base.ShowEmployeeDetails();
            Console.WriteLine($"{_name}'s sub employees =");
            _subEmployees.ForEach(x => x.ShowEmployeeDetails());
            Console.WriteLine($"Showed all sub employees of {_name}");
        }

        public void AddEmployees(params Employee[] employee)
        {
            _subEmployees.AddRange(employee);
        }
    }
}