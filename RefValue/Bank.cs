using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefValue
{
    public class Bank
    {
        public void Initialize(csAccount acc1, strAccount acc2) {
            acc1.Saldo = 1000;
            acc2.Saldo = 1000;
        }
    }
}
