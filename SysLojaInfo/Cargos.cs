using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLojaInfo
{
    internal class Cargos: SysLojaInfo.Pai
    {
        public Cargos() { }

        public string cargo { get; set; }

        public string externo { get; set;}
    }
}
