namespace AbstractFactoryDesignPattern
{
    public class Button : UiElement
    {
        public override string Name { get; set; }
        public override string Platfrom { get; set; }
        public override int Width { get; set; }
        public override int Height { get; set; }
    }
}