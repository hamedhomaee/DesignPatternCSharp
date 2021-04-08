namespace FactoryMethodDesignPattern
{
    public abstract class Factory
    {
        protected abstract ICar Create();
        public ICar PassCar() 
        {
            System.Console.WriteLine("Assigning four wheels: ");
            return this.Create();
        }
    }
}