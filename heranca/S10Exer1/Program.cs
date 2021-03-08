using S10Exer1.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace S10Exer1 {
    class Program {
        static void Main(string[] args) {

            List<Employee> list = new List<Employee>();
            Console.Write("Enter the number of employees: ");
            int numEmployee = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numEmployee; i++) {
                Console.WriteLine($"Employee #{i} data:");
                Console.Write("Outsourced (y/n)? ");
                char resp = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour:");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


                if (resp == 'y') {

                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new OutsorcedEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else {
                    list.Add(new Employee(name, hours, valuePerHour));
                }

            }

            Console.WriteLine();
            Console.WriteLine("PAYMENTS: ");

            foreach (Employee value in list) {
                Console.WriteLine($"{value.Name} - $ {value.Payment().ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}
