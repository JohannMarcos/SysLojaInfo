using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLojaInfo
{
    internal class Fornecedores: SysLojaInfo.Pessoas
    {
        public Fornecedores()
        {
            aCidade = new Cidades();
        }
    }
}
