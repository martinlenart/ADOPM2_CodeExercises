using RefValue;
using System;

namespace Gavle // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bank = new Bank();
            var account1 = new csAccount();
            var account2 = new strAccount();

            account1 = bank.Initialize1(account1);
            account2 = bank.Initialize2(account2);

            Console.WriteLine(account1.Saldo);
            Console.WriteLine(account2.Saldo);
            


        }
    }
}
