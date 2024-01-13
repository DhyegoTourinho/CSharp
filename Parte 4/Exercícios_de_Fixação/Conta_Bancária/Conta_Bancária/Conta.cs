using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace Conta_Bancaria {
        class Conta {
        
        private int Numero;
        public string Titular { get; set;}
        private double Saldo;

        public void SetNumero(int numero) {
            if (Numero == 0) {
                Numero = numero;
            } else {
                Console.WriteLine("Não é possível modificar o número da conta.");
            }
        }
        public void Deposito(double valorDeposito) {
            Saldo += valorDeposito;
        }
        public void Saque(double valorSaque) {
            Saldo -= (valorSaque + 5);
        }
        public override string ToString() {
            return "Dados da Conta:\n"
                + "Conta: "
                + Numero
                + ", Titular: "
                + Titular
                + ", Saldo: R$"
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
            }
    }
}
