using System;

namespace BuilderDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            User googleuser = Director.MakeUser(new GoogleUserBuilder(), 45);
            System.Console.WriteLine(googleuser.Roles);
            System.Console.WriteLine(googleuser.Id);
        }
    }
}
