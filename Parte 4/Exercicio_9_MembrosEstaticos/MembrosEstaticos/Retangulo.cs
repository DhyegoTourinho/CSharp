using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace MembrosEstaticos {
    internal class Retangulo {
        public static double Largura;
        public static double Altura;

        public static double Area() {
            return Largura * Altura;
        }

        public static double Perimetro() {
            return Largura + Largura + Altura + Altura;
        }

        public static double Diagonal() {
            return Math.Sqrt(Math.Pow(Largura, 2) + Math.Pow(Altura, 2));
        }
    }
}
