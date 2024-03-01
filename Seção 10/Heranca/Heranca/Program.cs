using System;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using Heranca.Entities;

namespace Heranca
{
    public class Program
    {
        static void Main(string[] args)
        {
            Account account = new SavingsAccount(1001, "Ana", 100.0, 0.1);

            account.Withdraw(10);
            Console.WriteLine(account.Balance);
            
        }
    }
}
