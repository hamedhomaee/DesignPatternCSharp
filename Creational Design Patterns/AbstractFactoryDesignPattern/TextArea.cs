namespace AbstractFactoryDesignPattern
{
    public class TextArea : UiElement
    {
        public override string Name { get; set; }
        public override string Platfrom { get; set; }
        public override int Width { get; set; }
        public override int Height { get; set; }
    }
}