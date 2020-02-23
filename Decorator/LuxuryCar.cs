using System;

namespace Decorator
{
    public class LuxuryCar : CarDecorator
    {
        public LuxuryCar(ICar car) : base(car)
        {
        }

        public override void Assemble()
        {
            base.Assemble();
            Console.WriteLine("Adding features of LuxuryCar");
        }
    }
}