using System;

//https://www.turkayurkmez.com/facade-design-pattern/
namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Facade facade = new Facade();
            facade.Operation1();
            facade.Operation2();
        }
    }
}