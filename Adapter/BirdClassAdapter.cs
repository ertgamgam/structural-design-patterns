namespace Adapter
{
    public class BirdClassAdapter : Sparrow, IToyDuck
    {
        public void Squeak()
        {
            base.MakeSound();
        }
    }
}