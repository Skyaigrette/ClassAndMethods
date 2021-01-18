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
        public void UpdateCustomer(Customer customer)
        {
            Console.WriteLine("Customer Uptaded : " + customer.Name);
        }
        public void DeleteCustomer(Customer customer)
        {
            Console.WriteLine("Customer Deleted : " + customer.Name);
        }

    }
}
