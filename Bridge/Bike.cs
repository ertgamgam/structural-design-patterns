using System;
using System.Collections.Generic;

namespace Bridge
{
    public class Bike : Vehicle
    {
        public Bike(List<IWorkshop> workshops) : base(workshops)
        {
        }

        public override void Manufacture()
        {
            Console.Out.WriteLine("Bike");
            _workshops.ForEach(ws => ws.Work());
        }
    }
}