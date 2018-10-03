using System;

namespace CsDesignPatterns_FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            IFactoryMethod factory = new FactoryMethod();

            IProduct firstProduct = factory.GetProduct("First");
            IProduct secondProduct = factory.GetProduct("Second");

            Console.WriteLine(firstProduct.GetName());
            Console.WriteLine(secondProduct.GetName());
        }
    }
}
