namespace AbstractFactoryDesignPattern
{
    public class WindowsUiFactory : UiFactory
    {
        public override UiElement CreateUiElement(string type)
        {
            return type switch
            {
                "Button" => new Button() { Name = "Windows Button", Platfrom = "Windows" },
                "TextArea" => new TextArea() { Name = "Windows Text Area", Platfrom = "Windows" },
                _ => null
            };
        }
    }
}