using System;
using System.Collections.Generic;

namespace Bridge
{
    public class Car : Vehicle
    {
        public Car(List<IWorkshop> workshops) : base(workshops)
        {
        }

        public override void Manufacture()
        {
            Console.Out.WriteLine("Car");
            _workshops.ForEach(ws => ws.Work());
        }
    }
}