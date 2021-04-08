namespace FactoryMethodDesignPattern
{
    public class BMWFactory : Factory
    {
        protected override ICar Create()
        {
            return new BMW();
        }
    }
}