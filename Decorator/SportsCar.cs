using System;

namespace Decorator
{
    public class SportsCar : CarDecorator
    {
        private bool _isTurboEnabled;

        public SportsCar(ICar car) : base(car)
        {
        }

        public override void Assemble()
        {
            base.Assemble();
            Console.WriteLine("Adding features of Sports Car");
        }

        public void EnableTurboMode()
        {
            _isTurboEnabled = true;
        }

        public void DisableTurboMode()
        {
            _isTurboEnabled = false;
        }

        public void IsTurboEnabled()
        {
            Console.WriteLine($"Turbo Mode =  {_isTurboEnabled}");
        }
    }
}