namespace CsDesignPatterns_FactoryMethod
{
    interface IFactoryMethod
    {
        IProduct GetProduct(string name);
    }
}
