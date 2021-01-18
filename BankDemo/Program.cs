using ClassMethodsDemo;
using System;

namespace BankDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Name = "Furkan";
            customer1.Surname = "Arıca";
            customer1.DateOfBirth = 2005;
            CustomerManager customerManager = new CustomerManager();
            customerManager.AddCustomer(customer1);
            customerManager.ChangeName(customer1, "Göktuğ Furkan");
            Console.WriteLine(customer1.Name);
        }
    }
}
