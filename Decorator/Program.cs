using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            SportsCar sportsCar = new SportsCar(new BasicCar());
            sportsCar.Assemble();
            sportsCar.EnableTurboMode();
            sportsCar.IsTurboEnabled();
            sportsCar.DisableTurboMode();
            sportsCar.IsTurboEnabled();

            Console.WriteLine();
            ICar luxuryCar = new LuxuryCar(new BasicCar());
            luxuryCar.Assemble();
        }
    }
}