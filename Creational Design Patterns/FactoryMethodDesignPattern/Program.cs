using System;

namespace FactoryMethodDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ICar myCar = new BMWFactory().PassCar();
            myCar.ZeroToHundred();
        }
    }
}
