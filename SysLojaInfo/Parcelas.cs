using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLojaInfo
{
    internal class Parcelas: SysLojaInfo.Pai
    {
        public Parcelas() 
        {
            aForma = new FormasPag();
            aCond = new CondicoesPag();
        }

        public int nParcela {  get; set; }
        public int dias { get; set; }
        public double percent { get; set; }
        public CondicoesPag aCond {  get; set; }
        public FormasPag aForma { get; set; }
    }
}
