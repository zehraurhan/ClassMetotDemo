using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Customer customer1 = new Customer();
            customer1.CustomerId = 1;
            customer1.CustomerName = "Tuba";
            customer1.CustomerLastName = "Akay";
            customer1.CustomerAge = 18;

            Customer customer2 = new Customer();
            customer2.CustomerId = 2;
            customer2.CustomerName = "Ahmet";
            customer2.CustomerLastName = "Aka";
            customer2 .CustomerAge = 19;

            CustomerManager customermanager = new CustomerManager();
            customermanager.Add(customer1);
            customermanager.Delete(customer2);






        }
    }
}
