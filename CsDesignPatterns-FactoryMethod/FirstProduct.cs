namespace CsDesignPatterns_FactoryMethod
{
    class FirstProduct : IProduct
    {
        string name = "FirstProduct";

        public string GetName()
        {
            return this.name;
        }
    }
}
