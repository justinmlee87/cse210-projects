using System;


class Program
{
    static void Main(string[] args)
    {
        // Create some products
        Product product1 = new Product("Guitar", "P1", 10.0, 2);
        Product product2 = new Product("Amplifier", "P2", 5.0, 3);

        // Create some customers
        Address address1 = new Address("2228 Gator Drive", "Orlando", "FL", "USA");
        Customer customer1 = new Customer("Justin Lee", address1);

        Address address2 = new Address("123 Rocker Street", "Amsterdam", "NL", "Netherlands");
        Customer customer2 = new Customer("Sean Smith", address2);

        // Create some orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);

        // Print packing labels, shipping labels, and total prices for the orders
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total price: $" + order1.GetTotalPrice());

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total price: $" + order2.GetTotalPrice());
    }
}