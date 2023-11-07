using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLojaInfo
{
    internal class CondicoesPag: SysLojaInfo.Pai
    {
        public CondicoesPag() { }

        public string condicao {  get; set; }
        public float taxa { get; set; }
        public float multa { get; set; }
        public float desconto { get; set; }

    }
}
