namespace AbstractFactoryDesignPattern
{
    public class MacUiFactory : UiFactory
    {
        public override UiElement CreateUiElement(string type)
        {
            return type switch
            {
                "Button" => new Button() { Name = "Mac Button", Platfrom = "Mac" },
                "TextArea" => new TextArea() { Name = "Mac Text Area", Platfrom = "Mac" },
                _ => null
            };
        }
    }
}