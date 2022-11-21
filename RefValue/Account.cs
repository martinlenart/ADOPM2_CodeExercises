using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefValue
{
    public class csAccount
    {
        public decimal Saldo;
        public csAccount()
        {
            this.Saldo = 0;
        }
    }
    public struct strAccount
    {
        public decimal Saldo;
        public strAccount()
        {
            this.Saldo = 0;
        }
    }
}
