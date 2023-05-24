namespace ClassConstructors
{
    class Program
    {
        static void Main(string[] args)
        {
            // using var instead of Customer to minimise clutter
            var customer = new Customer(1, "James");

            var order = new Order();
            customer.Orders.Add(order);
            
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);

        }
    }
}
