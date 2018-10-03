namespace CsDesignPatterns_FactoryMethod
{
    class SecondProduct : IProduct
    {
        public string name = "SecondProduct";

        public string GetName()
        {
            return this.name;
        }
    }
}
