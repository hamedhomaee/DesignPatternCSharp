namespace AbstractFactoryDesignPattern
{
    public abstract class UiFactory
    {
        public abstract UiElement CreateUiElement(string type);
        public static UiFactory CreateUiFactory(string type) 
        {
            return type switch 
            {
                "Mac" => new MacUiFactory(),
                "Windows" => new WindowsUiFactory(),
                _ => null
            };
        }
    }
}