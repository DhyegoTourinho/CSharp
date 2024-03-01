using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioHerancaPolimorfismo.Entities
{
    internal class TPIndividual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public TPIndividual(double healthExp, string name, double anualIncome) : base(name, anualIncome)
        {
            HealthExpenditures = healthExp;
        }

        public override double TaxedPaid()
        {
            return AnualIncome < 20000 ? AnualIncome * 0.15 - HealthExpenditures * 0.5 : AnualIncome * 0.25 - HealthExpenditures * 0.5;
        }
    }
}
