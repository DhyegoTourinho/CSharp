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
        public int Numero{get; set;}
        public string Titular { get; set;}
        public double Saldo { get; set;}

        

        public void deposito(double valorDeposito) {
            Saldo = valorDeposito;
        }

        public override string ToString() {
            return "Conta: "
                + Numero
                + ", Titular: "
                + Titular
                + ", Saldo: R$"
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
            }
    }
}
