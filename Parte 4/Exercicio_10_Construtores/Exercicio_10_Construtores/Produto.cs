using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_7_Metodos {
    internal class Produto {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto() {
        }
        public Produto(string nome, double preco, int quantidade) {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }


        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }

        public void AdicionarProduto(int quant) {
            Quantidade += quant;
            ValorTotalEmEstoque();
        }

        public void RemoverProduto(int quant) {
            Quantidade -= quant;
            ValorTotalEmEstoque();
        }

        public override string ToString() {
            return Nome + ", $ " + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + Quantidade + " Unidade(s), Total: $ " + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
