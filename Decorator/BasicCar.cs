using System;

namespace Decorator
{
    public class BasicCar : ICar
    {
        public void Assemble()
        {
            Console.WriteLine("Basic Car is created...");
        }
    }
}