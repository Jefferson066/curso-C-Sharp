using System;
using System.Collections.Generic;
using System.Text;

namespace S17Linq.Entities {
    class Employee {
        public string Name { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }

        public Employee(string nmae, string email, double salary) {
            Name = nmae;
            Email = email;
            Salary = salary;
        }


    }
}
