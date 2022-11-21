using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class csAccount : IAccount
    {
        public string AccountNumber { get; set ; }
        public decimal Saldo { get; set ; }
        public csAccount()
        {
            this.AccountNumber = "123-456-789";
            this.Saldo = 0;
        }
    }
    public struct strAccount : IAccount
    {
        public string AccountNumber { get; set; }
        public decimal Saldo { get; set; }
        public strAccount()
        {
            this.AccountNumber = "123-456-789";
            this.Saldo = 0;
        }
    }
}
