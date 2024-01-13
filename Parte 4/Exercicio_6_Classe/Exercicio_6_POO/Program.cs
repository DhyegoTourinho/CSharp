using System;
using System.Security.Cryptography.X509Certificates;

namespace Exercicio_6_POO { 
        public class Program {
            static void Main(string[] args) {
                Funcionario x = new Funcionario();
                Funcionario y = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionario");
            Console.Write("Nome: ");
            x.nome = Console.ReadLine();
            Console.Write("Salário: ");
            x.salario = double.Parse(Console.ReadLine());
            Console.WriteLine("Dados do segundo funcionario");
            Console.Write("Nome: ");
            y.nome = Console.ReadLine();
            Console.Write("Salário: ");
            y.salario = double.Parse(Console.ReadLine());

            double media = (y.salario + x.salario) / 2;

            Console.WriteLine($"Média dos salários: {media}");

        }
    }
}
