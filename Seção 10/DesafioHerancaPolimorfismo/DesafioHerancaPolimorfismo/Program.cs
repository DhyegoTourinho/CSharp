using DesafioHerancaPolimorfismo.Entities;
using System;
using System.Globalization;
using System.Runtime.ExceptionServices;
namespace DesafioHerancaPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> TaxPayers = new List<TaxPayer>();
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExp = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    TaxPayers.Add(new TPIndividual(healthExp, name, anualIncome));
                }
                else 
                {
                    Console.Write("Health expenditures: ");
                    int numberEmployee = int.Parse(Console.ReadLine());
                    TaxPayers.Add(new TPCompany(numberEmployee, name, anualIncome));
                }

            }
            Console.WriteLine();
            Console.WriteLine("TAXED PAID: ");
            foreach(TaxPayer x in TaxPayers)
            {
                Console.WriteLine(x.Name + ": " + x.TaxedPaid().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
