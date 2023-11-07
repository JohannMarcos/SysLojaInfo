using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLojaInfo
{
    internal class Cidades: SysLojaInfo.Pai
    {
        public Cidades()
        {
            oEstado =  new Estados();
        }

        public string cidade {  get; set; }

        public string DDD { get; set; }
        public Estados oEstado { get; set; }
    }
}
