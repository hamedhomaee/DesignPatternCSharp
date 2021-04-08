namespace FactoryMethodDesignPattern
{
    public class BMW : ICar
    {
        public string Model { get; set; } = "BMW";
        public void ZeroToHundred() {
            System.Console.WriteLine("6 Seconds");
        }
    }
}