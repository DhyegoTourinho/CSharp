namespace DesafioHerancaPolimorfismo.Entities
{
    internal class TPCompany : TaxPayer
    {
        int NumberEmployee { get; set; }

        public TPCompany(int numberEmployee, string name, double anualIncome) : base(name, anualIncome)
        {
            NumberEmployee = numberEmployee;
        }

        public override double TaxedPaid()
        {
            return NumberEmployee > 10 ? AnualIncome * 0.14 : 0.16; 
        }
    }
}
