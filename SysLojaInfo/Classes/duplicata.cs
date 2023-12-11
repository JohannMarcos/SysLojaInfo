using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLojaInfo.Classes
{
    internal class duplicata : Pai
    {
        public DateTime Vencimento { get; set; }
        public double Saldo { get; set; }
        public int nParcela { get; set; }

    }
}
