using MembrosEstaticos_2;
using System;
using System.Globalization;
    namespace CotacaoDoDolar { 
        class Program {
        static void Main(string[] args) {
            Console.Write("Qual é a cotação do dolar? ");
            ConversorDeMoeda.Cotacao = (double)double.Parse(Console.ReadLine());
            Console.Write("Quantos dolares você quer comprar? ");
            ConversorDeMoeda.Compra = (double)double.Parse(Console.ReadLine());
            Console.WriteLine("Valor a ser pago em reais = " + ConversorDeMoeda.TotalASerPago().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
