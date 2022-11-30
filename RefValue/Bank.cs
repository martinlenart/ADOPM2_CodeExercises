using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefValue
{
    public class Bank
    {
        public string Name { get; set; } = "SEB";
        public void Deposit(csAccount acc, decimal Amount) {
            acc.Saldo = 1000;
            acc.sLastTransaction = $"Added {Amount:C2}";
            acc.sbLastTransaction.Append($"Added {Amount:C2}");
        }
        public void Deposit(stAccount acc, decimal Amount)
        {
            acc.Saldo = 1000;
            acc.sLastTransaction = $"Added {Amount:C2}";
            acc.sbLastTransaction.Append($"Added {Amount:C2}");
        }
    }
}
