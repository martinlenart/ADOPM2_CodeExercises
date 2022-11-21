using System;

namespace Bank // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IBank bank = new Bank();
            IAccount account1 = new csAccount();
            IAccount account2 = new strAccount();

            bank.Initialize(account1, account2);

            Console.WriteLine(account1.Saldo);
            Console.WriteLine(account2.Saldo);
        }
    }
}
