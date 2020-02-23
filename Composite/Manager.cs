using System;

namespace Composite

//Leaf
{
    public class Manager : Employee
    {
        public Manager(string name) : base(name)
        {
        }

        public override void ShowEmployeeDetails()
        {
            Console.Write("Manager = ");
            base.ShowEmployeeDetails();
        }
    }
}