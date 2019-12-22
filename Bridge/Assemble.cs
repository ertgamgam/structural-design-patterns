using System;

namespace Bridge
{
    public class Assemble : IWorkshop
    {
        public void Work()
        {
            Console.Out.WriteLine("Assembled");
        }
    }
}