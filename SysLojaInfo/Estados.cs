using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLojaInfo
{
    internal class Estados : SysLojaInfo.Pai
    {
        public Estados()
        {
            oPais = new Paises();
        }

        public string estado { get; set; }

        public string uf {  get; set; }

        public Paises oPais { get; set; }

    }
}
