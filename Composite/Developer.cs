using System;

namespace Composite

//Leaf
{
    public class Developer : Employee
    {
        public Developer(string name) : base(name)
        {
        }

        public override void ShowEmployeeDetails()
        {
            Console.Write("Developer = ");
            base.ShowEmployeeDetails();
        }
    }
}