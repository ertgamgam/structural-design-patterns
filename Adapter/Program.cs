using System;

namespace Adapter
{
//https://www.geeksforgeeks.org/adapter-pattern/
    class Program
    {
        static void Main(string[] args)
        {
            IToyDuck toyDuck = new PlasticToyDuck();
            toyDuck.Squeak();

            IBird bird = new Sparrow();
            bird.MakeSound();

            BirdObjectAdapter birdAdapter = new BirdObjectAdapter(bird);
            birdAdapter.Squeak();

            SparrowClassAdapter sparrowAdapter = new SparrowClassAdapter();
            sparrowAdapter.Squeak();
        }
    }
}