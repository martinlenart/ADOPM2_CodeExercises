using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Bank: IBank
    {
        public string Name { get; set; }
        public void Initialize(IAccount acc1, IAccount acc2)
        {
            this.Name = "SEB";
            acc1.Saldo = 1000;
            acc2.Saldo = 1000;

        }
    }
}
