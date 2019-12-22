using System;

namespace Adapter
{
    public class Sparrow : IBird
    {
        public void Fly()
        {
            Console.WriteLine("Sparrow is flying");
        }

        public void MakeSound()
        {
            Console.WriteLine("Sparrow making sound CHIRP!!!! CHIRP!!!!");
        }
    }
}