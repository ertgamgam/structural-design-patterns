using System.Drawing;

namespace Adapter
{
    public class BirdObjectAdapter : IToyDuck
    {
        private IBird _bird;

        public BirdObjectAdapter(IBird bird)
        {
            _bird = bird;
        }

        public void Squeak()
        {
            _bird.MakeSound();
        }
    }
}