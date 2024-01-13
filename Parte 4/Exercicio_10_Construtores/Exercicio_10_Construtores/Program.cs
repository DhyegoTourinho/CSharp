using System;
using System.Runtime.CompilerServices;
namespace Exercicio_7_Metodos {
    public class Program {
        static void Main(string[] args) {

            Console.Write("Dados do Produto: ");
            Console.Write("\nNome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = (double)double.Parse(Console.ReadLine());
            Console.Write("Quantidade: ");
            int quantidade = (int)int.Parse(Console.ReadLine());

            Produto x = new Produto(nome, preco, quantidade);

            Console.WriteLine("Dados do Produto: " + x);

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int quant = int.Parse(Console.ReadLine());
            x.AdicionarProduto(quant);

            Console.WriteLine("Dados do Produto: " + x);

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            quant = int.Parse(Console.ReadLine());
            x.RemoverProduto(quant);

            Console.WriteLine("Dados do Produto: " + x);
        }
    }

}