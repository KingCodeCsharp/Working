using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Profeto Aprendiz");
            Console.WriteLine("----------------");
            Console.Write("Nome do usuário: ");
            string nome = Console.ReadLine();
            Console.WriteLine($"Olá {nome}!");
        }
    }
}
