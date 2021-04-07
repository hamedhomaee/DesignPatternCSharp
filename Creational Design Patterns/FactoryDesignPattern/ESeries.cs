namespace FactoryDesignPattern
{
    public class ESeries : Benz
    {
        public override string Model { get; set; } = "E";
        public override void ZeroToHundred()
        {
            System.Console.WriteLine("8 Seconds");
        }
    }
}