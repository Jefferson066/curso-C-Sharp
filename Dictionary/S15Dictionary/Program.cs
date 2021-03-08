using System;
using System.IO;
using System.Collections.Generic;
namespace Course {
    class Program {
        static void Main(string[] args) {

            int a = 0;
            int b = 2;
            int c = Teste.soma(a, b);

            Console.WriteLine(c);



            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();
            try {
                using (StreamReader sr = File.OpenText(path)) {
                    while (!sr.EndOfStream) {
                        string[] line = sr.ReadLine().Split(',');
                        string candidato = line[0];
                        int votos = int.Parse(line[1]);

                        if (dictionary.ContainsKey(candidato)) {
                            dictionary[candidato] += votos;
                        }
                        else {
                            dictionary[candidato] = votos;
                        }
                    }
                    foreach (var item in dictionary) {
                        Console.WriteLine(item.Key + ": " + item.Value);
                    }
                }
            }
            catch (IOException e) {
                Console.WriteLine(e.Message);
            }
           
        }
    }
}