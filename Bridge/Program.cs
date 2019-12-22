using System;
using System.Collections.Generic;


//https://www.geeksforgeeks.org/bridge-design-pattern/
//https://www.turkayurkmez.com/bridge-design-pattern/
namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IWorkshop> workshops = new List<IWorkshop>()
            {
                new Assemble(),
                new Produce()
            };

            Vehicle car = new Car(workshops);
            car.Manufacture();

            Console.Out.WriteLine("");

            Vehicle bike = new Bike(workshops);
            bike.Manufacture();
        }
    }
}