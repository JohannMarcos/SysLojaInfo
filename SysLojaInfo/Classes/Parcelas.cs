using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLojaInfo.Classes
{
    internal class Parcelas : Pai
    {
        public Parcelas()
        {
            aForma = new FormasPag();
        }

        public int nParcela { get; set; }
        public int dias { get; set; }
        public double percent { get; set; }
        public FormasPag aForma { get; set; }
    }
}
