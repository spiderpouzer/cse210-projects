using System;

namespace OrderingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create addresses
            Address address1 = new Address("123 Silly Dr", "Sandy", "UT", "USA");
            Address address2 = new Address("456 State Street", "Salt Lake", "UT", "USA");

            // Create customers
            Customer customer1 = new Customer("John Smith", address1);
            Customer customer2 = new Customer("Jane Dixon", address2);

            // Create products
            Product product1 = new Product("Laptop", "A123", 999.99m, 1);
            Product product2 = new Product("Mouse", "B456", 25.99m, 2);
            Product product3 = new Product("Keyboard", "C789", 45.50m, 1);
            Product product4 = new Product("Monitor", "D012", 300.00m, 1);

            // Create orders
            Order order1 = new Order(customer1);
            order1.AddProduct(product1);
            order1.AddProduct(product2);

            Order order2 = new Order(customer2);
            order2.AddProduct(product3);
            order2.AddProduct(product4);

            // Display order details
            Console.WriteLine(order1.GetPackingLabel());
            Console.WriteLine(order1.GetShippingLabel());
            Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost():0.00}\n");

            Console.WriteLine(order2.GetPackingLabel());
            Console.WriteLine(order2.GetShippingLabel());
            Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost():0.00}\n");
        }
    }
}
