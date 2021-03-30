using Microsoft.VisualBasic;
using S10Exer2.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace S10Exer2 {
    class Program {
        static void Main(string[] args) {

            List<Product> list = new List<Product>();
            Console.WriteLine("Enter the number of products: ");
            int nProduct = int.Parse(Console.ReadLine());
            //Console.WriteLine();

            for (int i = 1; i <= nProduct; i++) {
                Console.Write($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)?");
                char letra = char.Parse(Console.ReadLine());
                Console.Write("name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (letra == 'c') {
                    list.Add( new Product(name, price)); 


                } else if(letra == 'u') {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    list.Add( new UsedProduct(name, price, date));
                }
                else {
                    Console.Write("Customs fee:");
                    double customFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add( new ImportedProduct(name, price, customFee));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS");
            foreach (Product value in list) {
                Console.WriteLine(value.PriceTag());
            }

        }
    }
}
