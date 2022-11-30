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
            var account2 = new stAccount();

            bank.Deposit(account1, 1000);
            bank.Deposit(account2, 1000);

            Console.WriteLine($"Amount: {account1.Saldo}");
            Console.WriteLine($"Last transaction (string): {account1.sLastTransaction}");
            Console.WriteLine($"Last transaction (stringBuilder): {account1.sbLastTransaction}");

            Console.WriteLine();
            Console.WriteLine($"Amount: {account2.Saldo}");
            Console.WriteLine($"Last transaction (string): {account2.sLastTransaction}");
            Console.WriteLine($"Last transaction (stringBuilder): {account2.sbLastTransaction}");
        }
    }
}
/*  Exercise
    1. Explain why the content in object account1 and account2 differs
*/
