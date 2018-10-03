namespace CsDesignPatterns_FactoryMethod
{
    class FactoryMethod : IFactoryMethod
    {
        public IProduct GetProduct(string name)
        {
            if (name == "Second")
            {
                return new SecondProduct();
            }

            return new FirstProduct();
        }
    }
}
