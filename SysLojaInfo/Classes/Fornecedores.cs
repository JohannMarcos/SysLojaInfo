using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLojaInfo.Classes
{
    internal class Fornecedores : Pessoas
    {
        public CondicoesPag aCond;
        public Fornecedores()
        {
            aCidade = new Cidades();

            aCond = new CondicoesPag();
        }
    }
}
