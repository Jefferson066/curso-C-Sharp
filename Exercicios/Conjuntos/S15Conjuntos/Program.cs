using System;
using System.Collections.Generic;
namespace S15Conjuntos {
    class Program {
        static void Main(string[] args) {

            HashSet<int> a = new HashSet<int>();
            HashSet<int> b = new HashSet<int>();
            HashSet<int> c = new HashSet<int>();
            HashSet<int> d = new HashSet<int>();
            Console.WriteLine("How many students for course A? ");
            int n1 = int.Parse(Console.ReadLine());

            for (int i = 0; i <n1; i++) {
                int student = int.Parse(Console.ReadLine());
                a.Add(student);
            }

            Console.WriteLine("How many students for course B? ");
            int n2 = int.Parse(Console.ReadLine());

            for (int i = 0; i < n2; i++) {
                int student = int.Parse(Console.ReadLine());
                b.Add(student);
            }

            Console.WriteLine("How many students for course c? ");
            int n3 = int.Parse(Console.ReadLine());

            for (int i = 0; i < n3; i++) {
                int student = int.Parse(Console.ReadLine());
                c.Add(student);
            }

            d.UnionWith(a);
            d.UnionWith(b);
            d.UnionWith(c);

            Console.WriteLine("Total students: " + d.Count);
        }
    }
}
