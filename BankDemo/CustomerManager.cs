using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodsDemo
{
    class CustomerManager
    {
        public void AddCustomer(Customer customer){
            Console.WriteLine("Customer Added : " + customer.Name);
        }
        public void ChangeName(Customer customer, string newName)
        {
            customer.Name = newName;
        }
        public void DeleteCustomer(Customer customer)
        {
            Console.WriteLine("Customer Deleted : " + customer.Name);
        }

    }
}
