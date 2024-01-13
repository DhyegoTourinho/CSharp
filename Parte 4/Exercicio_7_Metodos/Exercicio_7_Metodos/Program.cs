using System;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
namespace Exercicio_7_Metodos {
    public class Program {
        static void Main(string[] args) {

            Produto p = new Produto ("TV", 1000.00, 2);

            p.Nome = "TVlizao";
            Console.WriteLine(p.Nome);
        }
    }

}