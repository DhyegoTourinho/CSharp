using System;
using System.Runtime.Intrinsics.Arm;

namespace Conta_Bancaria {
    public class Program { 
        public static void Main(string[] args) {
            Conta p = new Conta();
            
            Console.Write("Numero da Conta: ");
            p.Numero = int.Parse(Console.ReadLine());
            
            Console.Write("Nome do títular: ");
            p.Titular = (Console.ReadLine());
            
            Console.Write("Haverá deposito inicial (s/n)? ");
            string confirmacao = (Console.ReadLine());

            if (confirmacao == "s") {
                Console.Write("Entre com o valor do deposito inicial: ");
                double valor = double.Parse(Console.ReadLine());
                p.deposito(valor);
            }

            Console.WriteLine("Dados da conta:");
            Console.WriteLine(p);

            
        }
    }
}