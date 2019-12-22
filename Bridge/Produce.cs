using System;

namespace Bridge
{
    public class Produce : IWorkshop
    {
        public void Work()
        {
            Console.Out.WriteLine("Produced");
        }
    }
}