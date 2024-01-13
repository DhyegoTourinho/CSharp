using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembrosEstaticos_2 {
   
    internal class ConversorDeMoeda {
        public static double Cotacao;
        public static double Compra;
        public static double Iof = 0.06;

        public static double TotalASerPago (){
            return Cotacao * Compra * Iof + Cotacao * Compra;
        }


    }
}
