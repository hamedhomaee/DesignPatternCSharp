using System;

namespace PrototypeDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            User firstUser = new User();
            firstUser.Name = "Hamed";
            firstUser.UserAddress = new Address() { Street = "Leibniz", City = "Clausthal", ZipCode = 38678 };

            User secondUser = firstUser.DeepClone();
            secondUser.UserAddress.City = "Zellerfeld";

            System.Console.WriteLine(firstUser.UserAddress.City);
        }
    }
}
