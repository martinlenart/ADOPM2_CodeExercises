using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefValue
{
    public class Bank
    {
        public string Name { get; set; }
        public csAccount Initialize1(csAccount acc1) {
            this.Name = "SEB";
            acc1.Saldo = 1000;

            return acc1;    
        }
        public strAccount Initialize2(strAccount acc1)
        {
            this.Name = "SEB";
            acc1.Saldo = 1000;

            return acc1;
        }

    }
}
