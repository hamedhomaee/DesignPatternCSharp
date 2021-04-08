using System;

namespace AbstractFactoryDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Button uiElement = (Button)UiFactory.CreateUiFactory("Windows").CreateUiElement("Button");
            System.Console.WriteLine(uiElement.Name);
            System.Console.WriteLine(uiElement.Platfrom);
        }
    }
}
