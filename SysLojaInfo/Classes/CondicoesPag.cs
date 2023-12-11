using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLojaInfo.Classes
{
    internal class CondicoesPag : Pai
    {
        public CondicoesPag() { }

        public string condicao { get; set; }
        public double taxa { get; set; }
        public double multa { get; set; }
        public double desconto { get; set; }

        public List<Parcelas> ListaParc { get; set; }

    }
}
