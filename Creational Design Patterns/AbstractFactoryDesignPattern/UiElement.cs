namespace AbstractFactoryDesignPattern
{
    public abstract class UiElement
    {
        public abstract string Name { get; set; }
        public abstract string Platfrom { get; set; }
        public abstract int Width { get; set; }
        public abstract int Height { get; set; }

    }
}