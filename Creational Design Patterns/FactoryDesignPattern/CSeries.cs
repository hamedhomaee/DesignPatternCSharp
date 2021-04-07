namespace FactoryDesignPattern
{
    public class CSeries : Benz
    {
        public override string Model { get; set; } = "C";
        public override void ZeroToHundred()
        {
            System.Console.WriteLine("10 Seconds");
        }
    }
}