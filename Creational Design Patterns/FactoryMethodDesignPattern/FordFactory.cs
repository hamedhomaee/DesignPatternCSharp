namespace FactoryMethodDesignPattern
{
    public class FordFactory : Factory
    {
        protected override ICar Create()
        {
            return new Ford();
        }
    }
}