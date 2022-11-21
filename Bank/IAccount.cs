using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public interface IAccount
    {
        public string AccountNumber { get; set; }
        public decimal Saldo { get; set; }
    }
}
