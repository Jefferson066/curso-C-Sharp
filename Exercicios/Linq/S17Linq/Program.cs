using System;
using System.IO;
using System.Collections.Generic;
using S17Linq.Entities;
using System.Globalization;
using System.Linq;
namespace S17Linq {
    class Program {
        static void Main(string[] args) {

            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            List<Employee> list = new List<Employee>();

            using(StreamReader sr = File.OpenText(path)) {
                while (!sr.EndOfStream) {
                    string[] file = sr.ReadLine().Split(',');
                    string name = file[0];
                    string email = file[1];
                    double salary = double.Parse(file[2], CultureInfo.InvariantCulture);
                    list.Add(new Employee(name, email, salary));
                }
            }
            Console.WriteLine();

            Console.WriteLine("Enter salary minimun: ");
            double salaryMini = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Email of people whose salary is more than {salaryMini.ToString("F2", CultureInfo.InvariantCulture)}:");


            var query =
                //list.Where(x => x.Salary > salaryMini).OrderBy(x => x.Email).Select(x=>x.Email);
                from p in list
                where p.Salary > salaryMini
                orderby p.Name
                orderby p.Email
                select p.Email;

            foreach (var obj in query) {
                Console.WriteLine(obj);
            }
            Console.WriteLine();

            var sum =
                //list.Where(obj => obj.Name[0] == 'M').Select(obj => obj.Salary).Sum();
                (from obj in list
                 where obj.Name[0] == 'M'
                 select obj.Salary).Sum();
                


            Console.WriteLine("Sum of salary of people whose name starts with 'M': " + sum);
           

            
        }
    }
}
