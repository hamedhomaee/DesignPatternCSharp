namespace FactoryMethodDesignPattern
{
    public class Ford : ICar
    {
        public string Model { get; set; } = "Ford";
        public void ZeroToHundred() {
            System.Console.WriteLine("7 Seconds");
        }
    }
}