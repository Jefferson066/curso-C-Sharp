using S11Exeption.Entities;
using System;
using System.Globalization;
using S11Exeption.Entities.Exceptions;
using System.Collections.Generic;

namespace S11Exeption {
    class Program {
        
        static void Main(string[] args) {

           

            try {
                Console.WriteLine("Enter account data");
                Console.Write("Number ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double initialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Account account = new Account(number, holder, initialBalance, withdrawLimit);

                Console.Write("Enter amount for withdraw: ");
                double amountWithdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                account.Withdraw(amountWithdraw);
                Console.WriteLine("New balance:" + account.Balace);
            }
            catch (DomainException e) {
                Console.WriteLine("Withdraw error:" + e.Message);

            }
        }
    }
}
