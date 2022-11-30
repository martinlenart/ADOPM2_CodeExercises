using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace RefValue
{
    public class csAccount
    {
        public decimal Saldo;
        public string sLastTransaction;
        public StringBuilder sbLastTransaction;

        public csAccount()
        {
            this.Saldo = 0;
            sLastTransaction = null;
            sbLastTransaction = new StringBuilder();
        }
    }
    public struct stAccount
    {
        public decimal Saldo;
        public string sLastTransaction;
        public StringBuilder sbLastTransaction;
        public stAccount()
        {
            this.Saldo = 0;
            sLastTransaction = null;
            sbLastTransaction = new StringBuilder();

        }
    }
}
