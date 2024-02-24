using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Lista_De_Funcionarios {
    internal class Funcionario {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }
        
        public Funcionario(int id, string nome, double salario) {
            Id = id;
            Nome = nome;
            Salario = salario;
        }
        public void ReajusteSalarial(double reajuste) { 
            Salario += Salario * reajuste / 100;
        }
        
        public override string ToString() {
            return Id + ", " + Nome + ", " + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
