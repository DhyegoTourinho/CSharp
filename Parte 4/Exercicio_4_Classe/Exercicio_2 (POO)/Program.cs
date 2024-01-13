using Exercicio_2__POO_;
using System;
    
namespace Exercicio_2_POO {
    
    class Program {
        static void Main(string[] args) {
            Pessoa x = new Pessoa();
            Pessoa y = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            x.nome = Console.ReadLine();
            Console.Write("Idade: ");
            x.idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            y.nome = Console.ReadLine();
            Console.Write("Idade: ");
            y.idade = int.Parse(Console.ReadLine());

            if (x.idade > y.idade) {
                Console.WriteLine($"\nPessoa mais Velha: {x.nome}");
            } else if (x.idade < y.idade){
                Console.WriteLine($"\nPessoa mais Velha: {y.nome}");
            } else {
                Console.WriteLine("Possuem a mesma idade.");
            }
        }
    }
}
