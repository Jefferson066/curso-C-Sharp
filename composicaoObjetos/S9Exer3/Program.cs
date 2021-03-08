using S9Exer3.Entities;
using S9Exer3.Entities.Enums;
using System;
using System.Globalization;

namespace S9Exer3 {
    class Program {
        static void Main(string[] args) {

            Console.Write("Name ");
            string name = Console.ReadLine();
            Console.Write("email ");
            String email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Client client = new Client(name, email,birthDate);
            Console.WriteLine();

            Console.WriteLine("Enter order data: ");

            Console.Write("Status ");
            OrderStatus status = Enum.Parse<OrderStatus> (Console.ReadLine());
            Console.Write("How many items to this order? ");
            int nItems = int.Parse(Console.ReadLine());
            DateTime moment = DateTime.Now;
            Order order = new Order(moment, status, client);
            Console.WriteLine();

            for(int i = 1; i <= nItems; i++) {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write(" Product name:");
                string productName = Console.ReadLine();
                Console.Write("Product price:");
                double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity:");
                int quantity = int.Parse(Console.ReadLine());
                Product product = new Product(productName, productPrice);
                OrderItem item = new OrderItem(quantity, productPrice, product);
                order.AddItem(item);
                Console.WriteLine();
            }

            Console.WriteLine("ORDER SUMMARY: ");
            Console.WriteLine(order);

        }
    }
}
