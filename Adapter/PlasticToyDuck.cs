using System;

namespace Adapter
{
    public class PlasticToyDuck : IToyDuck
    {
        public void Squeak()
        {
            Console.WriteLine("PlasticToyDuck SQUEAK!!! ");
        }
    }
}