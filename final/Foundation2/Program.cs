using System;

class Program
{
    static void Main(string[] args)
    {
        Address firstAddress = new Address("Ninos Heroes", "CDMX", "CDMX", "Mexico");

        Customer firstCostumer = new Customer("Mitzi", firstAddress);

        Product fisrtProduct = new Product("Sabritas", 123, 12, 5);

        // Create orders
        Order order1 = new Order(firstCostumer);
        order1.AddProduct(fisrtProduct);


        // Display results
        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: {order1.CalculateTotalCost():C}");

    }
}