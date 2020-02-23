using System;

//Compoenent
namespace Composite
{
    public abstract class Employee
    {
        protected string _name;

        protected Employee(string name)
        {
            _name = name;
        }

        public virtual void ShowEmployeeDetails()
        {
            Console.WriteLine($"Name = {_name}");
        }
    }
}