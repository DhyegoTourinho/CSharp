using System;
using System.Runtime.Intrinsics.Arm;

namespace Conta_Bancaria {
    public class Program { 
        public static void Main(string[] args) {
            double valor;
            string confirmacao;

            Conta p = new Conta();

            //Atribuindo dados na conta.
            Console.Write("Numero da Conta: ");
            p.SetNumero(int.Parse(Console.ReadLine()));
            
            Console.Write("Nome do títular: ");
            p.Titular = (Console.ReadLine());
            
            //Verifica se quer um deposito inical.
            Console.Write("Haverá deposito inicial (s/n)? ");
            confirmacao = (Console.ReadLine());
            if (confirmacao == "s") {
                Console.Write("Entre com o valor do deposito inicial: ");
                p.Deposito(double.Parse(Console.ReadLine()));
                Console.WriteLine(p);
            }

            //Entrada do valor de deposito.
            Console.Write("\nEntre com um valor para deposito: ");
            p.Deposito(double.Parse(Console.ReadLine()));
            Console.WriteLine(p);

            //Entrada do valor de saque.
            Console.Write("\nEntre com um valor para saque");
            p.Saque(double.Parse(Console.ReadLine()));

            Console.WriteLine(p);

            
            
        }
    }
}