using System;

namespace FluentInterfaceDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee theEmployee = new FluentEmployee()
                .setId(2)
                .setName("Homaee")
                .setRole("Boss")
                .build();

            System.Console.WriteLine(theEmployee.Name);
        }
    }
}
