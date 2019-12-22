namespace Adapter
{
    public class SparrowClassAdapter : Sparrow, IToyDuck
    {
        public void Squeak()
        {
            base.MakeSound();
        }
    }
}