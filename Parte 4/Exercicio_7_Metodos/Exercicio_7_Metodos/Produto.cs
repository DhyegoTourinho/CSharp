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
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }
        


        public Produto (string nome,  double preco, int quantidade) {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public string Nome {
            get {
                return _nome;
            }
            set {
                if (value != null && value.Length > 1) {
                    _nome = value;
                }
            }
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
            return   _nome 
                   + ", $ " 
                   + Preco.ToString("F2", CultureInfo.InvariantCulture) 
                   + ", " 
                   + Quantidade 
                   + " Unidade(s), Total: $ " 
                   + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
