using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public interface IBank
    {
        public string Name { get; set; }
        public void Initialize(IAccount acc1, IAccount acc2);
    }
}
