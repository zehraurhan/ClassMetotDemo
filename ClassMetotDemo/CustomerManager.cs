using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add( Customer customer ) 
        {
            Console.WriteLine("Customer added" + " :" + customer.CustomerName);
        }

        public void Delete (Customer customer)
        {
            Console.WriteLine("Customer deleted" + " :" + customer.CustomerName);
        }

        public void List( Customer customer)
        {
            Console.WriteLine("Customer listed" + " :" + customer.CustomerName);
        }
    }


}
