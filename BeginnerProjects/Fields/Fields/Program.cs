using System;

namespace Fields
{
    class Program
    {
        static void Main(string[] args)
        {
            // see Customer.cs for comments on readonly
            var customer = new Customer(1);
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());

            Console.WriteLine(customer.Orders.Count);
        }
    }
}
