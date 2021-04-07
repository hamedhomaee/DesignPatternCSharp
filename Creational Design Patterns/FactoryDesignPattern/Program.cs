using System;

namespace FactoryDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Benz myBenz = BenzFactory.CreateBenz("C");
            myBenz.ZeroToHundred();
        }
    }
}
